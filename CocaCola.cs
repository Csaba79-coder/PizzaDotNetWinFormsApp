using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDotNetWinFormsApp
{
    class CocaCola
    {
        public Decimal price = Decimal.Zero;
        private double priceOfCola;

        public CocaCola()
        {
            priceOfCola = 1.49;
            // this.price = 399;
            this.price = Convert.ToDecimal(priceOfCola);
        }
    }
}
