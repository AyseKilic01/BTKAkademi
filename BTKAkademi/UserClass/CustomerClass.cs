using BTKAkademi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKAkademi.UserClass
{
    class CustomerClass
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }
        public void Update(ICustomerDal customer)
        {
            customer.Update();
        }
        public void Delete(ICustomerDal customer)
        {
            customer.Delete();
        }
    }
}
