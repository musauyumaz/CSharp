using InterfaceAbstractDemo.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
          KPSPublicSoapClient client = new KPSPublicSoapClient();
            return Convert.ToBoolean( client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalIdentity), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year));
        }
    }
}
