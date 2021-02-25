using ETrade.Core.DataAccess;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer> 
    {
    }
}
