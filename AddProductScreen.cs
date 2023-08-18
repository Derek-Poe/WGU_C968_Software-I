using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_001340166
{
    public partial class AddProductScreen : Form
    {
        public AddProductScreen()
        {
            InitializeComponent();
        }

        private BindingList<Part> PotentialParts = new BindingList<Part>();

        private void updateAssociatedPartsGrid()
        {
            BindingSource partsBindingSource = new BindingSource();
            partsBindingSource.DataSource = PotentialParts;
            gridView_addProduct_deletePart.DataSource = partsBindingSource;

            foreach (DataGridViewColumn column in gridView_addProduct_deletePart.Columns)
            {
                if (column.HeaderText == "InStock")
                {
                    column.HeaderText = "Inventory";
                }
                if (column.HeaderText == "PartID")
                {
                    column.HeaderText = "Part ID";
                }
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in gridView_addProduct_deletePart.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void AddProductScreen_Load(object sender, EventArgs e)
        {
            BindingSource partsBindingSource = new BindingSource();
            partsBindingSource.DataSource = Inventory.AllParts;
            gridView_addProduct_addPart.DataSource = partsBindingSource;

            foreach (DataGridViewColumn column in gridView_addProduct_addPart.Columns)
            {
                if (column.HeaderText == "InStock")
                {
                    column.HeaderText = "Inventory";
                }
                if (column.HeaderText == "PartID")
                {
                    column.HeaderText = "Part ID";
                }
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in gridView_addProduct_addPart.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btn_addProduct_save_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal price;
            int max;
            int min;
            int id;
            try
            {
                quantity = int.Parse(tbox_addProduct_inventory.Text);
                price = int.Parse(tbox_addProduct_price.Text);
                max = int.Parse(tbox_addProduct_max.Text);
                min = int.Parse(tbox_addProduct_min.Text);
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
            if (string.IsNullOrWhiteSpace(tbox_addProduct_name.Text))
            {
                MessageBox.Show("Error: Name cannot be blank.");
                return;
            }
            if (Inventory.Products.Count == 0)
            {
                id = 1;
            }
            else
            {
                int maxNum = 0;
                foreach (Product product in Inventory.Products)
                {
                    if (product.ProductID > maxNum)
                    {
                        maxNum = product.ProductID;
                    }
                }
                id = maxNum + 1;
            }
            Inventory.addProduct(new Product(id, tbox_addProduct_name.Text, quantity, price, min, max));
            foreach (Part potentialPart in PotentialParts)
            {
                (Inventory.lookupProduct(id)).addAssociatedPart(potentialPart);
            }
            MainScreen.updateGridViews();
            this.Close();
        }

        private void btn_addProduct_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbox_addProduct_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addProduct_search_Click(object sender, EventArgs e)
        {
            int searchID = -1;
            try
            {
                searchID = int.Parse(tbox_addProduct_search.Text);
            }
            catch
            {
                MessageBox.Show("Error: Search input must contain Part ID (only numbers).");
                return;
            }
            if (searchID == -1)
            {
                MessageBox.Show("Error: Search input must contain Part ID (only numbers).");
                return;
            }
            Part searchedPart = Inventory.lookupPart(searchID);
            if (searchedPart.PartID != -1)
            {
                foreach (DataGridViewRow row in gridView_addProduct_addPart.Rows)
                {
                    if (int.Parse(row.Cells[0].Value.ToString()) == searchID)
                    {
                        row.Selected = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Part not found.");
                return;
            }
        }

        private void btn_addProduct_add_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow;
            try
            {
                selectedRow = gridView_addProduct_addPart.CurrentRow;
            }
            catch
            {
                MessageBox.Show("Error: No part was selected.");
                return;
            }
            if (selectedRow == null)
            {
                MessageBox.Show("Error: No part was selected.");
                return;
            }
            foreach (Part potentialPart in PotentialParts)
            {
                if (int.Parse(selectedRow.Cells[0].Value.ToString()) == potentialPart.PartID)
                {
                    MessageBox.Show("Error: The selected part is already associated.");
                    return;
                }
            }
            PotentialParts.Add((Part)selectedRow.DataBoundItem);
            updateAssociatedPartsGrid();
        }

        private void btn_addProduct_delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow;
            try
            {
                selectedRow = gridView_addProduct_deletePart.CurrentRow;
            }
            catch
            {
                MessageBox.Show("Error: No part was selected.");
                return;
            }
            if (selectedRow == null)
            {
                MessageBox.Show("Error: No part was selected.");
                return;
            }
            foreach (Part potentialPart in PotentialParts)
            {
                if (int.Parse(selectedRow.Cells[0].Value.ToString()) == potentialPart.PartID)
                {
                    PotentialParts.Remove(potentialPart);
                    updateAssociatedPartsGrid();
                    return;
                }
            }
        }
    }
}
