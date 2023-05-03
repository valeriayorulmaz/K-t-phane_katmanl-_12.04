using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;

namespace Business
{
    public class control1
    {

        public static bool Yurut(Kitaplar kitap)
        {
            if (kitap.kad != null && kitap.kad.Trim().Length > 0)
            {
                return Crud_Kitaplar.kekle(kitap);
            }
            return false;
        }
    }
}
