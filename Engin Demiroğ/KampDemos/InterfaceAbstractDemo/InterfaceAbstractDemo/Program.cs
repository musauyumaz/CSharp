using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceReference());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1999, 2, 14),
                FirstName = "Musa",
                LastName = "Uyumaz",
                NationalId = "154415484815"
            });

        }
    }
}
