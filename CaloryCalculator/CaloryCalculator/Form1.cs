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
        public Form1()
        {
            InitializeComponent();

            foreach (var item in new FitLifeDataContent().Products)
            {
                _products.Add(item);
            }

            lbActWithProducts.DataSource = _products;
            lbActWithProducts.DisplayMember = "Name";
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        }

        private void lbActWithProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProductsProductName.Text = ((Product)lbActWithProducts.SelectedItem).Name;
            lblProductsProductCalories.Text = ((Product)lbActWithProducts.SelectedItem).Calories.ToString();
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


    }
}
