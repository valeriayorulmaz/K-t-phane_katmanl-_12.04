using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Kitaplar
    {
        private int _kitapno;
        private string _kad;
        private string _kyazar;
        private int _baskiyili;
        private int _sayfasayisi;
        private string _yayinevi;
        private string _dil;
        private string _tur;
        private string _rafkodu;

        public int kitapno
        {
            get { return _kitapno; } 
            set { _kitapno = value; }
        }
        public string kad
        {
            get { return _kad; }
            set { _kad = value; }
        }
        public string kyazar
        {
            get { return _kyazar; }
            set{_kyazar = value;}
        }
        public int baskiyili
        {
            get { return _baskiyili; }
            set{ _baskiyili = value;}
        }
        public int sayfasayisi
        {
            get { return _sayfasayisi;}
            set
            {
                _sayfasayisi = value;
            }
        }
        public string yayinevi
        {
            get { return _yayinevi; }
            set { _yayinevi = value; }
        }
        public string dil
        {
              get { return _dil; }
            set
            {
                _dil = value;
            }   
        }
        public string tur
        {
            get { return _tur; }
            set { _tur = value; }
        }
        public string rafkodu
        {
            get { return _rafkodu;}
            set
            {
                _rafkodu = value;
            }
        }
    }
}
