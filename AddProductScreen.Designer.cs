namespace C968_001340166
{
    partial class AddProductScreen
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
            btn_addProduct_cancel = new Button();
            btn_addProduct_save = new Button();
            tbox_addProduct_min = new TextBox();
            tbox_addProduct_max = new TextBox();
            tbox_addProduct_price = new TextBox();
            tbox_addProduct_name = new TextBox();
            tbox_addProduct_inventory = new TextBox();
            tbox_addProduct_ID = new TextBox();
            lab_addProduct_min = new Label();
            lab_addProduct_max = new Label();
            lab_addProduct_price = new Label();
            lab_addProduct_inventory = new Label();
            lab_addProduct_name = new Label();
            lab_addProduct_ID = new Label();
            lab_addProduct_addProduct = new Label();
            btn_addProduct_add = new Button();
            btn_addProduct_delete = new Button();
            btn_addProduct_search = new Button();
            gridView_addProduct_addPart = new DataGridView();
            gridView_addProduct_deletePart = new DataGridView();
            tbox_addProduct_search = new TextBox();
            lab_addProduct_gridView2 = new Label();
            lab_addProduct_gridView1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridView_addProduct_addPart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView_addProduct_deletePart).BeginInit();
            SuspendLayout();
            // 
            // btn_addProduct_cancel
            // 
            btn_addProduct_cancel.Location = new Point(245, 437);
            btn_addProduct_cancel.Name = "btn_addProduct_cancel";
            btn_addProduct_cancel.Size = new Size(94, 29);
            btn_addProduct_cancel.TabIndex = 56;
            btn_addProduct_cancel.Text = "Cancel";
            btn_addProduct_cancel.UseVisualStyleBackColor = true;
            btn_addProduct_cancel.Click += btn_addProduct_cancel_Click;
            // 
            // btn_addProduct_save
            // 
            btn_addProduct_save.Location = new Point(117, 437);
            btn_addProduct_save.Name = "btn_addProduct_save";
            btn_addProduct_save.Size = new Size(94, 29);
            btn_addProduct_save.TabIndex = 55;
            btn_addProduct_save.Text = "Save";
            btn_addProduct_save.UseVisualStyleBackColor = true;
            btn_addProduct_save.Click += btn_addProduct_save_Click;
            // 
            // tbox_addProduct_min
            // 
            tbox_addProduct_min.Location = new Point(256, 357);
            tbox_addProduct_min.Name = "tbox_addProduct_min";
            tbox_addProduct_min.Size = new Size(83, 27);
            tbox_addProduct_min.TabIndex = 54;
            // 
            // tbox_addProduct_max
            // 
            tbox_addProduct_max.Location = new Point(117, 357);
            tbox_addProduct_max.Name = "tbox_addProduct_max";
            tbox_addProduct_max.Size = new Size(83, 27);
            tbox_addProduct_max.TabIndex = 52;
            // 
            // tbox_addProduct_price
            // 
            tbox_addProduct_price.Location = new Point(117, 311);
            tbox_addProduct_price.Name = "tbox_addProduct_price";
            tbox_addProduct_price.Size = new Size(222, 27);
            tbox_addProduct_price.TabIndex = 51;
            // 
            // tbox_addProduct_name
            // 
            tbox_addProduct_name.Location = new Point(117, 219);
            tbox_addProduct_name.Name = "tbox_addProduct_name";
            tbox_addProduct_name.Size = new Size(222, 27);
            tbox_addProduct_name.TabIndex = 50;
            // 
            // tbox_addProduct_inventory
            // 
            tbox_addProduct_inventory.Location = new Point(117, 267);
            tbox_addProduct_inventory.Name = "tbox_addProduct_inventory";
            tbox_addProduct_inventory.Size = new Size(222, 27);
            tbox_addProduct_inventory.TabIndex = 49;
            // 
            // tbox_addProduct_ID
            // 
            tbox_addProduct_ID.Enabled = false;
            tbox_addProduct_ID.Location = new Point(117, 173);
            tbox_addProduct_ID.Name = "tbox_addProduct_ID";
            tbox_addProduct_ID.Size = new Size(222, 27);
            tbox_addProduct_ID.TabIndex = 48;
            // 
            // lab_addProduct_min
            // 
            lab_addProduct_min.AutoSize = true;
            lab_addProduct_min.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addProduct_min.Location = new Point(207, 361);
            lab_addProduct_min.Name = "lab_addProduct_min";
            lab_addProduct_min.Size = new Size(43, 23);
            lab_addProduct_min.TabIndex = 44;
            lab_addProduct_min.Text = "Min:";
            lab_addProduct_min.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addProduct_max
            // 
            lab_addProduct_max.AutoSize = true;
            lab_addProduct_max.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addProduct_max.Location = new Point(65, 361);
            lab_addProduct_max.Name = "lab_addProduct_max";
            lab_addProduct_max.Size = new Size(46, 23);
            lab_addProduct_max.TabIndex = 43;
            lab_addProduct_max.Text = "Max:";
            lab_addProduct_max.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addProduct_price
            // 
            lab_addProduct_price.AutoSize = true;
            lab_addProduct_price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addProduct_price.Location = new Point(9, 315);
            lab_addProduct_price.Name = "lab_addProduct_price";
            lab_addProduct_price.Size = new Size(102, 23);
            lab_addProduct_price.TabIndex = 42;
            lab_addProduct_price.Text = "Price / Cost:";
            lab_addProduct_price.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addProduct_inventory
            // 
            lab_addProduct_inventory.AutoSize = true;
            lab_addProduct_inventory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addProduct_inventory.Location = new Point(25, 271);
            lab_addProduct_inventory.Name = "lab_addProduct_inventory";
            lab_addProduct_inventory.Size = new Size(86, 23);
            lab_addProduct_inventory.TabIndex = 41;
            lab_addProduct_inventory.Text = "Inventory:";
            lab_addProduct_inventory.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addProduct_name
            // 
            lab_addProduct_name.AutoSize = true;
            lab_addProduct_name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addProduct_name.Location = new Point(51, 223);
            lab_addProduct_name.Name = "lab_addProduct_name";
            lab_addProduct_name.Size = new Size(60, 23);
            lab_addProduct_name.TabIndex = 40;
            lab_addProduct_name.Text = "Name:";
            lab_addProduct_name.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addProduct_ID
            // 
            lab_addProduct_ID.AutoSize = true;
            lab_addProduct_ID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addProduct_ID.Location = new Point(80, 177);
            lab_addProduct_ID.Name = "lab_addProduct_ID";
            lab_addProduct_ID.Size = new Size(31, 23);
            lab_addProduct_ID.TabIndex = 39;
            lab_addProduct_ID.Text = "ID:";
            lab_addProduct_ID.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addProduct_addProduct
            // 
            lab_addProduct_addProduct.AutoSize = true;
            lab_addProduct_addProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addProduct_addProduct.Location = new Point(161, 97);
            lab_addProduct_addProduct.Name = "lab_addProduct_addProduct";
            lab_addProduct_addProduct.Size = new Size(134, 30);
            lab_addProduct_addProduct.TabIndex = 38;
            lab_addProduct_addProduct.Text = "Add Product";
            // 
            // btn_addProduct_add
            // 
            btn_addProduct_add.Location = new Point(781, 267);
            btn_addProduct_add.Name = "btn_addProduct_add";
            btn_addProduct_add.Size = new Size(94, 29);
            btn_addProduct_add.TabIndex = 57;
            btn_addProduct_add.Text = "Add";
            btn_addProduct_add.UseVisualStyleBackColor = true;
            btn_addProduct_add.Click += btn_addProduct_add_Click;
            // 
            // btn_addProduct_delete
            // 
            btn_addProduct_delete.Location = new Point(781, 524);
            btn_addProduct_delete.Name = "btn_addProduct_delete";
            btn_addProduct_delete.Size = new Size(94, 29);
            btn_addProduct_delete.TabIndex = 58;
            btn_addProduct_delete.Text = "Delete";
            btn_addProduct_delete.UseVisualStyleBackColor = true;
            btn_addProduct_delete.Click += btn_addProduct_delete_Click;
            // 
            // btn_addProduct_search
            // 
            btn_addProduct_search.Location = new Point(553, 41);
            btn_addProduct_search.Name = "btn_addProduct_search";
            btn_addProduct_search.Size = new Size(94, 29);
            btn_addProduct_search.TabIndex = 59;
            btn_addProduct_search.Text = "Search";
            btn_addProduct_search.UseVisualStyleBackColor = true;
            btn_addProduct_search.Click += btn_addProduct_search_Click;
            // 
            // gridView_addProduct_addPart
            // 
            gridView_addProduct_addPart.AllowUserToAddRows = false;
            gridView_addProduct_addPart.AllowUserToDeleteRows = false;
            gridView_addProduct_addPart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_addProduct_addPart.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridView_addProduct_addPart.Location = new Point(377, 73);
            gridView_addProduct_addPart.MultiSelect = false;
            gridView_addProduct_addPart.Name = "gridView_addProduct_addPart";
            gridView_addProduct_addPart.RowHeadersWidth = 51;
            gridView_addProduct_addPart.RowTemplate.Height = 29;
            gridView_addProduct_addPart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView_addProduct_addPart.Size = new Size(498, 188);
            gridView_addProduct_addPart.TabIndex = 60;
            // 
            // gridView_addProduct_deletePart
            // 
            gridView_addProduct_deletePart.AllowUserToAddRows = false;
            gridView_addProduct_deletePart.AllowUserToDeleteRows = false;
            gridView_addProduct_deletePart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_addProduct_deletePart.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridView_addProduct_deletePart.Location = new Point(377, 330);
            gridView_addProduct_deletePart.MultiSelect = false;
            gridView_addProduct_deletePart.Name = "gridView_addProduct_deletePart";
            gridView_addProduct_deletePart.RowHeadersWidth = 51;
            gridView_addProduct_deletePart.RowTemplate.Height = 29;
            gridView_addProduct_deletePart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView_addProduct_deletePart.Size = new Size(498, 188);
            gridView_addProduct_deletePart.TabIndex = 61;
            // 
            // tbox_addProduct_search
            // 
            tbox_addProduct_search.Location = new Point(653, 43);
            tbox_addProduct_search.Name = "tbox_addProduct_search";
            tbox_addProduct_search.Size = new Size(222, 27);
            tbox_addProduct_search.TabIndex = 62;
            tbox_addProduct_search.TextChanged += tbox_addProduct_search_TextChanged;
            // 
            // lab_addProduct_gridView2
            // 
            lab_addProduct_gridView2.AutoSize = true;
            lab_addProduct_gridView2.Location = new Point(377, 307);
            lab_addProduct_gridView2.Name = "lab_addProduct_gridView2";
            lab_addProduct_gridView2.Size = new Size(230, 20);
            lab_addProduct_gridView2.TabIndex = 63;
            lab_addProduct_gridView2.Text = "Parts Associated with this Product";
            // 
            // lab_addProduct_gridView1
            // 
            lab_addProduct_gridView1.AutoSize = true;
            lab_addProduct_gridView1.Location = new Point(377, 50);
            lab_addProduct_gridView1.Name = "lab_addProduct_gridView1";
            lab_addProduct_gridView1.Size = new Size(134, 20);
            lab_addProduct_gridView1.TabIndex = 64;
            lab_addProduct_gridView1.Text = "All Candidate Parts";
            // 
            // AddProductScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 563);
            Controls.Add(lab_addProduct_gridView1);
            Controls.Add(lab_addProduct_gridView2);
            Controls.Add(tbox_addProduct_search);
            Controls.Add(gridView_addProduct_deletePart);
            Controls.Add(gridView_addProduct_addPart);
            Controls.Add(btn_addProduct_search);
            Controls.Add(btn_addProduct_delete);
            Controls.Add(btn_addProduct_add);
            Controls.Add(btn_addProduct_cancel);
            Controls.Add(btn_addProduct_save);
            Controls.Add(tbox_addProduct_min);
            Controls.Add(tbox_addProduct_max);
            Controls.Add(tbox_addProduct_price);
            Controls.Add(tbox_addProduct_name);
            Controls.Add(tbox_addProduct_inventory);
            Controls.Add(tbox_addProduct_ID);
            Controls.Add(lab_addProduct_min);
            Controls.Add(lab_addProduct_max);
            Controls.Add(lab_addProduct_price);
            Controls.Add(lab_addProduct_inventory);
            Controls.Add(lab_addProduct_name);
            Controls.Add(lab_addProduct_ID);
            Controls.Add(lab_addProduct_addProduct);
            Name = "AddProductScreen";
            Text = "Product";
            Load += AddProductScreen_Load;
            ((System.ComponentModel.ISupportInitialize)gridView_addProduct_addPart).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView_addProduct_deletePart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_addProduct_cancel;
        private Button btn_addProduct_save;
        private TextBox tbox_addProduct_min;
        private TextBox tbox_addProduct_max;
        private TextBox tbox_addProduct_price;
        private TextBox tbox_addProduct_name;
        private TextBox tbox_addProduct_inventory;
        private TextBox tbox_addProduct_ID;
        private Label lab_addProduct_min;
        private Label lab_addProduct_max;
        private Label lab_addProduct_price;
        private Label lab_addProduct_inventory;
        private Label lab_addProduct_name;
        private Label lab_addProduct_ID;
        private Label lab_addProduct_addProduct;
        private Button btn_addProduct_add;
        private Button btn_addProduct_delete;
        private Button btn_addProduct_search;
        private DataGridView gridView_addProduct_addPart;
        private DataGridView gridView_addProduct_deletePart;
        private TextBox tbox_addProduct_search;
        private Label lab_addProduct_gridView2;
        private Label lab_addProduct_gridView1;
    }
}