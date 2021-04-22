using BTKAkademi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi.ServerClass
{
    class OracleServer : ICustomerDal
    {
        public void Add()
        {
            MessageBox.Show("Oracle Added");
        }

        public void Delete()
        {
            MessageBox.Show("Oracle Deleted");
        }

        public void Update()
        {
            MessageBox.Show("Oracle Updated");
        }
    }
}
