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
        
        // private table CurrentItem;
        public SelectForm()
        {
            InitializeComponent();
        }

        //Pull database and display
        private void SelectForm_Load(object sender, EventArgs e)
        {
            
            this.productsTableAdapter.Fill(this.assignment4DataSet.products);
            
            List < product > ProductList = (from product in db.products
                                select product).ToList();

            ComputersDataGridView.DataSource = ProductList;
        }

       //Cancel closes app
        private void CancelButton_Click(object sender, EventArgs e)
        {
          
        Application.Exit();
        }
        //Shows next form
        private void NextButton_Click(object sender, EventArgs e)
        {

            ProductInfoForm info = new ProductInfoForm();
            info.previousForm = this;

            this.Hide();
            info.Show();
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


                string savedCost = Program.myProduct.cost.ToString();
                double convertCost = Convert.ToDouble(savedCost);

                YourSelectionTextBox.Text = Program.myProduct.manufacturer + ", " + Program.myProduct.model.ToString() + ", "
                    + convertCost.ToString("C2");





            }

            
        }
    }
}