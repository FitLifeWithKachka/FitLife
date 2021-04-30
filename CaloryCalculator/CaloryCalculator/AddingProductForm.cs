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
    public partial class AddingProductForm : Form
    {
        private Product _product;
        private bool changed = false;
        public AddingProductForm(Product prod = null)
        {
            InitializeComponent();

            if (prod != null)
            {
                _product = prod;
                btnConfirm.Text = "Change";
                tbName.Text = prod.Name;
                tbCalories.Text = prod.Calories.ToString();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbCalories.Text))
            {
                MessageBox.Show("Fields can't be empty!");
                return;
            }


            using (var fc = new FitLifeDataContent())
            {
                if (_product == null)
                {
                    _product = new Product() { Name = tbName.Text, Calories = int.Parse(tbCalories.Text) };
                    fc.Products.Add(_product);
                }
                else
                {
                    if (_product.Name != tbName.Text)
                    {
                        _product.Name = tbName.Text;
                        changed = true;
                    }

                    if (_product.Calories != int.Parse(tbCalories.Text))
                    {
                        _product.Calories = int.Parse(tbCalories.Text);
                        changed = true;
                    }

                    if (changed)
                    {
                        if (DialogResult.OK == MessageBox.Show("Are you sure?", "Product will be changed!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                            fc.Entry(_product).State = System.Data.Entity.EntityState.Modified;
                        else
                            this.Close();
                    }
                }

                fc.SaveChanges();
                this.Close();
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_product != null)
            {
                if (_product.Name == tbName.Text)
                {
                    changed = false;
                }

                if (_product.Calories == int.Parse(tbCalories.Text))
                {
                    changed = false;
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(tbName.Text) || !string.IsNullOrWhiteSpace(tbCalories.Text))
                    changed = true;
            }

            if (changed)
            {
                if (DialogResult.OK == MessageBox.Show("Are you sure?", "Changes won't be saved!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                    this.Close();
            }
            else
                this.Close();

                
        }

        private void tbCalories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }

            changed = true;
        }
    }
}
