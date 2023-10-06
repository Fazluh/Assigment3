using InterfaceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class BookOrder
    {
        static void Main(string[] args)
        {
            order ord = new order();
            Console.WriteLine("Enter Product_ID :");
            ord.prod_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name : ");
            ord.ProductName = Console.ReadLine();
            Console.WriteLine("Enter the Quantity Of Product You want :");
            ord.prod_qty = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Price of Product");
            ord.ProductPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the Customer_Name");
            ord.cust_name = Console.ReadLine();
            Console.WriteLine("Enter the Customer_ID");
            ord.cust_id = Convert.ToInt32(Console.ReadLine());
            ord.dateOfBookingOrder();
            ord.orderDateOfBookingOrder();
            ord.totalPrice(ord.ProductQty , ord.ProductPrice);
            Console.ReadLine();
        }
    }
}
