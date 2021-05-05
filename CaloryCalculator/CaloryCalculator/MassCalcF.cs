using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloryCalculator
{
    
    public partial class MassCalcF : Form
    {
        public int age;
        public int hight;
        public int weight;
        public int gender;

        Form1 fm1;

        public MassCalcF(Form1 main)
        {
            InitializeComponent();
            GetGender();
            fm1 = main;
        }

        private void Calc()
        {
            double resR;
            double resS;
            double resI;
            

            try
            {
                age = Int32.Parse(txtAge.Text);
                hight = Int32.Parse(txtHight.Text);
                weight = Int32.Parse(txtWeight.Text);
                
                    if (cmbGender.Text == "Male")
                    {
                        gender = 5;
                    }
                    else if (cmbGender.Text == "Female")
                    {
                        gender = -161;
                    }
                    else if (string.IsNullOrEmpty(cmbGender.Text))
                    {
                    MessageBox.Show("Please, fill all field!!");
                    return;
                    }
                    resS = 10 * weight + 6.25 * hight - 5 * age + gender;
                    resR = (10 * weight + 6.25 * hight - 5 * age + gender) - 250;
                    resI = (10 * weight + 6.25 * hight - 5 * age + gender) + 350;
                    fm1.SaveW = resS.ToString();
                    fm1.IncrW = resI.ToString();
                    fm1.RedW = resR.ToString();

                    this.Close();
               
            }
            catch (Exception ex)
            {
                if ( txtAge.Text != "" || txtHight.Text != "" || txtWeight.Text != "")
                {
                    MessageBox.Show("Please, fill all field!!");
                }
                else
                    
                MessageBox.Show(ex.Message);
            }     
        }

        private void GetGender()
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void txtHight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete) && (e.KeyChar != (char)Keys.Decimal))
            {
                e.Handled = true;
            }
        }
    }
}
