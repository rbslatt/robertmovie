using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reynaldprojiiii
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("MATCHA");
            comboBox1.Items.Add("AMERIKANO");
            comboBox1.Items.Add("CAPPUCINNO");
            comboBox1.Items.Add("MOCHA LATTE");
            comboBox1.Items.Add("CARAMEL MACHIATTO");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int quantity, price, prod;
            quantity = int.Parse(cmbQu.Text);
            price = int.Parse(cmbPrice.Text);
            prod = quantity * price;
           txtTotal.Text = prod.ToString();
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
           

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
