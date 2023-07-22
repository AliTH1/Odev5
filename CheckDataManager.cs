using Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
	internal class CheckDataManager
	{
		public void Check(ICheckDataService checkData)
		{
			checkData.Check();
		}
	}
}
