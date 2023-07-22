using Odev5.Abstract;
using Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5.Implementations
{
    internal class CheckDataService : ICheckDataService
    {
        public void Check()
        {
            Console.WriteLine("Correct data");
        }
    }
}
