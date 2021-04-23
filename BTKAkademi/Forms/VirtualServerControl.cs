using BTKAkademi.Inheritances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi.Forms
{
    public partial class VirtualServerControl : Form
    {
        public VirtualServerControl()
        {
            InitializeComponent();
        }
        SqlClass sql = new SqlClass();
        MySqlClass my = new MySqlClass();
        

        private void btnSqlAdd_Click(object sender, EventArgs e)
        {
            sql.Add();
        }

        private void btnSqlUpdate_Click(object sender, EventArgs e)
        {
            sql.Update();
        }

        private void btnSqlDelete_Click(object sender, EventArgs e)
        {
            sql.Delete();
        }

        private void btnMySqlAdd_Click(object sender, EventArgs e)
        {
            my.Add();
        }

        private void btnMySqlUpdate_Click(object sender, EventArgs e)
        {
            my.Update();
        }

        private void btnMySqlDelete_Click(object sender, EventArgs e)
        {
            my.Delete();
        }

        private void btnAllAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAllUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
