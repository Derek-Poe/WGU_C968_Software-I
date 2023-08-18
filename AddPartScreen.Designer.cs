namespace C968_001340166
{
    partial class AddPartScreen
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
            btn_addPart_cancel = new Button();
            btn_addPart_save = new Button();
            tbox_addPart_min = new TextBox();
            tbox_addPart_machine = new TextBox();
            tbox_addPart_max = new TextBox();
            tbox_addPart_price = new TextBox();
            tbox_addPart_name = new TextBox();
            tbox_addPart_inventory = new TextBox();
            tbox_addPart_ID = new TextBox();
            radio_addPart_outsourced = new RadioButton();
            radio_addPart_inHouse = new RadioButton();
            lab_addPart_machine = new Label();
            lab_addPart_min = new Label();
            lab_addPart_max = new Label();
            lab_addPart_price = new Label();
            lab_addPart_inventory = new Label();
            lab_addPart_name = new Label();
            lab_addPart_ID = new Label();
            lab_addPart_addPart = new Label();
            SuspendLayout();
            // 
            // btn_addPart_cancel
            // 
            btn_addPart_cancel.Location = new Point(247, 274);
            btn_addPart_cancel.Name = "btn_addPart_cancel";
            btn_addPart_cancel.Size = new Size(94, 29);
            btn_addPart_cancel.TabIndex = 37;
            btn_addPart_cancel.Text = "Cancel";
            btn_addPart_cancel.UseVisualStyleBackColor = true;
            btn_addPart_cancel.Click += btn_addPart_cancel_Click;
            // 
            // btn_addPart_save
            // 
            btn_addPart_save.Location = new Point(119, 274);
            btn_addPart_save.Name = "btn_addPart_save";
            btn_addPart_save.Size = new Size(94, 29);
            btn_addPart_save.TabIndex = 36;
            btn_addPart_save.Text = "Save";
            btn_addPart_save.UseVisualStyleBackColor = true;
            btn_addPart_save.Click += btn_addPart_save_Click;
            // 
            // tbox_addPart_min
            // 
            tbox_addPart_min.Location = new Point(258, 194);
            tbox_addPart_min.Name = "tbox_addPart_min";
            tbox_addPart_min.Size = new Size(83, 27);
            tbox_addPart_min.TabIndex = 35;
            // 
            // tbox_addPart_machine
            // 
            tbox_addPart_machine.Location = new Point(119, 231);
            tbox_addPart_machine.Name = "tbox_addPart_machine";
            tbox_addPart_machine.Size = new Size(222, 27);
            tbox_addPart_machine.TabIndex = 34;
            // 
            // tbox_addPart_max
            // 
            tbox_addPart_max.Location = new Point(119, 194);
            tbox_addPart_max.Name = "tbox_addPart_max";
            tbox_addPart_max.Size = new Size(83, 27);
            tbox_addPart_max.TabIndex = 33;
            // 
            // tbox_addPart_price
            // 
            tbox_addPart_price.Location = new Point(119, 158);
            tbox_addPart_price.Name = "tbox_addPart_price";
            tbox_addPart_price.Size = new Size(222, 27);
            tbox_addPart_price.TabIndex = 32;
            // 
            // tbox_addPart_name
            // 
            tbox_addPart_name.Location = new Point(119, 93);
            tbox_addPart_name.Name = "tbox_addPart_name";
            tbox_addPart_name.Size = new Size(222, 27);
            tbox_addPart_name.TabIndex = 31;
            // 
            // tbox_addPart_inventory
            // 
            tbox_addPart_inventory.Location = new Point(119, 126);
            tbox_addPart_inventory.Name = "tbox_addPart_inventory";
            tbox_addPart_inventory.Size = new Size(222, 27);
            tbox_addPart_inventory.TabIndex = 30;
            // 
            // tbox_addPart_ID
            // 
            tbox_addPart_ID.Enabled = false;
            tbox_addPart_ID.Location = new Point(119, 60);
            tbox_addPart_ID.Name = "tbox_addPart_ID";
            tbox_addPart_ID.Size = new Size(222, 27);
            tbox_addPart_ID.TabIndex = 29;
            // 
            // radio_addPart_outsourced
            // 
            radio_addPart_outsourced.AutoSize = true;
            radio_addPart_outsourced.Location = new Point(235, 29);
            radio_addPart_outsourced.Name = "radio_addPart_outsourced";
            radio_addPart_outsourced.Size = new Size(106, 24);
            radio_addPart_outsourced.TabIndex = 28;
            radio_addPart_outsourced.TabStop = true;
            radio_addPart_outsourced.Text = "Outsourced";
            radio_addPart_outsourced.UseVisualStyleBackColor = true;
            // 
            // radio_addPart_inHouse
            // 
            radio_addPart_inHouse.AutoSize = true;
            radio_addPart_inHouse.Location = new Point(130, 30);
            radio_addPart_inHouse.Name = "radio_addPart_inHouse";
            radio_addPart_inHouse.Size = new Size(90, 24);
            radio_addPart_inHouse.TabIndex = 27;
            radio_addPart_inHouse.TabStop = true;
            radio_addPart_inHouse.Text = "In-House";
            radio_addPart_inHouse.UseVisualStyleBackColor = true;
            radio_addPart_inHouse.CheckedChanged += radio_addPart_inHouse_CheckedChanged;
            // 
            // lab_addPart_machine
            // 
            lab_addPart_machine.AutoSize = true;
            lab_addPart_machine.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addPart_machine.Location = new Point(12, 235);
            lab_addPart_machine.Name = "lab_addPart_machine";
            lab_addPart_machine.Size = new Size(101, 23);
            lab_addPart_machine.TabIndex = 26;
            lab_addPart_machine.Text = "Machine ID:";
            lab_addPart_machine.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addPart_min
            // 
            lab_addPart_min.AutoSize = true;
            lab_addPart_min.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addPart_min.Location = new Point(209, 195);
            lab_addPart_min.Name = "lab_addPart_min";
            lab_addPart_min.Size = new Size(43, 23);
            lab_addPart_min.TabIndex = 25;
            lab_addPart_min.Text = "Min:";
            lab_addPart_min.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addPart_max
            // 
            lab_addPart_max.AutoSize = true;
            lab_addPart_max.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addPart_max.Location = new Point(67, 198);
            lab_addPart_max.Name = "lab_addPart_max";
            lab_addPart_max.Size = new Size(46, 23);
            lab_addPart_max.TabIndex = 24;
            lab_addPart_max.Text = "Max:";
            lab_addPart_max.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addPart_price
            // 
            lab_addPart_price.AutoSize = true;
            lab_addPart_price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addPart_price.Location = new Point(11, 162);
            lab_addPart_price.Name = "lab_addPart_price";
            lab_addPart_price.Size = new Size(102, 23);
            lab_addPart_price.TabIndex = 23;
            lab_addPart_price.Text = "Price / Cost:";
            lab_addPart_price.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addPart_inventory
            // 
            lab_addPart_inventory.AutoSize = true;
            lab_addPart_inventory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addPart_inventory.Location = new Point(27, 130);
            lab_addPart_inventory.Name = "lab_addPart_inventory";
            lab_addPart_inventory.Size = new Size(86, 23);
            lab_addPart_inventory.TabIndex = 22;
            lab_addPart_inventory.Text = "Inventory:";
            lab_addPart_inventory.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addPart_name
            // 
            lab_addPart_name.AutoSize = true;
            lab_addPart_name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addPart_name.Location = new Point(53, 97);
            lab_addPart_name.Name = "lab_addPart_name";
            lab_addPart_name.Size = new Size(60, 23);
            lab_addPart_name.TabIndex = 21;
            lab_addPart_name.Text = "Name:";
            lab_addPart_name.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addPart_ID
            // 
            lab_addPart_ID.AutoSize = true;
            lab_addPart_ID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addPart_ID.Location = new Point(82, 64);
            lab_addPart_ID.Name = "lab_addPart_ID";
            lab_addPart_ID.Size = new Size(31, 23);
            lab_addPart_ID.TabIndex = 20;
            lab_addPart_ID.Text = "ID:";
            lab_addPart_ID.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_addPart_addPart
            // 
            lab_addPart_addPart.AutoSize = true;
            lab_addPart_addPart.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lab_addPart_addPart.Location = new Point(12, 9);
            lab_addPart_addPart.Name = "lab_addPart_addPart";
            lab_addPart_addPart.Size = new Size(96, 30);
            lab_addPart_addPart.TabIndex = 19;
            lab_addPart_addPart.Text = "Add Part";
            // 
            // AddPartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 322);
            Controls.Add(btn_addPart_cancel);
            Controls.Add(btn_addPart_save);
            Controls.Add(tbox_addPart_min);
            Controls.Add(tbox_addPart_machine);
            Controls.Add(tbox_addPart_max);
            Controls.Add(tbox_addPart_price);
            Controls.Add(tbox_addPart_name);
            Controls.Add(tbox_addPart_inventory);
            Controls.Add(tbox_addPart_ID);
            Controls.Add(radio_addPart_outsourced);
            Controls.Add(radio_addPart_inHouse);
            Controls.Add(lab_addPart_machine);
            Controls.Add(lab_addPart_min);
            Controls.Add(lab_addPart_max);
            Controls.Add(lab_addPart_price);
            Controls.Add(lab_addPart_inventory);
            Controls.Add(lab_addPart_name);
            Controls.Add(lab_addPart_ID);
            Controls.Add(lab_addPart_addPart);
            Name = "AddPartScreen";
            Text = "Part";
            Load += AddPartScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_addPart_cancel;
        private Button btn_addPart_save;
        private TextBox tbox_addPart_min;
        private TextBox tbox_addPart_machine;
        private TextBox tbox_addPart_max;
        private TextBox tbox_addPart_price;
        private TextBox tbox_addPart_name;
        private TextBox tbox_addPart_inventory;
        private TextBox tbox_addPart_ID;
        private RadioButton radio_addPart_outsourced;
        private RadioButton radio_addPart_inHouse;
        private Label lab_addPart_machine;
        private Label lab_addPart_min;
        private Label lab_addPart_max;
        private Label lab_addPart_price;
        private Label lab_addPart_inventory;
        private Label lab_addPart_name;
        private Label lab_addPart_ID;
        private Label lab_addPart_addPart;
    }
}