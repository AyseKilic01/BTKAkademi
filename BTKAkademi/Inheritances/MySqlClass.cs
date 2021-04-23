using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKAkademi.Inheritances
{
    class MySqlClass:Database
    {
        public override void Add()
        {
            base.Add();
        }
        public override void Delete()
        {
            base.Delete();
        }
        public override void Update()
        {
            base.Update();
        }
    }
}
