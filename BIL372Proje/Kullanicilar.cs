using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL372Proje
{
    public class Kullanicilar
    {
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ kullaniciadi }  { sifre }";
            }
        }
    }
}
