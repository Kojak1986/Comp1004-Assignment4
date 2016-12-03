using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Assignment4
{
    public partial class ProductInfoForm : Form
    {
        public SelectForm previousForm;
        
        
        public ProductInfoForm()
        {
            InitializeComponent();
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectAnotherButton_Click(object sender, EventArgs e)
        {
            
           this.previousForm.Show();
           this.Close();
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.previousForm = this;

            this.Hide();
            order.Show();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        //grab selected info and populate
        private void LoadForm()
        {
            string savedCost = Program.myProduct.cost.ToString();
            double convertCost = Convert.ToDouble(savedCost);

            ProductIdTextBox.Text = Program.myProduct.productID.ToString();
            ConditionTextBox.Text = Program.myProduct.condition.ToString();
            CostTextBox.Text = convertCost.ToString("C2");
            PlatformTextBox.Text = Program.myProduct.platform.ToString();
            OSTextBox.Text = Program.myProduct.OS.ToString();
            ManufacturerTextBox.Text = Program.myProduct.manufacturer.ToString();
            ModelTextBox.Text = Program.myProduct.model.ToString();
            MemoryTextBox.Text = Program.myProduct.RAM_size.ToString();
            LCDTextBox.Text = Program.myProduct.screensize.ToString();
            HDDTextBox.Text = Program.myProduct.HDD_size.ToString();
            CPUBrandTextBox.Text = Program.myProduct.CPU_brand.ToString();
            CPUNumberTextBox.Text = Program.myProduct.CPU_number.ToString();
            CPUTypeTextBox.Text = Program.myProduct.CPU_type.ToString();
            CPUSpeedTextBox.Text = Program.myProduct.CPU_speed.ToString();
            GPUTypeTextBox.Text = Program.myProduct.GPU_Type.ToString();
            WebCamTextBox.Text = Program.myProduct.webcam.ToString();
               
            
           
                   
        }
    }
}
