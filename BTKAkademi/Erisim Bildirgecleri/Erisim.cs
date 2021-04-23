using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKAkademi.Erisim_Bildirgecleri
{
    public class Erisim
    {
    }
    internal class InterValErisim
    {

    }
   class ErisimProc
    {
        protected int MyProperty { get; set; }
    }
   class ErisimPrivate
    {
        private int MyProperty { get; set; }
    }
    //private tanımlanan bir yapı bulunduğu cs bloğu içinde çağrılabilir, 
//    protected hem kendi bloğunda hem de inheritance edildiği cs bloklarından çağrılabilir,
//internal bulunduğu assembly(proje) içerisinde herhangi bir cs blogundan çağrılabilir, cs tanımı olarak kullanılabilir
//public yapılar bulunduğu proje, başka projelerde reference edilerek çağrılabilir., cs tanımı olarak kullanılabilri


}
