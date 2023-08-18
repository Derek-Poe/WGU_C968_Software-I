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
    public partial class ModifyPartScreen : Form
    {
        public ModifyPartScreen(Inhouse part)
        {
            InitializeComponent();
            tbox_modPart_ID.Text = part.PartID.ToString();
            tbox_modPart_name.Text = part.Name.ToString();
            tbox_modPart_inventory.Text = part.InStock.ToString();
            tbox_modPart_price.Text = part.Price.ToString();
            tbox_modPart_max.Text = part.Max.ToString();
            tbox_modPart_min.Text = part.Min.ToString();
            tbox_modPart_machine.Text = part.MachineID.ToString();
            radio_modPart_inHouse.Checked = true;
        }
        public ModifyPartScreen(Outsourced part)
        {
            InitializeComponent();
            tbox_modPart_ID.Text = part.PartID.ToString();
            tbox_modPart_name.Text = part.Name.ToString();
            tbox_modPart_inventory.Text = part.InStock.ToString();
            tbox_modPart_price.Text = part.Price.ToString();
            tbox_modPart_max.Text = part.Max.ToString();
            tbox_modPart_min.Text = part.Min.ToString();
            tbox_modPart_machine.Text = part.CompanyName.ToString();
            radio_modPart_outsourced.Checked = true;
        }

        private void updateMachineOrCompany()
        {
            if (radio_modPart_inHouse.Checked)
            {
                lab_modPart_machine.Text = "Machine ID:";
            }
            else
            {
                lab_modPart_machine.Text = "Company ID:";
            }
        }

        private void ModifyPartScreen_Load(object sender, EventArgs e)
        {
            updateMachineOrCompany();
        }

        private void radio_modPart_inHouse_CheckedChanged(object sender, EventArgs e)
        {
            updateMachineOrCompany();
        }

        private void btn_modPart_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modPart_save_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal price;
            int max;
            int min;
            int id = int.Parse(tbox_modPart_ID.Text);
            try
            {
                quantity = int.Parse(tbox_modPart_inventory.Text);
                price = int.Parse(tbox_modPart_price.Text);
                max = int.Parse(tbox_modPart_max.Text);
                min = int.Parse(tbox_modPart_min.Text);
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
            if (quantity < min || quantity > max)
            {
                MessageBox.Show($"Error: The inventory quantity cannot currently be less than {min} or greater than {max}.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbox_modPart_name.Text))
            {
                MessageBox.Show("Error: Name cannot be blank.");
                return;
            }
            if (radio_modPart_inHouse.Checked)
            {
                int machine;
                try
                {
                    machine = int.Parse(tbox_modPart_machine.Text);
                }
                catch
                {
                    MessageBox.Show("Error: Machine IDs must be a number.");
                    return;
                }
                Inventory.updatePart(id,new Inhouse(id, tbox_modPart_name.Text, price, quantity, min, max, machine));
            }
            else
            {
                Inventory.updatePart(id, new Outsourced(id, tbox_modPart_name.Text, price, quantity, min, max, tbox_modPart_machine.Text));
            }
            this.Close();
        }
    }
}
