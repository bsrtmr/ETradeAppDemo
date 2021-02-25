using ETrade.Core.DataAccess.EntityFramework;
using ETrade.DataAccess.Abstract;
using ETrade.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ETradeContext>, ICustomerDal
    {
    }
}
