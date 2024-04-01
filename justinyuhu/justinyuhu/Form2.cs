using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justinyuhu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("T-SHIRT");
            comboBox1.Items.Add("SHORT");
            comboBox1.Items.Add("HOODIE");
            comboBox1.Items.Add("SOCKS");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            int quantity, price, prod;
            quantity = int.Parse(cbmQuanti.Text);
            price = int.Parse(TxtPrice.Text);
            prod = quantity * price;
            txttotal.Text = prod.ToString();
        }
    }
}
