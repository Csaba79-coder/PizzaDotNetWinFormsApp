using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDotNetWinFormsApp
{

    class Pizza
    {
        public Decimal price = Decimal.Zero;
        private double priceOfPizza;

        public Pizza()
        {
            priceOfPizza = 6.35;
            //this.price = ((decimal)priceOfPizza);
            // this.price = 1199;
            this.price = Convert.ToDecimal(priceOfPizza);
        }
    }
}
