
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMassCalc = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbDish = new System.Windows.Forms.ListBox();
            this.tbDishS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRedW = new System.Windows.Forms.TextBox();
            this.txtSaveW = new System.Windows.Forms.TextBox();
            this.txtIncW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMassCalc
            // 
            this.btnMassCalc.Location = new System.Drawing.Point(432, 350);
            this.btnMassCalc.Name = "btnMassCalc";
            this.btnMassCalc.Size = new System.Drawing.Size(139, 55);
            this.btnMassCalc.TabIndex = 6;
            this.btnMassCalc.Text = "Enter your data";
            this.btnMassCalc.UseVisualStyleBackColor = true;
            this.btnMassCalc.Click += new System.EventHandler(this.btnMassCalc_Click);
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
            this.tabPage1.Controls.Add(this.lbDish);
            this.tabPage1.Controls.Add(this.tbDishS);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtRedW);
            this.tabPage1.Controls.Add(this.txtSaveW);
            this.tabPage1.Controls.Add(this.txtIncW);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnMassCalc);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbDish
            // 
            this.lbDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDish.FormattingEnabled = true;
            this.lbDish.ItemHeight = 20;
            this.lbDish.Location = new System.Drawing.Point(349, 89);
            this.lbDish.Name = "lbDish";
            this.lbDish.Size = new System.Drawing.Size(251, 104);
            this.lbDish.TabIndex = 27;
            // 
            // tbDishS
            // 
            this.tbDishS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDishS.Location = new System.Drawing.Point(349, 44);
            this.tbDishS.Name = "tbDishS";
            this.tbDishS.Size = new System.Drawing.Size(251, 27);
            this.tbDishS.TabIndex = 25;
            this.tbDishS.TextChanged += new System.EventHandler(this.tbDishS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(415, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Dish Searcher";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(452, 208);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(582, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(306, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 367);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtRedW
            // 
            this.txtRedW.Location = new System.Drawing.Point(582, 314);
            this.txtRedW.Name = "txtRedW";
            this.txtRedW.ReadOnly = true;
            this.txtRedW.Size = new System.Drawing.Size(100, 22);
            this.txtRedW.TabIndex = 19;
            // 
            // txtSaveW
            // 
            this.txtSaveW.Location = new System.Drawing.Point(452, 314);
            this.txtSaveW.Name = "txtSaveW";
            this.txtSaveW.ReadOnly = true;
            this.txtSaveW.Size = new System.Drawing.Size(100, 22);
            this.txtSaveW.TabIndex = 18;
            // 
            // txtIncW
            // 
            this.txtIncW.Location = new System.Drawing.Point(306, 314);
            this.txtIncW.Name = "txtIncW";
            this.txtIncW.ReadOnly = true;
            this.txtIncW.Size = new System.Drawing.Size(100, 22);
            this.txtIncW.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Reduce Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Save Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Increase Weight";
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
            this.Text = "FitLife";
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMassCalc;
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
        public System.Windows.Forms.TextBox txtRedW;
        public System.Windows.Forms.TextBox txtSaveW;
        public System.Windows.Forms.TextBox txtIncW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbDish;
        private System.Windows.Forms.TextBox tbDishS;
        private System.Windows.Forms.Label label1;
    }
}

