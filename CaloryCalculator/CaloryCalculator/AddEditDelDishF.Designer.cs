
namespace CaloryCalculator
{
    partial class AddEditDelDishF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDish = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIngr = new System.Windows.Forms.TextBox();
            this.txtCalory = new System.Windows.Forms.TextBox();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbDishId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dish name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calory";
            // 
            // txtDish
            // 
            this.txtDish.Location = new System.Drawing.Point(94, 63);
            this.txtDish.Name = "txtDish";
            this.txtDish.Size = new System.Drawing.Size(100, 22);
            this.txtDish.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dish id";
            // 
            // txtIngr
            // 
            this.txtIngr.Location = new System.Drawing.Point(94, 91);
            this.txtIngr.Name = "txtIngr";
            this.txtIngr.Size = new System.Drawing.Size(100, 22);
            this.txtIngr.TabIndex = 5;
            // 
            // txtCalory
            // 
            this.txtCalory.Location = new System.Drawing.Point(94, 126);
            this.txtCalory.Name = "txtCalory";
            this.txtCalory.Size = new System.Drawing.Size(100, 22);
            this.txtCalory.TabIndex = 6;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(249, 64);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(54, 21);
            this.rbAdd.TabIndex = 7;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Location = new System.Drawing.Point(249, 94);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(53, 21);
            this.rbEdit.TabIndex = 8;
            this.rbEdit.TabStop = true;
            this.rbEdit.Text = "Edit";
            this.rbEdit.UseVisualStyleBackColor = true;
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(249, 121);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(70, 21);
            this.rbDelete.TabIndex = 9;
            this.rbDelete.TabStop = true;
            this.rbDelete.Text = "Delete";
            this.rbDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbDishId
            // 
            this.cmbDishId.FormattingEnabled = true;
            this.cmbDishId.Location = new System.Drawing.Point(94, 32);
            this.cmbDishId.Name = "cmbDishId";
            this.cmbDishId.Size = new System.Drawing.Size(65, 24);
            this.cmbDishId.TabIndex = 11;
            // 
            // AddEditDelDishF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 166);
            this.Controls.Add(this.cmbDishId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbDelete);
            this.Controls.Add(this.rbEdit);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.txtCalory);
            this.Controls.Add(this.txtIngr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEditDelDishF";
            this.Text = "AddEditDelDishF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIngr;
        private System.Windows.Forms.TextBox txtCalory;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbEdit;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbDishId;
    }
}