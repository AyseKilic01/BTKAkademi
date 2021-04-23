using BTKAkademi.Forms;
using BTKAkademi.Interfaces;
using BTKAkademi.ServerClass;
using BTKAkademi.UserClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();
        }
        //IPerson person = new IPerson(); interface olarak bir nesneyi türetemezsin. implemente ettiğin classları kullanarak oluşturabilirsin.
        //IPerson person = new Customer(); bu şekilde.
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            ServerControl control = new ServerControl();
            control.Show();
            this.Hide();
        }

        private void btnGoVirtual_Click(object sender, EventArgs e)
        {
            VirtualServerControl control = new VirtualServerControl();
            control.Show();
            this.Hide();
        }
    }
}
