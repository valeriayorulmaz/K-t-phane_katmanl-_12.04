using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Emanetler
    {
        private int _emanetno;
        private int _uyeno;
        private int _kitapno;
        private DateTime _veristarihi;
        private DateTime _iadetarihi;
        private string _kitapdurumu;

        public int emanetno
        {
            get { return _emanetno; }
            set
            {
                _emanetno = value;
            }
        }
        public int uyeno
        {
            get { return _uyeno; }
            set
            {
                _uyeno = value;
            }
        }
        public int kitapno
        {
            get { return _kitapno; }
            set
            {
                _kitapno = value;
            }
        }
        public DateTime veristarihi
        {
            get { return _veristarihi;}
            set
            {
                _veristarihi = value;
            }
        }
        public DateTime iadetarihi
        {
            get { return _iadetarihi;}
            set
            {
                _iadetarihi = value;
            }
        }
        public string kitapdurumu
        {
            get { return _kitapdurumu;}
            set
            {
                _kitapdurumu = value;
            }
        }
    }
}
