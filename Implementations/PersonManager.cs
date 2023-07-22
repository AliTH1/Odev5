using Odev5.Abstract;
using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Implementations
{
    internal class PersonManager : IOperation
    {
        public void SignUp()
        {
            Console.WriteLine("Account registration was successful");
        }

        public void Update()
        {
            Console.WriteLine("Account updated");
        }

        public void Delete()
        {
            Console.WriteLine("Account deleted");
        }
    }
}
