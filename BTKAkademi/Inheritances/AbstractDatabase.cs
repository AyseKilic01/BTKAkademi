using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi.Inheritances
{
    abstract class AbstractDatabase
    {
        public abstract void Add();
        public abstract void Update();
        public abstract void Delete();
    }

    class SqlServ : AbstractDatabase
    {
        public override void Add()
        {
            MessageBox.Show("Abstract Added");
        }

        public override void Delete()
        {
            MessageBox.Show("Abstract Deleted");
        }

        public override void Update()
        {
            MessageBox.Show("Abstract Updated");
        }
    }
}
