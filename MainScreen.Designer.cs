namespace C968_001340166
{
    partial class MainScreen
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
            tbox_mainScreen_productSearch = new TextBox();
            tbox_mainScreen_partSearch = new TextBox();
            btn_mainScreen_exit = new Button();
            btn_mainScreen_productDelete = new Button();
            btn_mainScreen_productModify = new Button();
            btn_mainScreen_productAdd = new Button();
            btn_mainScreen_productSearch = new Button();
            btn_mainScreen_partDelete = new Button();
            btn_mainScreen_partModify = new Button();
            btn_mainScreen_partAdd = new Button();
            btn_mainScreen_partSearch = new Button();
            lab_mainScreen_productsGrid = new Label();
            lab_mainScreen_partsGrid = new Label();
            gridView_mainScreen_products = new DataGridView();
            gridView_mainScreen_parts = new DataGridView();
            lab_mainScreen_Title = new Label();
            ((System.ComponentModel.ISupportInitialize)gridView_mainScreen_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView_mainScreen_parts).BeginInit();
            SuspendLayout();
            // 
            // tbox_mainScreen_productSearch
            // 
            tbox_mainScreen_productSearch.Location = new Point(992, 65);
            tbox_mainScreen_productSearch.Name = "tbox_mainScreen_productSearch";
            tbox_mainScreen_productSearch.Size = new Size(125, 27);
            tbox_mainScreen_productSearch.TabIndex = 31;
            tbox_mainScreen_productSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // tbox_mainScreen_partSearch
            // 
            tbox_mainScreen_partSearch.Location = new Point(431, 63);
            tbox_mainScreen_partSearch.Name = "tbox_mainScreen_partSearch";
            tbox_mainScreen_partSearch.Size = new Size(125, 27);
            tbox_mainScreen_partSearch.TabIndex = 30;
            tbox_mainScreen_partSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_mainScreen_exit
            // 
            btn_mainScreen_exit.Location = new Point(15, 10);
            btn_mainScreen_exit.Name = "btn_mainScreen_exit";
            btn_mainScreen_exit.Size = new Size(94, 29);
            btn_mainScreen_exit.TabIndex = 29;
            btn_mainScreen_exit.Text = "Exit";
            btn_mainScreen_exit.UseVisualStyleBackColor = true;
            btn_mainScreen_exit.Click += btn_mainScreen_exit_Click;
            // 
            // btn_mainScreen_productDelete
            // 
            btn_mainScreen_productDelete.Location = new Point(900, 453);
            btn_mainScreen_productDelete.Name = "btn_mainScreen_productDelete";
            btn_mainScreen_productDelete.Size = new Size(94, 29);
            btn_mainScreen_productDelete.TabIndex = 28;
            btn_mainScreen_productDelete.Text = "Delete";
            btn_mainScreen_productDelete.UseVisualStyleBackColor = true;
            btn_mainScreen_productDelete.Click += btn_mainScreen_productDelete_Click;
            // 
            // btn_mainScreen_productModify
            // 
            btn_mainScreen_productModify.Location = new Point(800, 453);
            btn_mainScreen_productModify.Name = "btn_mainScreen_productModify";
            btn_mainScreen_productModify.Size = new Size(94, 29);
            btn_mainScreen_productModify.TabIndex = 27;
            btn_mainScreen_productModify.Text = "Modify";
            btn_mainScreen_productModify.UseVisualStyleBackColor = true;
            btn_mainScreen_productModify.Click += btn_mainScreen_productModify_Click;
            // 
            // btn_mainScreen_productAdd
            // 
            btn_mainScreen_productAdd.Location = new Point(700, 453);
            btn_mainScreen_productAdd.Name = "btn_mainScreen_productAdd";
            btn_mainScreen_productAdd.Size = new Size(94, 29);
            btn_mainScreen_productAdd.TabIndex = 26;
            btn_mainScreen_productAdd.Text = "Add";
            btn_mainScreen_productAdd.UseVisualStyleBackColor = true;
            btn_mainScreen_productAdd.Click += btn_mainScreen_productAdd_Click;
            // 
            // btn_mainScreen_productSearch
            // 
            btn_mainScreen_productSearch.Location = new Point(892, 63);
            btn_mainScreen_productSearch.Name = "btn_mainScreen_productSearch";
            btn_mainScreen_productSearch.Size = new Size(94, 29);
            btn_mainScreen_productSearch.TabIndex = 25;
            btn_mainScreen_productSearch.Text = "Search";
            btn_mainScreen_productSearch.UseVisualStyleBackColor = true;
            btn_mainScreen_productSearch.Click += btn_mainScreen_productSearch_Click;
            // 
            // btn_mainScreen_partDelete
            // 
            btn_mainScreen_partDelete.Location = new Point(337, 452);
            btn_mainScreen_partDelete.Name = "btn_mainScreen_partDelete";
            btn_mainScreen_partDelete.Size = new Size(94, 29);
            btn_mainScreen_partDelete.TabIndex = 24;
            btn_mainScreen_partDelete.Text = "Delete";
            btn_mainScreen_partDelete.UseVisualStyleBackColor = true;
            btn_mainScreen_partDelete.Click += btn_mainScreen_partDelete_Click;
            // 
            // btn_mainScreen_partModify
            // 
            btn_mainScreen_partModify.Location = new Point(237, 452);
            btn_mainScreen_partModify.Name = "btn_mainScreen_partModify";
            btn_mainScreen_partModify.Size = new Size(94, 29);
            btn_mainScreen_partModify.TabIndex = 23;
            btn_mainScreen_partModify.Text = "Modify";
            btn_mainScreen_partModify.UseVisualStyleBackColor = true;
            btn_mainScreen_partModify.Click += btn_mainScreen_partModify_Click;
            // 
            // btn_mainScreen_partAdd
            // 
            btn_mainScreen_partAdd.Location = new Point(137, 452);
            btn_mainScreen_partAdd.Name = "btn_mainScreen_partAdd";
            btn_mainScreen_partAdd.Size = new Size(94, 29);
            btn_mainScreen_partAdd.TabIndex = 22;
            btn_mainScreen_partAdd.Text = "Add";
            btn_mainScreen_partAdd.UseVisualStyleBackColor = true;
            btn_mainScreen_partAdd.Click += btn_mainScreen_partAdd_Click;
            // 
            // btn_mainScreen_partSearch
            // 
            btn_mainScreen_partSearch.Location = new Point(331, 61);
            btn_mainScreen_partSearch.Name = "btn_mainScreen_partSearch";
            btn_mainScreen_partSearch.Size = new Size(94, 29);
            btn_mainScreen_partSearch.TabIndex = 21;
            btn_mainScreen_partSearch.Text = "Search";
            btn_mainScreen_partSearch.UseVisualStyleBackColor = true;
            btn_mainScreen_partSearch.Click += btn_mainScreen_partSearch_Click;
            // 
            // lab_mainScreen_productsGrid
            // 
            lab_mainScreen_productsGrid.AutoSize = true;
            lab_mainScreen_productsGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lab_mainScreen_productsGrid.Location = new Point(579, 72);
            lab_mainScreen_productsGrid.Name = "lab_mainScreen_productsGrid";
            lab_mainScreen_productsGrid.Size = new Size(86, 25);
            lab_mainScreen_productsGrid.TabIndex = 20;
            lab_mainScreen_productsGrid.Text = "Products";
            // 
            // lab_mainScreen_partsGrid
            // 
            lab_mainScreen_partsGrid.AutoSize = true;
            lab_mainScreen_partsGrid.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lab_mainScreen_partsGrid.Location = new Point(15, 72);
            lab_mainScreen_partsGrid.Name = "lab_mainScreen_partsGrid";
            lab_mainScreen_partsGrid.Size = new Size(53, 25);
            lab_mainScreen_partsGrid.TabIndex = 19;
            lab_mainScreen_partsGrid.Text = "Parts";
            // 
            // gridView_mainScreen_products
            // 
            gridView_mainScreen_products.AllowUserToAddRows = false;
            gridView_mainScreen_products.AllowUserToDeleteRows = false;
            gridView_mainScreen_products.AllowUserToOrderColumns = true;
            gridView_mainScreen_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_mainScreen_products.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridView_mainScreen_products.Location = new Point(579, 100);
            gridView_mainScreen_products.MultiSelect = false;
            gridView_mainScreen_products.Name = "gridView_mainScreen_products";
            gridView_mainScreen_products.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            gridView_mainScreen_products.RowTemplate.Height = 29;
            gridView_mainScreen_products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView_mainScreen_products.Size = new Size(537, 347);
            gridView_mainScreen_products.TabIndex = 18;
            // 
            // gridView_mainScreen_parts
            // 
            gridView_mainScreen_parts.AllowUserToAddRows = false;
            gridView_mainScreen_parts.AllowUserToDeleteRows = false;
            gridView_mainScreen_parts.AllowUserToOrderColumns = true;
            gridView_mainScreen_parts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_mainScreen_parts.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridView_mainScreen_parts.Location = new Point(12, 100);
            gridView_mainScreen_parts.MultiSelect = false;
            gridView_mainScreen_parts.Name = "gridView_mainScreen_parts";
            gridView_mainScreen_parts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridView_mainScreen_parts.RowTemplate.Height = 29;
            gridView_mainScreen_parts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView_mainScreen_parts.Size = new Size(544, 347);
            gridView_mainScreen_parts.TabIndex = 17;
            // 
            // lab_mainScreen_Title
            // 
            lab_mainScreen_Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lab_mainScreen_Title.AutoSize = true;
            lab_mainScreen_Title.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lab_mainScreen_Title.Location = new Point(392, 10);
            lab_mainScreen_Title.Name = "lab_mainScreen_Title";
            lab_mainScreen_Title.Size = new Size(348, 32);
            lab_mainScreen_Title.TabIndex = 16;
            lab_mainScreen_Title.Text = "Inventory Management System";
            lab_mainScreen_Title.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 493);
            Controls.Add(tbox_mainScreen_productSearch);
            Controls.Add(tbox_mainScreen_partSearch);
            Controls.Add(btn_mainScreen_exit);
            Controls.Add(btn_mainScreen_productDelete);
            Controls.Add(btn_mainScreen_productModify);
            Controls.Add(btn_mainScreen_productAdd);
            Controls.Add(btn_mainScreen_productSearch);
            Controls.Add(btn_mainScreen_partDelete);
            Controls.Add(btn_mainScreen_partModify);
            Controls.Add(btn_mainScreen_partAdd);
            Controls.Add(btn_mainScreen_partSearch);
            Controls.Add(lab_mainScreen_productsGrid);
            Controls.Add(lab_mainScreen_partsGrid);
            Controls.Add(gridView_mainScreen_products);
            Controls.Add(gridView_mainScreen_parts);
            Controls.Add(lab_mainScreen_Title);
            Name = "MainScreen";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)gridView_mainScreen_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView_mainScreen_parts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbox_mainScreen_productSearch;
        private TextBox tbox_mainScreen_partSearch;
        private Button btn_mainScreen_exit;
        private Button btn_mainScreen_productDelete;
        private Button btn_mainScreen_productModify;
        private Button btn_mainScreen_productAdd;
        private Button btn_mainScreen_productSearch;
        private Button btn_mainScreen_partDelete;
        private Button btn_mainScreen_partModify;
        private Button btn_mainScreen_partAdd;
        private Button btn_mainScreen_partSearch;
        private Label lab_mainScreen_productsGrid;
        private Label lab_mainScreen_partsGrid;
        private Label lab_mainScreen_Title;
        public static DataGridView gridView_mainScreen_products;
        public static DataGridView gridView_mainScreen_parts;
    }
}