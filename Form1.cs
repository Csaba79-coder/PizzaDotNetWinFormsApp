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
        private static bool isMenu = false;
        private static double  discount = 0.1;
        private static Decimal total;
        

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
            
            if (isMenu)
            {
                cola = new CocaCola();

                Decimal itemDiscount = pizza.price * (decimal)discount;
                pizza.price -= itemDiscount;
                total = pizza.price + cola.price;

                this.txtBoxPrice.Text = total.ToString("0.00");
            } else
            {
                total += pizza.price;
            }


            this.txtBoxPrice.Text = total.ToString("0.00");
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            cola = new CocaCola();
            total += cola.price;
            this.txtBoxPrice.Text = total.ToString("0.00");
        }

        private void checkBoxMenu_CheckedChanged(object sender, EventArgs e)
        {
            isMenu = true;
            /*discount = (decimal)Convert.ToDouble(discountPrice);

            if (isMenu)
            {
                pizza = new Pizza();
                cola = new CocaCola();

                Decimal total = (pizza.price + cola.price);
                total *= discount;
                this.txtBoxPrice.Text = total.ToString();
            }*/
        }
    }
}
