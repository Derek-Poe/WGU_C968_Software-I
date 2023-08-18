namespace C968_001340166
{
    partial class ModifyPartScreen
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
            btn_modPart_cancel = new Button();
            btn_modPart_save = new Button();
            tbox_modPart_min = new TextBox();
            tbox_modPart_machine = new TextBox();
            tbox_modPart_max = new TextBox();
            tbox_modPart_price = new TextBox();
            tbox_modPart_name = new TextBox();
            tbox_modPart_inventory = new TextBox();
            tbox_modPart_ID = new TextBox();
            radio_modPart_outsourced = new RadioButton();
            radio_modPart_inHouse = new RadioButton();
            lab_modPart_machine = new Label();
            lab_modPart_min = new Label();
            lab_modPart_max = new Label();
            lab_modPart_price = new Label();
            lab_modPart_inventory = new Label();
            lab_modPart_name = new Label();
            lab_modPart_ID = new Label();
            lab_modPart_modifyPart = new Label();
            SuspendLayout();
            // 
            // btn_modPart_cancel
            // 
            btn_modPart_cancel.Location = new Point(251, 270);
            btn_modPart_cancel.Name = "btn_modPart_cancel";
            btn_modPart_cancel.Size = new Size(94, 29);
            btn_modPart_cancel.TabIndex = 56;
            btn_modPart_cancel.Text = "Cancel";
            btn_modPart_cancel.UseVisualStyleBackColor = true;
            btn_modPart_cancel.Click += btn_modPart_cancel_Click;
            // 
            // btn_modPart_save
            // 
            btn_modPart_save.Location = new Point(123, 270);
            btn_modPart_save.Name = "btn_modPart_save";
            btn_modPart_save.Size = new Size(94, 29);
            btn_modPart_save.TabIndex = 55;
            btn_modPart_save.Text = "Save";
            btn_modPart_save.UseVisualStyleBackColor = true;
            btn_modPart_save.Click += btn_modPart_save_Click;
            // 
            // tbox_modPart_min
            // 
            tbox_modPart_min.Location = new Point(262, 190);
            tbox_modPart_min.Name = "tbox_modPart_min";
            tbox_modPart_min.Size = new Size(83, 27);
            tbox_modPart_min.TabIndex = 54;
            // 
            // tbox_modPart_machine
            // 
            tbox_modPart_machine.Location = new Point(123, 227);
            tbox_modPart_machine.Name = "tbox_modPart_machine";
            tbox_modPart_machine.Size = new Size(222, 27);
            tbox_modPart_machine.TabIndex = 53;
            // 
            // tbox_modPart_max
            // 
            tbox_modPart_max.Location = new Point(123, 190);
            tbox_modPart_max.Name = "tbox_modPart_max";
            tbox_modPart_max.Size = new Size(83, 27);
            tbox_modPart_max.TabIndex = 52;
            // 
            // tbox_modPart_price
            // 
            tbox_modPart_price.Location = new Point(123, 154);
            tbox_modPart_price.Name = "tbox_modPart_price";
            tbox_modPart_price.Size = new Size(222, 27);
            tbox_modPart_price.TabIndex = 51;
            // 
            // tbox_modPart_name
            // 
            tbox_modPart_name.Location = new Point(123, 89);
            tbox_modPart_name.Name = "tbox_modPart_name";
            tbox_modPart_name.Size = new Size(222, 27);
            tbox_modPart_name.TabIndex = 50;
            // 
            // tbox_modPart_inventory
            // 
            tbox_modPart_inventory.Location = new Point(123, 122);
            tbox_modPart_inventory.Name = "tbox_modPart_inventory";
            tbox_modPart_inventory.Size = new Size(222, 27);
            tbox_modPart_inventory.TabIndex = 49;
            // 
            // tbox_modPart_ID
            // 
            tbox_modPart_ID.Enabled = false;
            tbox_modPart_ID.Location = new Point(123, 56);
            tbox_modPart_ID.Name = "tbox_modPart_ID";
            tbox_modPart_ID.Size = new Size(222, 27);
            tbox_modPart_ID.TabIndex = 48;
            // 
            // radio_modPart_outsourced
            // 
            radio_modPart_outsourced.AutoSize = true;
            radio_modPart_outsourced.Location = new Point(239, 25);
            radio_modPart_outsourced.Name = "radio_modPart_outsourced";
            radio_modPart_outsourced.Size = new Size(106, 24);
            radio_modPart_outsourced.TabIndex = 47;
            radio_modPart_outsourced.TabStop = true;
            radio_modPart_outsourced.Text = "Outsourced";
            radio_modPart_outsourced.UseVisualStyleBackColor = true;
            // 
            // radio_modPart_inHouse
            // 
            radio_modPart_inHouse.AutoSize = true;
            radio_modPart_inHouse.Location = new Point(134, 26);
            radio_modPart_inHouse.Name = "radio_modPart_inHouse";
            radio_modPart_inHouse.Size = new Size(90, 24);
            radio_modPart_inHouse.TabIndex = 46;
            radio_modPart_inHouse.TabStop = true;
            radio_modPart_inHouse.Text = "In-House";
            radio_modPart_inHouse.UseVisualStyleBackColor = true;
            radio_modPart_inHouse.CheckedChanged += radio_modPart_inHouse_CheckedChanged;
            // 
            // lab_modPart_machine
            // 
            lab_modPart_machine.AutoSize = true;
            lab_modPart_machine.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modPart_machine.Location = new Point(16, 231);
            lab_modPart_machine.Name = "lab_modPart_machine";
            lab_modPart_machine.Size = new Size(101, 23);
            lab_modPart_machine.TabIndex = 45;
            lab_modPart_machine.Text = "Machine ID:";
            lab_modPart_machine.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modPart_min
            // 
            lab_modPart_min.AutoSize = true;
            lab_modPart_min.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modPart_min.Location = new Point(213, 191);
            lab_modPart_min.Name = "lab_modPart_min";
            lab_modPart_min.Size = new Size(43, 23);
            lab_modPart_min.TabIndex = 44;
            lab_modPart_min.Text = "Min:";
            lab_modPart_min.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modPart_max
            // 
            lab_modPart_max.AutoSize = true;
            lab_modPart_max.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modPart_max.Location = new Point(71, 194);
            lab_modPart_max.Name = "lab_modPart_max";
            lab_modPart_max.Size = new Size(46, 23);
            lab_modPart_max.TabIndex = 43;
            lab_modPart_max.Text = "Max:";
            lab_modPart_max.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modPart_price
            // 
            lab_modPart_price.AutoSize = true;
            lab_modPart_price.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modPart_price.Location = new Point(15, 158);
            lab_modPart_price.Name = "lab_modPart_price";
            lab_modPart_price.Size = new Size(102, 23);
            lab_modPart_price.TabIndex = 42;
            lab_modPart_price.Text = "Price / Cost:";
            lab_modPart_price.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modPart_inventory
            // 
            lab_modPart_inventory.AutoSize = true;
            lab_modPart_inventory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modPart_inventory.Location = new Point(31, 126);
            lab_modPart_inventory.Name = "lab_modPart_inventory";
            lab_modPart_inventory.Size = new Size(86, 23);
            lab_modPart_inventory.TabIndex = 41;
            lab_modPart_inventory.Text = "Inventory:";
            lab_modPart_inventory.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modPart_name
            // 
            lab_modPart_name.AutoSize = true;
            lab_modPart_name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modPart_name.Location = new Point(57, 93);
            lab_modPart_name.Name = "lab_modPart_name";
            lab_modPart_name.Size = new Size(60, 23);
            lab_modPart_name.TabIndex = 40;
            lab_modPart_name.Text = "Name:";
            lab_modPart_name.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modPart_ID
            // 
            lab_modPart_ID.AutoSize = true;
            lab_modPart_ID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modPart_ID.Location = new Point(86, 60);
            lab_modPart_ID.Name = "lab_modPart_ID";
            lab_modPart_ID.Size = new Size(31, 23);
            lab_modPart_ID.TabIndex = 39;
            lab_modPart_ID.Text = "ID:";
            lab_modPart_ID.TextAlign = ContentAlignment.TopRight;
            // 
            // lab_modPart_modifyPart
            // 
            lab_modPart_modifyPart.AutoSize = true;
            lab_modPart_modifyPart.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lab_modPart_modifyPart.Location = new Point(12, 9);
            lab_modPart_modifyPart.Name = "lab_modPart_modifyPart";
            lab_modPart_modifyPart.Size = new Size(125, 30);
            lab_modPart_modifyPart.TabIndex = 38;
            lab_modPart_modifyPart.Text = "Modify Part";
            // 
            // ModifyPartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 318);
            Controls.Add(btn_modPart_cancel);
            Controls.Add(btn_modPart_save);
            Controls.Add(tbox_modPart_min);
            Controls.Add(tbox_modPart_machine);
            Controls.Add(tbox_modPart_max);
            Controls.Add(tbox_modPart_price);
            Controls.Add(tbox_modPart_name);
            Controls.Add(tbox_modPart_inventory);
            Controls.Add(tbox_modPart_ID);
            Controls.Add(radio_modPart_outsourced);
            Controls.Add(radio_modPart_inHouse);
            Controls.Add(lab_modPart_machine);
            Controls.Add(lab_modPart_min);
            Controls.Add(lab_modPart_max);
            Controls.Add(lab_modPart_price);
            Controls.Add(lab_modPart_inventory);
            Controls.Add(lab_modPart_name);
            Controls.Add(lab_modPart_ID);
            Controls.Add(lab_modPart_modifyPart);
            Name = "ModifyPartScreen";
            Text = "Part";
            Load += ModifyPartScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_modPart_cancel;
        private Button btn_modPart_save;
        private TextBox tbox_modPart_min;
        private TextBox tbox_modPart_machine;
        private TextBox tbox_modPart_max;
        private TextBox tbox_modPart_price;
        private TextBox tbox_modPart_name;
        private TextBox tbox_modPart_inventory;
        private TextBox tbox_modPart_ID;
        private RadioButton radio_modPart_outsourced;
        private RadioButton radio_modPart_inHouse;
        private Label lab_modPart_machine;
        private Label lab_modPart_min;
        private Label lab_modPart_max;
        private Label lab_modPart_price;
        private Label lab_modPart_inventory;
        private Label lab_modPart_name;
        private Label lab_modPart_ID;
        private Label lab_modPart_modifyPart;
    }
}