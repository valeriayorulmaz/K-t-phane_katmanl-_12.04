using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Üyeler
    {
        private int _uyeno;
        private string _uadsoyad;
        private string _utel;
        private string _uposta ;
        private string _uadres; 
    
        public int uyeno
        {
            get {  return _uyeno; }
            set { _uyeno = value; }
        }
        public string uadsoyad
        {
            get { return _uadsoyad; }
            set { _uadsoyad = value; }
        }
        public string utel
        {
            get { return _utel; }
            set { _utel = value; }
        }
        public string uposta
        {
            get { return _uposta; }
            set { _uposta = value; }
        }
        public string uadres
        {
            get { return _uadres ; }
            set { _uadres = value; }
        }
        
    }
}
