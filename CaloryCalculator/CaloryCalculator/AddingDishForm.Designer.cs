
namespace CaloryCalculator
{
    partial class AddingDishForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbCalories = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lbIngredients = new System.Windows.Forms.ListBox();
            this.btnToDish = new System.Windows.Forms.Button();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToStorage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(434, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(204, 39);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbCalories
            // 
            this.tbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCalories.Location = new System.Drawing.Point(512, 12);
            this.tbCalories.Name = "tbCalories";
            this.tbCalories.ReadOnly = true;
            this.tbCalories.Size = new System.Drawing.Size(126, 34);
            this.tbCalories.TabIndex = 30;
            this.tbCalories.Text = "0";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(111, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(236, 34);
            this.tbName.TabIndex = 29;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(10, 399);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(207, 39);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Add";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCalories.Location = new System.Drawing.Point(392, 15);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(103, 29);
            this.lblCalories.TabIndex = 27;
            this.lblCalories.Text = "Calories";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(9, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIngredients.Location = new System.Drawing.Point(12, 64);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(133, 29);
            this.lblIngredients.TabIndex = 32;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lbIngredients
            // 
            this.lbIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbIngredients.ItemHeight = 29;
            this.lbIngredients.Location = new System.Drawing.Point(17, 112);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(237, 265);
            this.lbIngredients.TabIndex = 33;
            // 
            // btnToDish
            // 
            this.btnToDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToDish.Location = new System.Drawing.Point(281, 155);
            this.btnToDish.Name = "btnToDish";
            this.btnToDish.Size = new System.Drawing.Size(85, 39);
            this.btnToDish.TabIndex = 34;
            this.btnToDish.Text = "<---";
            this.btnToDish.UseVisualStyleBackColor = true;
            this.btnToDish.Click += new System.EventHandler(this.btnToDish_Click);
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 29;
            this.lbProducts.Location = new System.Drawing.Point(397, 112);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(241, 265);
            this.lbProducts.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(351, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "List of accessible products";
            // 
            // btnToStorage
            // 
            this.btnToStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToStorage.Location = new System.Drawing.Point(281, 248);
            this.btnToStorage.Name = "btnToStorage";
            this.btnToStorage.Size = new System.Drawing.Size(85, 39);
            this.btnToStorage.TabIndex = 37;
            this.btnToStorage.Text = "--->";
            this.btnToStorage.UseVisualStyleBackColor = true;
            this.btnToStorage.Click += new System.EventHandler(this.btnToStorage_Click);
            // 
            // AddingDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btnToStorage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.btnToDish);
            this.Controls.Add(this.lbIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCalories);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddingDishForm";
            this.Text = "AddingDishForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbCalories;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.ListBox lbIngredients;
        private System.Windows.Forms.Button btnToDish;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToStorage;
    }
}