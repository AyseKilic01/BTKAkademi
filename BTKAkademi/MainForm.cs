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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonManager person = new PersonManager();
            person.Add(new Customer { id = 1, ad = "ayse", soyad = "kilic" });
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    interface IPerson
    {
        int id { get; set; }
        string ad { get; set; }
        string soyad { get; set; }
    }
    class Customer : IPerson
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
    }
    class Student : IPerson
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson customer)
        {
            MessageBox.Show("eklendi = " + customer.ad);
        }
    }
}
