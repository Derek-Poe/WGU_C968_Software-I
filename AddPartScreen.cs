using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_001340166
{
    public partial class AddPartScreen : Form
    {
        public AddPartScreen()
        {
            InitializeComponent();
        }

        private void updateMachineOrCompany()
        {
            if (radio_addPart_inHouse.Checked)
            {
                lab_addPart_machine.Text = "Machine ID:";
            }
            else
            {
                lab_addPart_machine.Text = "Company ID:";
            }
        }

        private void radio_addPart_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            updateMachineOrCompany();
        }

        private void AddPartScreen_Load(object sender, EventArgs e)
        {
            radio_addPart_inHouse.Checked = true;
        }

        private void btn_addPart_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addPart_save_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal price;
            int max;
            int min;
            int id;
            try
            {
                quantity = int.Parse(tbox_addPart_inventory.Text);
                price = int.Parse(tbox_addPart_price.Text);
                max = int.Parse(tbox_addPart_max.Text);
                min = int.Parse(tbox_addPart_min.Text);
            }
            catch
            {
                MessageBox.Show("Error: The following fields must contain only numbers: \nInventory, Price / Cost, Max, Min.");
                return;
            }
            if (min > max)
            {
                MessageBox.Show("Error: The value of Min cannot be greater than Max.");
                return;
            }
            if(quantity < min || quantity > max)
            {
                MessageBox.Show($"Error: The inventory quantity cannot currently be less than {min} or greater than {max}.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbox_addPart_name.Text))
            {
                MessageBox.Show("Error: Name cannot be blank.");
                return;
            }
            if (Inventory.AllParts.Count == 0)
            {
                id = 1;
            }
            else {
                int maxNum = 0;
                foreach(Part part in Inventory.AllParts)
                {
                    if (part.PartID > maxNum)
                    {
                        maxNum = part.PartID;
                    }
                }
                id = maxNum + 1;
            }
            if (radio_addPart_inHouse.Checked)
            {
                int machine;
                try
                {
                    machine = int.Parse(tbox_addPart_machine.Text);
                }
                catch
                {
                    MessageBox.Show("Error: Machine IDs must be a number.");
                    return;
                }
                Inventory.addPart(new Inhouse(id, tbox_addPart_name.Text, price, quantity, min, max, machine));
            }
            else
            {
                Inventory.addPart(new Outsourced(id, tbox_addPart_name.Text, price, quantity, min, max, tbox_addPart_machine.Text));
            }
            MainScreen.updateGridViews();
            this.Close();
        }
    }
}
