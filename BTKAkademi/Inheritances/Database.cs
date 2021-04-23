using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi.Inheritances
{
    class Database
    {
        //Update, Add, Delete
        public virtual void Add()
        {
            MessageBox.Show("Virtual Added");
        }
        public virtual void Update()
        {
            MessageBox.Show("Virtual Updated");
        }
        public virtual void Delete()
        {
            MessageBox.Show("Virtual Deleted");
        }
    }
}
