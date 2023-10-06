using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
   public class order:customer
    {
		public DateTime bookdate;

		public DateTime BookDate
		{
			get { return bookdate; }
			set { bookdate = value; }
		}
		public DateTime orderdate;

		public DateTime OrderDate
		{
			get { return orderdate; }
			set { orderdate = value; }
		}
		public void dateOfBookingOrder()
		{
            Console.WriteLine($"The Order is booked by {cust_name} with CustomerID {cust_id} on {bookdate}");
        }
		public void orderDateOfBookingOrder()
		{
			Console.WriteLine($"The order is placed by {cust_name} on {orderdate}");
		}
	}

}
