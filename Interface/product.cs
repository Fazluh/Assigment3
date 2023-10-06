using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace InterfaceExample
{
    public class product
    {
        public int prod_id;

        public int ProductId
        {
            get { return prod_id; }
            set
            {
                if (value < 0)
                {
                    prod_id = value;
                }
                else
                {
                    Console.WriteLine("Not a valid ID --");
                }
            }
        }

       public string prod_name;

        public string ProductName
        {
            get { return prod_name; }
            set
            {
                if (value.Length < 0 && value.Length > 25)
                {
                    prod_name = value;
                }
                else
                {
                    Console.WriteLine("Name is either to short or two long");
                }
            }
        }

        public decimal prod_qty;
        public decimal ProductQty
        {
            get { return prod_qty; }
            set { prod_qty = value; }
        }
        private decimal prod_price;
        public decimal ProductPrice
        {
            get { return prod_price; }
            set { prod_price = value; }
        }
        public void totalPrice(decimal qty,decimal price)
        {
            decimal amt =qty * price;
            Console.WriteLine($"The total Purchase Price of {prod_qty} items you ordered is = {amt} ");
        }


    }
}
