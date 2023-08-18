namespace C968_001340166
{
    partial class ModifyProductScreen
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
            lab_modProduct_gridView1 = new Label();
            lab_modProduct_gridView2 = new Label();
            tbox_modProduct_search = new TextBox();
            gridView_modProduct_deletePart = new DataGridView();
            gridView_modProduct_addPart = new DataGridView();
            btn_modProduct_search = new Button();
            btn_modProduct_delete = new Button();
            btn_modProduct_add = new Button();
            btn_modProduct_cancel = new Button();
            btn_modProduct_save = new Button();
            tbox_modProduct_min = new TextBox();
            tbox_modProduct_max = new TextBox();
            tbox_modProduct_price = new TextBox();
            tbox_modProduct_name = new TextBox();
            tbox_modProduct_inventory = new TextBox();
            tbox_modProduct_ID = new TextBox();
            lab_modProduct_min = new Label();
            lab_modProduct_max = new Label();
            lab_modProduct_price = new Label();
            lab_modProduct_inventory = new Label();
            lab_modProduct_name = new Label();
            lab_modProduct_ID = new Label();
            lab_modProduct_addProduct = new Label();
            ((System.ComponentModel.ISupportInitialize)gridView_modProduct_deletePart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView_modProduct_addPart).BeginInit();
            SuspendLayout();
            // 
            // lab_modProduct_gridView1
            // 
            lab_modProduct_gridView1.AutoSize = true;
            lab_modProduct_gridView1.Location = new Point(377, 50);
            lab_modProduct_gridView1.Name = "lab_modProduct_gridView1";
            lab_modProduct_gridView1.Size = new Size(134, 20);
            lab_modProduct_gridView1.TabIndex = 87;
            lab_modProduct_gridView1.Text = "All Candidate Parts";
            // 
            // lab_modProduct_gridView2
            // 
            lab_modProduct_gridView2.AutoSize = true;
            lab_modProduct_gridView2.Location = new Point(377, 307);
            lab_modProduct_gridView2.Name = "lab_modProduct_gridView2";
            lab_modProduct_gridView2.Size = new Size(230, 20);
            lab_modProduct_gridView2.TabIndex = 86;
            lab_modProduct_gridView2.Text = "Parts Associated with this Product";
            // 
            // tbox_modProduct_search
            // 
            tbox_modProduct_search.Location = new Point(653, 43);
            tbox_modProduct_search.Name = "tbox_modProduct_search";
            tbox_modProduct_search.Size = new Size(222, 27);
            tbox_modProduct_search.TabIndex = 85;
            // 
            // gridView_modProduct_deletePart
            // 
            gridView_modProduct_deletePart.AllowUserToAddRows = false;
            gridView_modProduct_deletePart.AllowUserToDeleteRows = false;
            gridView_modProduct_deletePart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_modProduct_deletePart.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridView_modProduct_deletePart.Location = new Point(377, 330);
            gridView_modProduct_deletePart.MultiSelect = false;
            gridView_modProduct_deletePart.Name = "gridView_modProduct_deletePart";
            gridView_modProduct_deletePart.RowHeadersWidth = 51;
            gridView_modProduct_deletePart.RowTemplate.Height = 29;
            gridView_modProduct_deletePart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView_modProduct_deletePart.Size = new Size(498, 188);
            gridView_modProduct_deletePart.TabIndex = 84;
            // 
            // gridView_modProduct_addPart
            // 
            gridView_modProduct_addPart.AllowUserToAddRows = false;
            gridView_modProduct_addPart.AllowUserToDeleteRows = false;
            gridView_modProduct_addPart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_modProduct_addPart.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridView_modProduct_addPart.Location = new Point(377, 73);
            gridView_modProduct_addPart.MultiSelect = false;
            gridView_modProduct_addPart.Name = "gridView_modProduct_addPart";
            gridView_modProduct_addPart.RowHeadersWidth = 51;
            gridView_modProduct_addPart.RowTemplate.Height = 29;
            gridView_modProduct_addPart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView_modProduct_addPart.Size = new Size(498, 188);
            gridView_modProduct_addPart.TabIndex = 83;
            // 
            // btn_modProduct_search
            // 
            btn_modProduct_search.Location = new Point(553, 41);
            btn_modProduct_search.Name = "btn_modProduct_search";
            btn_modProduct_search.Size = new Size(94, 29);
            btn_modProduct_search.TabIndex = 82;
            btn_modProduct_search.Text = "Search";
            btn_modProduct_search.UseVisualStyleBackColor = true;
            btn_modProduct_search.Click += btn_modProduct_search_Click;
            // 
            // btn_modProduct_delete
            // 
            btn_modProduct_delete.Location = new Point(781, 524);
            btn_modProduct_delete.Name = "btn_modProduct_delete";
            btn_modProduct_delete.Size = new Size(94, 29);
            btn_modProduct_delete.TabIndex = 81;
            btn_modProduct_delete.Text = "Delete";
            btn_modProduct_delete.UseVisualStyleBackColor = true;
            btn_modProduct_delete.Click += btn_modProduct_delete_Click;
            // 
            // btn_modProduct_add
            // 
            btn_modProduct_add.Location = new Point(781, 265);
            btn_modProduct_add.Name = "btn_modProduct_add";
            btn_modProduct_add.Size = new Size(94, 29);
            btn_modProduct_add.TabIndex = 80;
            btn_modProduct_add.Text = "Add";
            btn_modProduct_add.UseVisualStyleBackColor = true;
            btn_modProduct_add.Click += btn_modProduct_add_Click;
            // 
            // btn_modProduct_cancel
            // 
            btn_modProduct_cancel.Location = new Point(245, 437);
            btn_modProduct_cancel.Name = "btn_modProduct_cancel";
            btn_modProduct_cancel.Size = new Size(94, 29);
            btn_modProduct_cancel.TabIndex = 79;
            btn_modProduct_cancel.Text = "Cancel";
            btn_modProduct_cancel.UseVisualStyleBackColor = true;
            btn_modProduct_cancel.Click += btn_modProduct_cancel_Click;
            // 
            // btn_modProduct_save
            // 
            btn_modProduct_save.Location = new Point(117, 437);
            btn_modProduct_save.Name = "btn_modProduct_save";
            btn_modProduct_save.Size = new Size(94, 29);
            btn_modProduct_save.TabIndex = 78;
            btn_modProduct_save.Text = "Save";
            btn_modProduct_save.UseVisualStyleBackColor = true;
            btn_modProduct_save.Click += btn_modProduct_save_Click;
            // 
            // tbox_modProduct_min
            // 
            tbox_modProduct_min.Location = new Point(256, 357);
            tbox_modProduct_min.Name = "tbox_modProduct_min";
            tbox_modProduct_min.Size = new Size(83, 27);
            tbox_modProduct_min.TabIndex = 77;
            // 
            // tbox_modProduct_max
            // 
            tbox_modProduct_max.Location = new Point(117, 357);
            tbox_modProduct_max.Name = "tbox_modProduct_max";
            tbox_modProduct_max.Size = new Size(83, 27);
            tbox_modProduct_max.TabIndex = 76;
            // 
            // tbox_modProduct_price
            // 
            tbox_modProduct_price.Location = new Point(117, 311);
            tbox_modProduct_price.Name = "tbox_modProduct_price";
            tbox_modProduct_price.Size = new Size(222, 27);
            tbox_modProduct_price.TabIndex = 75;
            // 
            // tbox_modProduct_name
            // 
            tbox_modProduct_name.Location = new Point(117, 219);
            tbox_modProduct_name.Name = "tbox_modProduct_name";
            tbox_modProduct_name.Size = new Size(222, 27);
            tbox_modProduct_name.TabIndex = 74;
            // 
            // tbox_modProduct_inventory
            // 
            tbox_modProduct_inventory.Location = new Point(117, 267);
            tbox_modProduct_inventory.Name = "tbox_modProduct_inventory";
            tbox_modProduct_inventory.Size = new Size(222, 27);
            tbox_modProduct_inventory.TabIndex = 73;
            // 
            // tbox_modProduct_ID
            // 
            tbox_modProduct_ID.Enabled = false;
            tbox_modProduct_ID.Location = new Point(117, 173);
            tbox_modProduct_ID.Name = "tbox_modProduct_ID";
            tbox_modProduct_ID.Size = new Size(222, 27);
            tbox_modProduct_ID.TabIndex = 72;
            // 
            // lab_modProduct_min
            // 
            lab_modProduct_min.AutoSize = true;
            lab_modProduct_min.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modProduct_min.Location = new Point(207, 361);
            lab_modProduct_min.Name = "lab_modProduct_min";
            lab_modProduct_min.Size = new Size(43, 23);
            lab_modProduct_min.TabIndex = 71;
            lab_modProduct_min.Text = "Min:";
            lab_modProduct_min.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modProduct_max
            // 
            lab_modProduct_max.AutoSize = true;
            lab_modProduct_max.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modProduct_max.Location = new Point(65, 361);
            lab_modProduct_max.Name = "lab_modProduct_max";
            lab_modProduct_max.Size = new Size(46, 23);
            lab_modProduct_max.TabIndex = 70;
            lab_modProduct_max.Text = "Max:";
            lab_modProduct_max.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modProduct_price
            // 
            lab_modProduct_price.AutoSize = true;
            lab_modProduct_price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modProduct_price.Location = new Point(9, 315);
            lab_modProduct_price.Name = "lab_modProduct_price";
            lab_modProduct_price.Size = new Size(102, 23);
            lab_modProduct_price.TabIndex = 69;
            lab_modProduct_price.Text = "Price / Cost:";
            lab_modProduct_price.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modProduct_inventory
            // 
            lab_modProduct_inventory.AutoSize = true;
            lab_modProduct_inventory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modProduct_inventory.Location = new Point(25, 271);
            lab_modProduct_inventory.Name = "lab_modProduct_inventory";
            lab_modProduct_inventory.Size = new Size(86, 23);
            lab_modProduct_inventory.TabIndex = 68;
            lab_modProduct_inventory.Text = "Inventory:";
            lab_modProduct_inventory.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modProduct_name
            // 
            lab_modProduct_name.AutoSize = true;
            lab_modProduct_name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modProduct_name.Location = new Point(51, 223);
            lab_modProduct_name.Name = "lab_modProduct_name";
            lab_modProduct_name.Size = new Size(60, 23);
            lab_modProduct_name.TabIndex = 67;
            lab_modProduct_name.Text = "Name:";
            lab_modProduct_name.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modProduct_ID
            // 
            lab_modProduct_ID.AutoSize = true;
            lab_modProduct_ID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modProduct_ID.Location = new Point(80, 177);
            lab_modProduct_ID.Name = "lab_modProduct_ID";
            lab_modProduct_ID.Size = new Size(31, 23);
            lab_modProduct_ID.TabIndex = 66;
            lab_modProduct_ID.Text = "ID:";
            lab_modProduct_ID.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modProduct_addProduct
            // 
            lab_modProduct_addProduct.AutoSize = true;
            lab_modProduct_addProduct.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modProduct_addProduct.Location = new Point(147, 97);
            lab_modProduct_addProduct.Name = "lab_modProduct_addProduct";
            lab_modProduct_addProduct.Size = new Size(163, 30);
            lab_modProduct_addProduct.TabIndex = 65;
            lab_modProduct_addProduct.Text = "Modify Product";
            // 
            // ModifyProductScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 563);
            Controls.Add(lab_modProduct_gridView1);
            Controls.Add(lab_modProduct_gridView2);
            Controls.Add(tbox_modProduct_search);
            Controls.Add(gridView_modProduct_deletePart);
            Controls.Add(gridView_modProduct_addPart);
            Controls.Add(btn_modProduct_search);
            Controls.Add(btn_modProduct_delete);
            Controls.Add(btn_modProduct_add);
            Controls.Add(btn_modProduct_cancel);
            Controls.Add(btn_modProduct_save);
            Controls.Add(tbox_modProduct_min);
            Controls.Add(tbox_modProduct_max);
            Controls.Add(tbox_modProduct_price);
            Controls.Add(tbox_modProduct_name);
            Controls.Add(tbox_modProduct_inventory);
            Controls.Add(tbox_modProduct_ID);
            Controls.Add(lab_modProduct_min);
            Controls.Add(lab_modProduct_max);
            Controls.Add(lab_modProduct_price);
            Controls.Add(lab_modProduct_inventory);
            Controls.Add(lab_modProduct_name);
            Controls.Add(lab_modProduct_ID);
            Controls.Add(lab_modProduct_addProduct);
            Name = "ModifyProductScreen";
            Text = "Product";
            Load += ModifyProductScreen_Load;
            ((System.ComponentModel.ISupportInitialize)gridView_modProduct_deletePart).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView_modProduct_addPart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_modProduct_gridView1;
        private Label lab_modProduct_gridView2;
        private TextBox tbox_modProduct_search;
        private DataGridView gridView_modProduct_deletePart;
        private DataGridView gridView_modProduct_addPart;
        private Button btn_modProduct_search;
        private Button btn_modProduct_delete;
        private Button btn_modProduct_add;
        private Button btn_modProduct_cancel;
        private Button btn_modProduct_save;
        private TextBox tbox_modProduct_min;
        private TextBox tbox_modProduct_max;
        private TextBox tbox_modProduct_price;
        private TextBox tbox_modProduct_name;
        private TextBox tbox_modProduct_inventory;
        private TextBox tbox_modProduct_ID;
        private Label lab_modProduct_min;
        private Label lab_modProduct_max;
        private Label lab_modProduct_price;
        private Label lab_modProduct_inventory;
        private Label lab_modProduct_name;
        private Label lab_modProduct_ID;
        private Label lab_modProduct_addProduct;
    }
}