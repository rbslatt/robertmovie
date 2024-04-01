using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robertmoviessss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTot_Click(object sender, EventArgs e)
        {
            int quantity, price, prod;
            quantity = int.Parse(Txtquan.Text);
            price = int.Parse(Txtprice.Text);
            prod = quantity * price;
            Txttotal.Text = prod.ToString();






        }

        private void Txttotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
