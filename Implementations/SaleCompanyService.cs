using Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Implementations
{
	internal class SaleCompanyService : ISale
	{
		public void Sale()
		{
            Console.WriteLine("Company saled");
        }
	}
}
