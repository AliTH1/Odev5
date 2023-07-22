using Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5
{
	internal class AccountManager
	{
		public void SignUp(IOperation operation)
		{
			operation.SignUp();
		}

		public void Update(IOperation operation)
		{
			operation.Update();
		}

		public void Delete(IOperation operation)
		{
			operation.Delete();
		}
	}
}
