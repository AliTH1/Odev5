using Odev5.Abstract;
using Odev5.Entities;

namespace Odev5.Implementations
{
    internal class CompanyManager : IOperation
    {
        public void SignUp()
        {
            Console.WriteLine("New company registered");
        }

        public void Update()
        {
            Console.WriteLine("Company updated");
        }

        public void Delete()
        {
            Console.WriteLine("Company deleted");
        }
    }
}
