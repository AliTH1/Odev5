using Odev5;
using Odev5.Abstract;
using Odev5.Implementations;

AccountManager accountManager = new AccountManager();

IOperation company = new CompanyManager();
IOperation person = new PersonManager();


accountManager.SignUp(person);
accountManager.SignUp(company);

ISale companySale = new SaleCompanyService();
ISale gameSale = new SaleGameService();

companySale.Sale();
gameSale.Sale();