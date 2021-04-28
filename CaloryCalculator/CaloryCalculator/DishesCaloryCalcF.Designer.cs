
namespace CaloryCalculator
{
    partial class DishesCaloryCalcF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDish = new System.Windows.Forms.ListBox();
            this.lbProd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalory = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDish
            // 
            this.lbDish.FormattingEnabled = true;
            this.lbDish.ItemHeight = 16;
            this.lbDish.Location = new System.Drawing.Point(13, 23);
            this.lbDish.Name = "lbDish";
            this.lbDish.Size = new System.Drawing.Size(221, 340);
            this.lbDish.TabIndex = 0;
            // 
            // lbProd
            // 
            this.lbProd.FormattingEnabled = true;
            this.lbProd.ItemHeight = 16;
            this.lbProd.Location = new System.Drawing.Point(240, 23);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(221, 340);
            this.lbProd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Summ of Calory";
            // 
            // txtCalory
            // 
            this.txtCalory.Location = new System.Drawing.Point(530, 62);
            this.txtCalory.Name = "txtCalory";
            this.txtCalory.Size = new System.Drawing.Size(136, 22);
            this.txtCalory.TabIndex = 3;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(530, 121);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(136, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete Dish/Prod";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(546, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // DishesCaloryCalcF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 376);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtCalory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.lbDish);
            this.Name = "DishesCaloryCalcF";
            this.Text = "DishesCaloryCalcF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDish;
        private System.Windows.Forms.ListBox lbProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalory;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
    }
}