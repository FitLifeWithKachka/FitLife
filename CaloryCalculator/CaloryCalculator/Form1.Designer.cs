
namespace CaloryCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDishesList = new System.Windows.Forms.ListBox();
            this.lbIngrList = new System.Windows.Forms.ListBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnMassCalc = new System.Windows.Forms.Button();
            this.btnAddCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDishesList
            // 
            this.lbDishesList.FormattingEnabled = true;
            this.lbDishesList.ItemHeight = 16;
            this.lbDishesList.Location = new System.Drawing.Point(13, 42);
            this.lbDishesList.Name = "lbDishesList";
            this.lbDishesList.Size = new System.Drawing.Size(318, 404);
            this.lbDishesList.TabIndex = 0;
            // 
            // lbIngrList
            // 
            this.lbIngrList.FormattingEnabled = true;
            this.lbIngrList.ItemHeight = 16;
            this.lbIngrList.Location = new System.Drawing.Point(355, 42);
            this.lbIngrList.Name = "lbIngrList";
            this.lbIngrList.Size = new System.Drawing.Size(318, 276);
            this.lbIngrList.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(355, 385);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(139, 55);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Calculate";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(516, 324);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(139, 55);
            this.btnAddEdit.TabIndex = 3;
            this.btnAddEdit.Text = "Add/Edit/DeleteDishes";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            // 
            // btnMassCalc
            // 
            this.btnMassCalc.Location = new System.Drawing.Point(516, 385);
            this.btnMassCalc.Name = "btnMassCalc";
            this.btnMassCalc.Size = new System.Drawing.Size(139, 55);
            this.btnMassCalc.TabIndex = 6;
            this.btnMassCalc.Text = "MassCalculator";
            this.btnMassCalc.UseVisualStyleBackColor = true;
            // 
            // btnAddCalc
            // 
            this.btnAddCalc.Location = new System.Drawing.Point(355, 324);
            this.btnAddCalc.Name = "btnAddCalc";
            this.btnAddCalc.Size = new System.Drawing.Size(139, 55);
            this.btnAddCalc.TabIndex = 7;
            this.btnAddCalc.Text = "Add to Calc List";
            this.btnAddCalc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.btnAddCalc);
            this.Controls.Add(this.btnMassCalc);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lbIngrList);
            this.Controls.Add(this.lbDishesList);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDishesList;
        private System.Windows.Forms.ListBox lbIngrList;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnMassCalc;
        private System.Windows.Forms.Button btnAddCalc;
    }
}

