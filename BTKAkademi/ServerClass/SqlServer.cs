using BTKAkademi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi.ServerClass
{
    class SqlServer : ICustomerDal
    {
        public void Add()
        {
            MessageBox.Show("Sql Added");
        }

        public void Delete()
        {
            MessageBox.Show("Sql Deleted");
        }

        public void Update()
        {
            MessageBox.Show("Sql Updated");
        }
    }
}
