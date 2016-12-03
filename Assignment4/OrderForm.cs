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
    public partial class OrderForm : Form
    {
        public ProductInfoForm previousForm;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            string savedCost = Program.myProduct.cost.ToString();
            double convertCost = Convert.ToDouble(savedCost);
            double tax = convertCost * 0.13;
            double total = tax + convertCost;

            
            ConditionTextBox.Text = Program.myProduct.condition.ToString();
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

            PriceTextBox.Text = convertCost.ToString("C2");
            SalesTaxTextBox.Text = tax.ToString("C2");
            TotalTextBox.Text = total.ToString("C2");

            getPic();
        }

        public void getPic()
        {
            string man = Program.myProduct.manufacturer.ToString();

            if(man == "Apple")
            {
                ProductPictureBox.Image = Properties.Resources.apple;
            }
            if (man == "Acer")
            {
                ProductPictureBox.Image = Properties.Resources.acer;
            }
            if (man == "Asus ")
            {
                ProductPictureBox.Image = Properties.Resources.asus;
            }
            if (man == "Gateway ")
            {
                ProductPictureBox.Image = Properties.Resources.gateway;
            }
            if (man == "HP ")
            {
                ProductPictureBox.Image = Properties.Resources.hp;
            }
            if (man == "CybertronPC")
            {
                ProductPictureBox.Image = Properties.Resources.cypertron;
            }
            if (man == "iBUYPOWER")
            {
                ProductPictureBox.Image = Properties.Resources.ibuypower;
            }
            if (man == "Lenovo ")
            {
                ProductPictureBox.Image = Properties.Resources.lenovo;
            }
            if (man == "Toshiba ")
            {
                ProductPictureBox.Image = Properties.Resources.toshiba;
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you very much for your order!" + "\r\n" + "Dollar Computers appriciates your business!" + "\r\n"
                + "Your order will arrive in the next couple weeks!", "Order Processed");
            Application.Exit();
        }
    }
}
