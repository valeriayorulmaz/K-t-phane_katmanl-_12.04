using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Kullanıcalar
    {
        private int _kullanicino;
        private string _kullaniciadi;
        private string _sifre;

        public int kullanicino
        {
            get { return _kullanicino; }
            set { _kullanicino = value; }
        }
        public string kullaniciadi
        {
            get { return _kullaniciadi; }
            set { _kullaniciadi = value; }
        }
        public string sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        }

    }
}
