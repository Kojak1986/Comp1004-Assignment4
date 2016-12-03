using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Assignment4.Models;

namespace Assignment4
{
    public partial class SelectForm : Form
    {
        private ComputerContext db = new ComputerContext();
        private product CurrentItem;
        // private table CurrentItem;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            
            this.productsTableAdapter.Fill(this.assignment4DataSet.products);
            // GetComputers();
            List < product > ProductList = (from product in db.products
                                select product).ToList();

            ComputersDataGridView.DataSource = ProductList;
        }

       

        public void SelectData(DataGridViewRow currentRow)
        {
            this.CurrentItem = (product)currentRow.DataBoundItem;
            Debug.WriteLine(this.CurrentItem.model);

            YourSelectionTextBox.Text = ProductItem(CurrentItem);
            
        }
    
        private string ProductItem(product selected)
       {
            int selectedID = selected.productID;

         string sum = selected.manufacturer + " " + selected.model;
            return sum;
        }

       

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // private void ComputersDataGridView_SelectionChanged(object sender, EventArgs e)
       // {
          //  try
          //  {
           //     ComputersDataGridView.CurrentRow.Selected = true;
           //     SelectData(ComputersDataGridView.CurrentRow);
           // }
           // catch
           // {

           // }

        //}
        Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
    
            ProductInfoForm info = new ProductInfoForm();
            info.Show();
            this.Hide();
        }

        
        //Highlight the row selected and save data into product.cs
        private void ComputersDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex != -1)
               {

                int index = e.RowIndex;
                ComputersDataGridView.Rows[index].Selected = true;

                int productID = Convert.ToInt32(ComputersDataGridView.Rows[e.RowIndex].Cells[0].Value);

               


                Program.myProduct = (from product in db.products
                                         where product.productID == productID
                                         select product).FirstOrDefault();

                    YourSelectionTextBox.Text = Program.myProduct.manufacturer.ToString();
                }

            
        }
    }
}
