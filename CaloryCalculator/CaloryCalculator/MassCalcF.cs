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
    public partial class MassCalcF : Form
    {
        public int age;
        public int hight;
        public int weight;
        public int gender;
        
        
        public MassCalcF()
        {
            InitializeComponent();
            GetGender();
        }

        private void Calc()
        {
            double resR;
            double resS;
            double resI;
            age = Int32.Parse(txtAge.Text);
            hight = Int32.Parse(txtHight.Text);
            weight = Int32.Parse(txtWeight.Text);
            try
            {
                if(cmbGender.Text == "Male")
                {
                    gender = 5;
                }
                else if(cmbGender.Text == "Female")
                {
                    gender = -161;
                }

                resS = 10 * weight + 6.25 * hight - 5 * age + gender;
                resR = (10 * weight + 6.25 * hight - 5 * age + gender)-250;
                resI = (10 * weight + 6.25 * hight - 5 * age + gender)+350;
                txtSaveW.Text = resS.ToString();
                txtIncW.Text = resI.ToString();
                txtRedW.Text = resR.ToString();
            }
            catch (Exception ex)
            {
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
            this.Close();
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
