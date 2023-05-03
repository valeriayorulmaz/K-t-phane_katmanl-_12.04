using Entity;
using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;


namespace Business
{
    public class controlüye
    {

        public static bool Yurut(Üyeler üye)
        {
            if (üye.uadsoyad != null && üye.uadsoyad.Trim().Length > 0)
            {
                return Crud_Üyeler.uekle(üye);
            }
            return true;
        }
    }
}
