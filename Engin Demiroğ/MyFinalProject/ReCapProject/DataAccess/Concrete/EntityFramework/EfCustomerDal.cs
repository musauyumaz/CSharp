using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,Context>,ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDto()
        {
            throw new NotImplementedException();
        }

        public List<CustomerDetailDto> GetCustomerDetailDtos()
        {
            using (Context context = new Context())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.UserId
                             select new CustomerDetailDto
                             {
                                 CustomerName = u.FirstName,
                                 CustomerSurname = u.LastName,
                                 CustomerCompany = c.CompanyName
                             };
                return result.ToList();
            }
        }
    }
}