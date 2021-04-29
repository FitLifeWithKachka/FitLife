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

        private void UpdateMyData()
        {
            var fc = new FitLifeDataContent();

            foreach (var item in fc.Products)
            {
                _products.Add(item);
            }

            foreach (var item in fc.Dishes)
            {
                _dishes.Add(new DishInfo(item));
            }
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
            
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    }
}
