using Odev5.Abstract;
using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
	internal class SaleManager
	{
		public void Sale(ISale sale)
		{
			sale.Sale();
        }
	}
}
