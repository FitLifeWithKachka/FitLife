
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
            this.btnMassCalc = new System.Windows.Forms.Button();
            this.btnAddCalc = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDishesDelete = new System.Windows.Forms.Button();
            this.btnDishesEdit = new System.Windows.Forms.Button();
            this.btnDishesAdd = new System.Windows.Forms.Button();
            this.lbDishesProducts = new System.Windows.Forms.ListBox();
            this.lblDishesProducts = new System.Windows.Forms.Label();
            this.lblDishesDishCalories = new System.Windows.Forms.Label();
            this.lblDishesCalories = new System.Windows.Forms.Label();
            this.lblDishesDishName = new System.Windows.Forms.Label();
            this.lblDishesName = new System.Windows.Forms.Label();
            this.lbActWithDishes = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnProductsDelete = new System.Windows.Forms.Button();
            this.btnProductsEdit = new System.Windows.Forms.Button();
            this.btnProductsAdd = new System.Windows.Forms.Button();
            this.lblProductsProductCalories = new System.Windows.Forms.Label();
            this.lblProductsCalories = new System.Windows.Forms.Label();
            this.lblProductsProductName = new System.Windows.Forms.Label();
            this.lblProductsName = new System.Windows.Forms.Label();
            this.lbActWithProducts = new System.Windows.Forms.ListBox();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDishesList
            // 
            this.lbDishesList.FormattingEnabled = true;
            this.lbDishesList.ItemHeight = 16;
            this.lbDishesList.Location = new System.Drawing.Point(4, 6);
            this.lbDishesList.Name = "lbDishesList";
            this.lbDishesList.Size = new System.Drawing.Size(318, 404);
            this.lbDishesList.TabIndex = 0;
            // 
            // lbIngrList
            // 
            this.lbIngrList.FormattingEnabled = true;
            this.lbIngrList.ItemHeight = 16;
            this.lbIngrList.Location = new System.Drawing.Point(346, 6);
            this.lbIngrList.Name = "lbIngrList";
            this.lbIngrList.Size = new System.Drawing.Size(318, 276);
            this.lbIngrList.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(346, 349);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(139, 55);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Calculate";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnMassCalc
            // 
            this.btnMassCalc.Location = new System.Drawing.Point(507, 349);
            this.btnMassCalc.Name = "btnMassCalc";
            this.btnMassCalc.Size = new System.Drawing.Size(139, 55);
            this.btnMassCalc.TabIndex = 6;
            this.btnMassCalc.Text = "MassCalculator";
            this.btnMassCalc.UseVisualStyleBackColor = true;
            this.btnMassCalc.Click += new System.EventHandler(this.btnMassCalc_Click);
            // 
            // btnAddCalc
            // 
            this.btnAddCalc.Location = new System.Drawing.Point(346, 288);
            this.btnAddCalc.Name = "btnAddCalc";
            this.btnAddCalc.Size = new System.Drawing.Size(139, 55);
            this.btnAddCalc.TabIndex = 7;
            this.btnAddCalc.Text = "Add to Calc List";
            this.btnAddCalc.UseVisualStyleBackColor = true;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Controls.Add(this.tabPage3);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(696, 446);
            this.tcMain.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbIngrList);
            this.tabPage1.Controls.Add(this.btnAddCalc);
            this.tabPage1.Controls.Add(this.lbDishesList);
            this.tabPage1.Controls.Add(this.btnMassCalc);
            this.tabPage1.Controls.Add(this.btnAddProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDishesDelete);
            this.tabPage2.Controls.Add(this.btnDishesEdit);
            this.tabPage2.Controls.Add(this.btnDishesAdd);
            this.tabPage2.Controls.Add(this.lbDishesProducts);
            this.tabPage2.Controls.Add(this.lblDishesProducts);
            this.tabPage2.Controls.Add(this.lblDishesDishCalories);
            this.tabPage2.Controls.Add(this.lblDishesCalories);
            this.tabPage2.Controls.Add(this.lblDishesDishName);
            this.tabPage2.Controls.Add(this.lblDishesName);
            this.tabPage2.Controls.Add(this.lbActWithDishes);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dishes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDishesDelete
            // 
            this.btnDishesDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDishesDelete.Location = new System.Drawing.Point(473, 364);
            this.btnDishesDelete.Name = "btnDishesDelete";
            this.btnDishesDelete.Size = new System.Drawing.Size(183, 39);
            this.btnDishesDelete.TabIndex = 9;
            this.btnDishesDelete.Text = "Delete";
            this.btnDishesDelete.UseVisualStyleBackColor = true;
            this.btnDishesDelete.Click += new System.EventHandler(this.btnDishesDelete_Click);
            // 
            // btnDishesEdit
            // 
            this.btnDishesEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDishesEdit.Location = new System.Drawing.Point(244, 364);
            this.btnDishesEdit.Name = "btnDishesEdit";
            this.btnDishesEdit.Size = new System.Drawing.Size(183, 39);
            this.btnDishesEdit.TabIndex = 8;
            this.btnDishesEdit.Text = "Edit";
            this.btnDishesEdit.UseVisualStyleBackColor = true;
            this.btnDishesEdit.Click += new System.EventHandler(this.btnDishesEdit_Click);
            // 
            // btnDishesAdd
            // 
            this.btnDishesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDishesAdd.Location = new System.Drawing.Point(6, 364);
            this.btnDishesAdd.Name = "btnDishesAdd";
            this.btnDishesAdd.Size = new System.Drawing.Size(183, 39);
            this.btnDishesAdd.TabIndex = 7;
            this.btnDishesAdd.Text = "Add";
            this.btnDishesAdd.UseVisualStyleBackColor = true;
            this.btnDishesAdd.Click += new System.EventHandler(this.btnDishesAdd_Click);
            // 
            // lbDishesProducts
            // 
            this.lbDishesProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDishesProducts.FormattingEnabled = true;
            this.lbDishesProducts.ItemHeight = 29;
            this.lbDishesProducts.Location = new System.Drawing.Point(381, 133);
            this.lbDishesProducts.Name = "lbDishesProducts";
            this.lbDishesProducts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDishesProducts.Size = new System.Drawing.Size(275, 207);
            this.lbDishesProducts.TabIndex = 6;
            // 
            // lblDishesProducts
            // 
            this.lblDishesProducts.AutoSize = true;
            this.lblDishesProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishesProducts.Location = new System.Drawing.Point(250, 133);
            this.lblDishesProducts.Name = "lblDishesProducts";
            this.lblDishesProducts.Size = new System.Drawing.Size(108, 29);
            this.lblDishesProducts.TabIndex = 5;
            this.lblDishesProducts.Text = "Products";
            // 
            // lblDishesDishCalories
            // 
            this.lblDishesDishCalories.AutoSize = true;
            this.lblDishesDishCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishesDishCalories.Location = new System.Drawing.Point(376, 76);
            this.lblDishesDishCalories.Name = "lblDishesDishCalories";
            this.lblDishesDishCalories.Size = new System.Drawing.Size(103, 29);
            this.lblDishesDishCalories.TabIndex = 4;
            this.lblDishesDishCalories.Text = "Calories";
            // 
            // lblDishesCalories
            // 
            this.lblDishesCalories.AutoSize = true;
            this.lblDishesCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishesCalories.Location = new System.Drawing.Point(250, 76);
            this.lblDishesCalories.Name = "lblDishesCalories";
            this.lblDishesCalories.Size = new System.Drawing.Size(103, 29);
            this.lblDishesCalories.TabIndex = 3;
            this.lblDishesCalories.Text = "Calories";
            // 
            // lblDishesDishName
            // 
            this.lblDishesDishName.AutoSize = true;
            this.lblDishesDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishesDishName.Location = new System.Drawing.Point(376, 21);
            this.lblDishesDishName.Name = "lblDishesDishName";
            this.lblDishesDishName.Size = new System.Drawing.Size(78, 29);
            this.lblDishesDishName.TabIndex = 2;
            this.lblDishesDishName.Text = "Name";
            // 
            // lblDishesName
            // 
            this.lblDishesName.AutoSize = true;
            this.lblDishesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishesName.Location = new System.Drawing.Point(266, 21);
            this.lblDishesName.Name = "lblDishesName";
            this.lblDishesName.Size = new System.Drawing.Size(78, 29);
            this.lblDishesName.TabIndex = 1;
            this.lblDishesName.Text = "Name";
            // 
            // lbActWithDishes
            // 
            this.lbActWithDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbActWithDishes.FormattingEnabled = true;
            this.lbActWithDishes.ItemHeight = 29;
            this.lbActWithDishes.Location = new System.Drawing.Point(6, 6);
            this.lbActWithDishes.Name = "lbActWithDishes";
            this.lbActWithDishes.Size = new System.Drawing.Size(238, 352);
            this.lbActWithDishes.TabIndex = 0;
            this.lbActWithDishes.SelectedIndexChanged += new System.EventHandler(this.lbActWithDishes_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnProductsDelete);
            this.tabPage3.Controls.Add(this.btnProductsEdit);
            this.tabPage3.Controls.Add(this.btnProductsAdd);
            this.tabPage3.Controls.Add(this.lblProductsProductCalories);
            this.tabPage3.Controls.Add(this.lblProductsCalories);
            this.tabPage3.Controls.Add(this.lblProductsProductName);
            this.tabPage3.Controls.Add(this.lblProductsName);
            this.tabPage3.Controls.Add(this.lbActWithProducts);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(688, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnProductsDelete
            // 
            this.btnProductsDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProductsDelete.Location = new System.Drawing.Point(470, 364);
            this.btnProductsDelete.Name = "btnProductsDelete";
            this.btnProductsDelete.Size = new System.Drawing.Size(183, 39);
            this.btnProductsDelete.TabIndex = 19;
            this.btnProductsDelete.Text = "Delete";
            this.btnProductsDelete.UseVisualStyleBackColor = true;
            this.btnProductsDelete.Click += new System.EventHandler(this.btnProductsDelete_Click);
            // 
            // btnProductsEdit
            // 
            this.btnProductsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProductsEdit.Location = new System.Drawing.Point(241, 364);
            this.btnProductsEdit.Name = "btnProductsEdit";
            this.btnProductsEdit.Size = new System.Drawing.Size(183, 39);
            this.btnProductsEdit.TabIndex = 18;
            this.btnProductsEdit.Text = "Edit";
            this.btnProductsEdit.UseVisualStyleBackColor = true;
            this.btnProductsEdit.Click += new System.EventHandler(this.btnProductsEdit_Click);
            // 
            // btnProductsAdd
            // 
            this.btnProductsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProductsAdd.Location = new System.Drawing.Point(3, 364);
            this.btnProductsAdd.Name = "btnProductsAdd";
            this.btnProductsAdd.Size = new System.Drawing.Size(183, 39);
            this.btnProductsAdd.TabIndex = 17;
            this.btnProductsAdd.Text = "Add";
            this.btnProductsAdd.UseVisualStyleBackColor = true;
            this.btnProductsAdd.Click += new System.EventHandler(this.btnProductsAdd_Click);
            // 
            // lblProductsProductCalories
            // 
            this.lblProductsProductCalories.AutoSize = true;
            this.lblProductsProductCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductsProductCalories.Location = new System.Drawing.Point(424, 192);
            this.lblProductsProductCalories.Name = "lblProductsProductCalories";
            this.lblProductsProductCalories.Size = new System.Drawing.Size(103, 29);
            this.lblProductsProductCalories.TabIndex = 14;
            this.lblProductsProductCalories.Text = "Calories";
            // 
            // lblProductsCalories
            // 
            this.lblProductsCalories.AutoSize = true;
            this.lblProductsCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductsCalories.Location = new System.Drawing.Point(298, 192);
            this.lblProductsCalories.Name = "lblProductsCalories";
            this.lblProductsCalories.Size = new System.Drawing.Size(103, 29);
            this.lblProductsCalories.TabIndex = 13;
            this.lblProductsCalories.Text = "Calories";
            // 
            // lblProductsProductName
            // 
            this.lblProductsProductName.AutoSize = true;
            this.lblProductsProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductsProductName.Location = new System.Drawing.Point(424, 69);
            this.lblProductsProductName.Name = "lblProductsProductName";
            this.lblProductsProductName.Size = new System.Drawing.Size(78, 29);
            this.lblProductsProductName.TabIndex = 12;
            this.lblProductsProductName.Text = "Name";
            // 
            // lblProductsName
            // 
            this.lblProductsName.AutoSize = true;
            this.lblProductsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProductsName.Location = new System.Drawing.Point(298, 69);
            this.lblProductsName.Name = "lblProductsName";
            this.lblProductsName.Size = new System.Drawing.Size(78, 29);
            this.lblProductsName.TabIndex = 11;
            this.lblProductsName.Text = "Name";
            // 
            // lbActWithProducts
            // 
            this.lbActWithProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbActWithProducts.FormattingEnabled = true;
            this.lbActWithProducts.ItemHeight = 29;
            this.lbActWithProducts.Location = new System.Drawing.Point(3, 6);
            this.lbActWithProducts.Name = "lbActWithProducts";
            this.lbActWithProducts.Size = new System.Drawing.Size(238, 352);
            this.lbActWithProducts.TabIndex = 10;
            this.lbActWithProducts.SelectedIndexChanged += new System.EventHandler(this.lbActWithProducts_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 464);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Main";
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDishesList;
        private System.Windows.Forms.ListBox lbIngrList;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnMassCalc;
        private System.Windows.Forms.Button btnAddCalc;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDishesDelete;
        private System.Windows.Forms.Button btnDishesEdit;
        private System.Windows.Forms.Button btnDishesAdd;
        private System.Windows.Forms.ListBox lbDishesProducts;
        private System.Windows.Forms.Label lblDishesProducts;
        private System.Windows.Forms.Label lblDishesDishCalories;
        private System.Windows.Forms.Label lblDishesCalories;
        private System.Windows.Forms.Label lblDishesDishName;
        private System.Windows.Forms.Label lblDishesName;
        private System.Windows.Forms.ListBox lbActWithDishes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnProductsDelete;
        private System.Windows.Forms.Button btnProductsEdit;
        private System.Windows.Forms.Button btnProductsAdd;
        private System.Windows.Forms.Label lblProductsProductCalories;
        private System.Windows.Forms.Label lblProductsCalories;
        private System.Windows.Forms.Label lblProductsProductName;
        private System.Windows.Forms.Label lblProductsName;
        private System.Windows.Forms.ListBox lbActWithProducts;
    }
}

