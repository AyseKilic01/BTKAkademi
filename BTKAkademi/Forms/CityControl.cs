using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTKAkademi.Collections;

namespace BTKAkademi.Forms
{
    public partial class CityControl : Form
    {
        ExampleCollect cs = new ExampleCollect();
        ExceptionClass vs = new ExceptionClass();
        public CityControl()
        {
            InitializeComponent();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            cs.Collect();
        }

        private void btnExcept_Click(object sender, EventArgs e)
        {
            vs.Except();
        }
    }
}
