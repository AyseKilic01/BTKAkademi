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
        SqlServ srv = new SqlServ();
        

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

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbstractAdd_Click(object sender, EventArgs e)
        {
            srv.Add();
        }

        private void btnAbstractUpdate_Click(object sender, EventArgs e)
        {
            srv.Update();
        }

        private void btnAbstractDelete_Click(object sender, EventArgs e)
        {
            srv.Delete();
        }
    }
}
