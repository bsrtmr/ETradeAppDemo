using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetCustomersByCustomerName(string customerName);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
