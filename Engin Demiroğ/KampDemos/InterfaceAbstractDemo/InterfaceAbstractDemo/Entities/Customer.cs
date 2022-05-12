using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        
        public DateTime DateOfBirth  { get; set; }
        public String NationalId { get; set; }
       
    }
}
