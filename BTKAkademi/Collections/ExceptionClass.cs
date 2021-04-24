using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi.Collections
{
    class ExceptionClass
    {
       public void Except()
        {
            try {
                //normalde bu haliyle exception hatası verip çakılacak
                string[] city = new string[2] { "Ankara", "Malatya" };
                city[3] = "Ahmet";
            }
            catch
            {
                MessageBox.Show("EXCEPTION !!!");
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
