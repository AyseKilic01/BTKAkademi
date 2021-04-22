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
        CustomerClass manager = new CustomerClass();
        PersonManager person = new PersonManager();
        public MainForm()
        {
            InitializeComponent();
        }
        //IPerson person = new IPerson(); interface olarak bir nesneyi türetemezsin. implemente ettiğin classları kullanarak oluşturabilirsin.
        //IPerson person = new Customer(); bu şekilde.
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {     
            person.Add(new Customer { id = 1, ad = "ayse", soyad = "kilic" });
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSqlAdd_Click(object sender, EventArgs e)
        {
            
            manager.Add(new SqlServer());
        }

        private void btnSqlUpdate_Click(object sender, EventArgs e)
        {

            manager.Update(new SqlServer());
        }

        private void btnSqlDelete_Click(object sender, EventArgs e)
        {

            manager.Delete(new SqlServer());
        }

        private void btnOracleAdd_Click(object sender, EventArgs e)
        {

            manager.Add(new OracleServer());
        }

        private void btnOracleUpdate_Click(object sender, EventArgs e)
        {

            manager.Update(new OracleServer());
        }

        private void btnOracleDelete_Click(object sender, EventArgs e)
        {
 
            manager.Delete(new OracleServer());
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
