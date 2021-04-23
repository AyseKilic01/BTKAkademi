using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi.Inheritances
{
    class SqlClass:Database
    {
        public override void Add()
        {
            //base.Add();
            MessageBox.Show("Override Sql Added");
        }
        public override void Update()
        {
            //base.Update();
            MessageBox.Show("Override Sql Updated");
        }
        public override void Delete()
        {
            //base.Delete();
            MessageBox.Show("Override Sql Deleted");
        }
    }
}
