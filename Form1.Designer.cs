namespace DemoAppWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxProductId = new TextBox();
            textBoxItemName = new TextBox();
            textBoxDesign = new TextBox();
            labelProductId = new Label();
            labelItemName = new Label();
            labelDesign = new Label();
            labelColor = new Label();
            comboBoxColor = new ComboBox();
            btnAddNew = new Button();
            btnEditProduct = new Button();
            textBox1 = new TextBox();
            labelSearch = new Label();
            btnDelete = new Button();
            textBoxSearch = new TextBox();
            labelLogo = new Label();
            labelStock = new Label();
            btnClear = new Button();
            btnExit = new Label();
            loader = new Label();
            textBoxStock = new TextBox();
            textBoxPrice = new TextBox();
            labelPrice = new Label();
            dataGridViewMain = new DataGridView();
            btnSearch = new Button();
            btnLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            SuspendLayout();
            // 
            // textBoxProductId
            // 
            textBoxProductId.Location = new Point(655, 157);
            textBoxProductId.Name = "textBoxProductId";
            textBoxProductId.Size = new Size(107, 23);
            textBoxProductId.TabIndex = 0;
            // 
            // textBoxItemName
            // 
            textBoxItemName.Location = new Point(655, 198);
            textBoxItemName.Name = "textBoxItemName";
            textBoxItemName.Size = new Size(375, 23);
            textBoxItemName.TabIndex = 0;
            // 
            // textBoxDesign
            // 
            textBoxDesign.Location = new Point(655, 241);
            textBoxDesign.Name = "textBoxDesign";
            textBoxDesign.Size = new Size(375, 23);
            textBoxDesign.TabIndex = 0;
            // 
            // labelProductId
            // 
            labelProductId.AutoSize = true;
            labelProductId.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelProductId.ForeColor = Color.White;
            labelProductId.Location = new Point(514, 157);
            labelProductId.Name = "labelProductId";
            labelProductId.Size = new Size(109, 24);
            labelProductId.TabIndex = 1;
            labelProductId.Text = "Product ID";
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelItemName.ForeColor = Color.White;
            labelItemName.Location = new Point(514, 194);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(113, 24);
            labelItemName.TabIndex = 1;
            labelItemName.Text = "Item Name";
            // 
            // labelDesign
            // 
            labelDesign.AutoSize = true;
            labelDesign.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelDesign.ForeColor = Color.White;
            labelDesign.Location = new Point(518, 240);
            labelDesign.Name = "labelDesign";
            labelDesign.Size = new Size(74, 24);
            labelDesign.TabIndex = 1;
            labelDesign.Text = "Design";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelColor.ForeColor = Color.White;
            labelColor.Location = new Point(811, 157);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(60, 24);
            labelColor.TabIndex = 1;
            labelColor.Text = "Color";
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Items.AddRange(new object[] { "White", "Yellow", "Orange", "Red", "Blue", "Green", "Brown", "Grey", "Black" });
            comboBoxColor.Location = new Point(887, 156);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(143, 23);
            comboBoxColor.TabIndex = 2;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.FromArgb(31, 177, 0);
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(880, 90);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(150, 29);
            btnAddNew.TabIndex = 3;
            btnAddNew.Text = "➕ Add new";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = Color.FromArgb(134, 142, 150);
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(880, 344);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(150, 32);
            btnEditProduct.TabIndex = 3;
            btnEditProduct.Text = "🖊 Edit product";
            btnEditProduct.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(-2, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1057, 64);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.ForeColor = Color.White;
            labelSearch.Location = new Point(38, 90);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(73, 24);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Search";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(880, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "✖ Delete Product";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(117, 90);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Enter Id or product name..";
            textBoxSearch.Size = new Size(374, 29);
            textBoxSearch.TabIndex = 0;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.BackColor = Color.White;
            labelLogo.Font = new Font("Microsoft New Tai Lue", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelLogo.ForeColor = Color.Black;
            labelLogo.Location = new Point(38, 9);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(234, 47);
            labelLogo.TabIndex = 1;
            labelLogo.Text = "Products DB ";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(518, 283);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(61, 24);
            labelStock.TabIndex = 1;
            labelStock.Text = "Stock";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(134, 142, 150);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(880, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 32);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.White;
            btnExit.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(965, 23);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 21);
            btnExit.TabIndex = 1;
            btnExit.Text = "exit ❌";
            // 
            // loader
            // 
            loader.AutoSize = true;
            loader.BackColor = Color.White;
            loader.Font = new Font("Microsoft New Tai Lue", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            loader.ForeColor = Color.FromArgb(255, 193, 7);
            loader.Location = new Point(278, 11);
            loader.Name = "loader";
            loader.Size = new Size(52, 38);
            loader.TabIndex = 1;
            loader.Text = "⚡";
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(655, 284);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(107, 23);
            textBoxStock.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(887, 284);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "€ ";
            textBoxPrice.Size = new Size(143, 23);
            textBoxPrice.TabIndex = 0;
            textBoxPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.ForeColor = Color.White;
            labelPrice.Location = new Point(815, 283);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(56, 24);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "Price";
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.AllowUserToAddRows = false;
            dataGridViewMain.AllowUserToDeleteRows = false;
            dataGridViewMain.BackgroundColor = Color.White;
            dataGridViewMain.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(38, 146);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowTemplate.Height = 25;
            dataGridViewMain.Size = new Size(453, 278);
            dataGridViewMain.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(134, 142, 150);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(514, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = " Search 🔎";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.Green;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadData.ForeColor = Color.White;
            btnLoadData.Location = new Point(38, 490);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(150, 32);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1053, 547);
            Controls.Add(dataGridViewMain);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnLoadData);
            Controls.Add(btnSearch);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddNew);
            Controls.Add(comboBoxColor);
            Controls.Add(labelColor);
            Controls.Add(labelPrice);
            Controls.Add(labelStock);
            Controls.Add(labelDesign);
            Controls.Add(labelItemName);
            Controls.Add(loader);
            Controls.Add(btnExit);
            Controls.Add(labelLogo);
            Controls.Add(labelSearch);
            Controls.Add(labelProductId);
            Controls.Add(textBoxDesign);
            Controls.Add(textBoxItemName);
            Controls.Add(textBox1);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxProductId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductId;
        private TextBox textBoxItemName;
        private TextBox textBoxDesign;
        private Label labelProductId;
        private Label labelItemName;
        private Label labelDesign;
        private Label labelColor;
        private ComboBox comboBoxColor;
        private Button btnAddNew;
        private Button btnEditProduct;
        private TextBox textBox1;
        private Label labelSearch;
        private Button btnDelete;
        private TextBox textBoxSearch;
        private Label labelLogo;
        private Label labelStock;
        private Button btnClear;
        private Label btnExit;
        private Label loader;
        private TextBox textBoxStock;
        private TextBox textBoxPrice;
        private Label labelPrice;
        protected DataGridView dataGridViewMain;
        private Button btnSearch;
        private Button btnLoadData;
    }
}