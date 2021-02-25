using ETrade.Business.Abstract;
using ETrade.Business.ValidationRules.FluentValidation;
using ETrade.Core.Utilities;
using ETrade.DataAccess.Abstract;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            //ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            try
            {
                _customerDal.Delete(customer);
            }
            catch
            {

                throw new Exception("Silme işlemi gerçekleşemedi!");
            }
            
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetCustomersByCustomerName(string customerName)
        {
            return _customerDal.GetAll(c => c.NameSurname.ToLower().Contains(customerName.ToLower()));
        }

        public void Update(Customer customer)
        {
            //ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Update(customer);
        }
    }
}
