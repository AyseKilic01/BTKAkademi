using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTKAkademi.Collections
{
    class ExampleCollect
    {
       public void Collect()
        {
            //liste tanımını bu şekilde yapmak yerine ArrayList kullanarak plansız oluşacak durumlar için önden bir hazırlık yapmış
            //olacağız
            //string[] cities = new string[2] {"Ankara", "Malatya"}; 
            //cities = new string[3];
            //cities[2] = "İstanbul";
            //MessageBox.Show(cities[0]);
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Malatya");
            foreach(var city in cities)
            {
                MessageBox.Show(" " + city);
            }
        }
    }
}
