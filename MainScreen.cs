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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        public static void updateGridViews()
        {
            BindingSource partsBindingSource = new BindingSource();
            partsBindingSource.DataSource = Inventory.AllParts;
            gridView_mainScreen_parts.DataSource = partsBindingSource;

            BindingSource productsBindingSource = new BindingSource();
            productsBindingSource.DataSource = Inventory.Products;
            gridView_mainScreen_products.DataSource = productsBindingSource;

            foreach (DataGridViewColumn column in gridView_mainScreen_parts.Columns)
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
            foreach (DataGridViewColumn column in gridView_mainScreen_products.Columns)
            {
                if (column.HeaderText == "InStock")
                {
                    column.HeaderText = "Inventory";
                }
                if (column.HeaderText == "ProductID")
                {
                    column.HeaderText = "Product ID";
                }
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btn_mainScreen_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mainScreen_partAdd_Click(object sender, EventArgs e)
        {
            new AddPartScreen().ShowDialog();
        }

        private void btn_mainScreen_partModify_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow;
            try
            {
                selectedRow = gridView_mainScreen_parts.CurrentRow;
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
            if (selectedRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                new ModifyPartScreen((Inhouse)selectedRow.DataBoundItem).ShowDialog();
            }
            else
            {
                new ModifyPartScreen((Outsourced)selectedRow.DataBoundItem).ShowDialog();
            }
        }

        private void btn_mainScreen_productAdd_Click(object sender, EventArgs e)
        {
            new AddProductScreen().ShowDialog();
        }

        private void btn_mainScreen_productModify_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow;
            try
            {
                selectedRow = gridView_mainScreen_products.CurrentRow;
            }
            catch
            {
                MessageBox.Show("Error: No product was selected.");
                return;
            }
            if (selectedRow == null)
            {
                MessageBox.Show("Error: No product was selected.");
                return;
            }
            new ModifyProductScreen((Product)selectedRow.DataBoundItem).ShowDialog();
        }

        private void btn_mainScreen_partDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow;
            bool deleteCheck;
            try
            {
                selectedRow = gridView_mainScreen_parts.CurrentRow;
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
            if (selectedRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                deleteCheck = Inventory.deletePart((Inhouse)selectedRow.DataBoundItem);
            }
            else
            {
                deleteCheck = Inventory.deletePart((Outsourced)selectedRow.DataBoundItem);
            }
            if (!deleteCheck)
            {
                MessageBox.Show("Error: Part was not found, so it has not been deleted.");
            }
        }

        private void btn_mainScreen_partSearch_Click(object sender, EventArgs e)
        {
            int searchID = -1;
            bool nameSearch = false;
            try
            {
                searchID = int.Parse(tbox_mainScreen_partSearch.Text);
            }
            catch
            {
                nameSearch = true;
            }
            if (searchID == -1)
            {
                nameSearch = true;
            }
            if (nameSearch)
            {
                foreach (DataGridViewRow row in gridView_mainScreen_parts.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToLower().Trim() == tbox_mainScreen_partSearch.Text.ToLower().Trim())
                    {
                        row.Selected = true;
                        return;
                    }
                }
                MessageBox.Show("Part not found.");
                return;
            }
            else
            {
                Part searchedPart = Inventory.lookupPart(searchID);
                if (searchedPart.PartID != -1)
                {
                    foreach (DataGridViewRow row in gridView_mainScreen_parts.Rows)
                    {
                        if (int.Parse(row.Cells[0].Value.ToString()) == searchID)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Part not found.");
                    return;
                }
            }
        }

        private void btn_mainScreen_productDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow;
            bool deleteCheck;
            try
            {
                selectedRow = gridView_mainScreen_products.CurrentRow;
            }
            catch
            {
                MessageBox.Show("Error: No product was selected.");
                return;
            }
            if (selectedRow == null)
            {
                MessageBox.Show("Error: No product was selected.");
                return;
            }
            if (((Product)selectedRow.DataBoundItem).AssociatedParts.Count > 0)
            {
                MessageBox.Show("Error: Product has associated parts that must be removed from product before product can be deleted.");
                return;
            }
            deleteCheck = Inventory.removeProduct(((Product)selectedRow.DataBoundItem).ProductID);
            if (!deleteCheck)
            {
                MessageBox.Show("Error: Product was not found, so it has not been deleted.");
            }
        }

        private void btn_mainScreen_productSearch_Click(object sender, EventArgs e)
        {
            int searchID = -1;
            bool nameSearch = false;
            try
            {
                searchID = int.Parse(tbox_mainScreen_productSearch.Text);
            }
            catch
            {
                nameSearch = true;
            }
            if (searchID == -1)
            {
                nameSearch = true;
            }
            if (nameSearch)
            {
                foreach (DataGridViewRow row in gridView_mainScreen_products.Rows)
                {
                    if (row.Cells[1].Value.ToString().ToLower().Trim() == tbox_mainScreen_productSearch.Text.ToLower().Trim())
                    {
                        row.Selected = true;
                        return;
                    }
                }
                MessageBox.Show("Product not found.");
                return;
            }
            else
            {
                Product searchedProduct = Inventory.lookupProduct(searchID);
                if (searchedProduct.ProductID != -1)
                {
                    foreach (DataGridViewRow row in gridView_mainScreen_products.Rows)
                    {
                        if (int.Parse(row.Cells[0].Value.ToString()) == searchID)
                        {
                            row.Selected = true;
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                    return;
                }
            }
        }
    }
}
