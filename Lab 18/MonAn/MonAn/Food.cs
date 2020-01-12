using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAn
{
	class Food
	{
		string name;
		string price;

		public Food()
		{

		}

		public Food(string name, string price)
		{
			this.name = name;
			this.price = price;
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Price
		{
			get { return price; }
			set { price = value; }
		}
	}
}
