using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class customer:product
    {
		public int cust_id;

		public int CustomerId
		{
			get { return cust_id; }
			set
			{
				if (value != 0)
				{
					cust_id = value;
				}
				else
				{
					Console.Write("Not a valid Customer ID");
				}
			}
		}

	public string cust_name;

		public string CustomerName
		{
			get { return cust_name; }
			set
			{
				if (value.Length > 0 && value.Length < 25)
				{ 
					cust_name = value;
				}
				else
				{
                    Console.WriteLine("Customer Name is too long : ");
                }

			}
		}


	}
}
