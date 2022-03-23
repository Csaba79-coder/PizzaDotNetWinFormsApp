using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDotNetWinFormsApp
{
    public partial class Form1 : Form
    {

        private static Pizza pizza;
        private static CocaCola cola;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            pizza = new Pizza();
            this.txtBoxPrice.Text = pizza.price.ToString();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            cola = new CocaCola();
            this.txtBoxPrice.Text = cola.price.ToString();
        }
    }
}
