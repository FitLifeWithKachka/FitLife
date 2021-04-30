using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloryCalculator
{
    public partial class AddingDishForm : Form
    {
        DishInfo _dishInfo;

        private BindingList<Product> _productsList;
        private BindingList<Product> _ingList;
        public AddingDishForm(BindingList<Product> products, DishInfo df = null)
        {
            InitializeComponent();
            _productsList = new BindingList<Product>();

            foreach (var item in products)
            {
                _productsList.Add(item);
            }

            _ingList = new BindingList<Product>();

            if (df != null)
            {
                _dishInfo = df;
                tbName.Text = _dishInfo.Name;
                btnConfirm.Text = "Change";

                int c = 0;

                foreach (var item in df.Products)
                {
                    _ingList.Add(item);
                    c += item.Calories;
                }
                tbCalories.Text = c.ToString();

                /*foreach (var item in _ingList)
                {
                    _productsList.Remove(item);
                } does't working shit!*/ 
            }

            Fixer();


            lbIngredients.DataSource = _ingList;
            lbIngredients.DisplayMember = "Name";

            lbProducts.DataSource = _productsList;
            lbProducts.DisplayMember = "Name";
        }

        private void Fixer() //ya ohuel eto pisat!
        { 
            foreach (var item in _ingList)
            {
                Product tmp = new Product();
                foreach (var p in _productsList)
                {
                    if (p.Id == item.Id)
                    {
                        tmp = p;
                    }
                }

                _productsList.Remove(tmp);
            }
        }

        private void btnToDish_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItem == null)
                return;

            int calory = int.Parse(tbCalories.Text);
            calory += ((Product)lbProducts.SelectedItem).Calories;
            tbCalories.Text = calory.ToString();

            _ingList?.Add((Product)lbProducts.SelectedItem);
            _productsList?.Remove((Product)lbProducts.SelectedItem);
        }

        private void btnToStorage_Click(object sender, EventArgs e)
        {
            if (lbIngredients.SelectedItem == null)
                return;

            int calory = int.Parse(tbCalories.Text);
            calory -= ((Product)lbIngredients.SelectedItem).Calories;
            tbCalories.Text = calory.ToString();

            _productsList?.Add((Product)lbIngredients.SelectedItem);
            _ingList?.Remove((Product)lbIngredients.SelectedItem);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Are you sure?", "Changes won't be saved!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Enter dish Name!");
                return;
            }

            string tmpIds = string.Empty;

            foreach (var item in lbIngredients.Items)
            {
                tmpIds += $"{((Product)item).Id} ";  
            }

            tmpIds = tmpIds.Substring(0, tmpIds.Length - 1);

            var dish = new Dish() { Name = tbName.Text, Calories = int.Parse(tbCalories.Text), ProductsIds = tmpIds };

            using (var fc = new FitLifeDataContent())
            {
                if (_dishInfo != null)
                {
                    dish.Id = _dishInfo.Id;

                    if (DialogResult.OK == MessageBox.Show("Are you sure?", "Dish will be changed!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                        fc.Entry(dish).State = System.Data.Entity.EntityState.Modified;
                    else
                        this.Close();         
                }
                else
                {
                    fc.Dishes.Add(dish);
                }

                fc.SaveChanges();
                this.Close();
            }

        }
    }
}
