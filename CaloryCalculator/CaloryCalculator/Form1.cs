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
    public partial class Form1 : Form
    {

        BindingList<Product> _products = new BindingList<Product>();
        BindingList<DishInfo> _dishes = new BindingList<DishInfo>();
        public Form1()
        {
            InitializeComponent();

            lbActWithProducts.DataSource = _products;
            lbActWithProducts.DisplayMember = "Name";

            lbActWithDishes.DataSource = _dishes;
            lbActWithDishes.DisplayMember = "Name";


            UpdateMyData();
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        }
        public string IncrW
        {
            get { return txtIncW.Text; }
            set { txtIncW.Text = value; }
        }

        public string SaveW
        {
            get { return txtSaveW.Text; }
            set { txtSaveW.Text = value; }
        }

        public string RedW
        {
            get { return txtRedW.Text; }
            set { txtRedW.Text = value; }
        }
        private void UpdateMyData()
        {
            using (var fc = new FitLifeDataContent())
            {
                _products.Clear();
                _dishes.Clear();
                foreach (var item in fc.Products)
                {
                    _products.Add(item);
                }

                foreach (var item in fc.Dishes)
                {
                    _dishes.Add(new DishInfo(item));
                }
            }

            if (lbActWithProducts.SelectedItem != null )
                lbActWithProducts_SelectedIndexChanged(this, new EventArgs());

            if (lbActWithDishes.SelectedItem != null)
                lbActWithDishes_SelectedIndexChanged(this, new EventArgs());

        }

        private void lbActWithProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProductsProductName.Text = ((Product)lbActWithProducts.SelectedItem).Name;
            lblProductsProductCalories.Text = ((Product)lbActWithProducts.SelectedItem).Calories.ToString();
        }

        private void lbActWithDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDishesDishName.Text = ((DishInfo)lbActWithDishes.SelectedItem).Name;
            lblDishesDishCalories.Text = ((DishInfo)lbActWithDishes.SelectedItem).Calories.ToString();

            lbDishesProducts.DataSource = ((DishInfo)lbActWithDishes.SelectedItem).Products;
            lbDishesProducts.DisplayMember = "Name";

        } //пофиксить - при удалении последнего блюда в лб и тб остаются его данные

        private void btnProductsAdd_Click(object sender, EventArgs e)
        {
            using (var addingForm = new AddingProductForm())
            {
                addingForm.ShowDialog();
            }

            UpdateMyData();
        }

        private void btnProductsEdit_Click(object sender, EventArgs e)
        {
            using (var addingForm = new AddingProductForm((Product)lbActWithProducts.SelectedItem))
            {
                addingForm.ShowDialog();
            }

            UpdateMyData();
        }

        private void btnProductsDelete_Click(object sender, EventArgs e)
        {
            if (lbActWithProducts.SelectedItem == null)
                return;

            using (var fc = new FitLifeDataContent())
            {
                var prod = (Product)lbActWithProducts.SelectedItem;
                if (!(DialogResult.Yes == MessageBox.Show($"Are u sure about deleting   <{prod.Name}>   element\nAll dishes that include this product will be deleted", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
                    return;

                DishKiller(fc, prod.Id);

                fc.Products.Remove(fc.Products.Find(prod.Id));
                fc.SaveChanges();
                UpdateMyData();
            }

            if (lbActWithProducts.Items.Count == 0)
            {
                lblProductsProductCalories.Text = string.Empty;
                lblProductsProductName.Text = string.Empty;
            }
        }

        private void DishKiller(FitLifeDataContent fc ,int id)
        {
            foreach (var item in _dishes)
            {
                foreach (var prod in item.Products)
                {
                    if (prod.Id == id)
                        fc.Dishes.Remove(fc.Dishes.Find(item.Id));
                }
            }
        }
        private void btnDishesAdd_Click(object sender, EventArgs e)
        {
            using (var adf = new AddingDishForm(_products))
            {
                adf.ShowDialog();
            }

            UpdateMyData();
        }

        private void btnDishesEdit_Click(object sender, EventArgs e)
        {
            using (var adf = new AddingDishForm(_products, (DishInfo)lbActWithDishes.SelectedItem))
            {
                adf.ShowDialog();
            }

            UpdateMyData();
        }

        private void btnDishesDelete_Click(object sender, EventArgs e)
        {
            if (lbActWithDishes.SelectedItem == null)
                return;

            using (var fc = new FitLifeDataContent())
            {
                var dish = (DishInfo)lbActWithDishes.SelectedItem;
                if (!(DialogResult.Yes == MessageBox.Show($"Are u sure about deleting   <{dish.Name}>   element", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)))
                    return;

                fc.Dishes.Remove(fc.Dishes.Find(dish.Id));
                fc.SaveChanges();
                UpdateMyData();
            }

            if (lbActWithDishes.Items.Count == 0)
            {
                lbDishesProducts.Items?.Clear();
                lblDishesDishCalories.Text = string.Empty;
                lblDishesDishName.Text = string.Empty;
            }

        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        private void btnMassCalc_Click(object sender, EventArgs e)
        {
            MassCalcF mc = new MassCalcF();
            
                this.Hide();
                mc.Closed += (s, args) => this.Close();
                mc.Show();
            
        }

        private void Finder()
        {
            lbDish.Items.Clear();
            foreach (var item in lbActWithDishes.Items)
            {
                if ( ((DishInfo)item).Name.Contains(tbDishS.Text) )
                {
                    lbDish.Items.Add(item);
                }
            }
        }

        private void tbDishS_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDishS.Text))
            {
                lbDish.Items.Clear();
                return;
            }


            Task.Run(Finder);
        }
    }
}
