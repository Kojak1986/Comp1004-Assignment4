using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment4.Models;
using System.Diagnostics;

namespace Assignment4
{
    public partial class SelectForm : Form
    {
        private table CurrentItem;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            GetComputers();
        }

        private void GetComputers()
        {
            //Connect to the database using the Entity Framework
            ComputerComtext db = new ComputerComtext();

            //Use LINK to access the computer database
            var ProductList = (from table in db.tables
                               select table).ToList();
            ComputersDataGridView.DataSource = ProductList;
        }

        public void SelectData(DataGridViewRow currentRow)
        {
            this.CurrentItem = (table)currentRow.DataBoundItem;
            Debug.WriteLine(this.CurrentItem.model);

            YourSelectionTextBox.Text = ProductItem(CurrentItem);
        }

        private string ProductItem(table selected)
        {
            int selectedID = selected.productID;

            string sum = selected.manufacturer + " " + selected.model;
            return sum;
        }

        private void ComputersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ComputersDataGridView.CurrentRow.Selected = true;
                SelectData(ComputersDataGridView.CurrentRow);
            }
            catch
            {

            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm info = new ProductInfoForm();
            info.Show();
            this.Hide();
        }
    }
}
