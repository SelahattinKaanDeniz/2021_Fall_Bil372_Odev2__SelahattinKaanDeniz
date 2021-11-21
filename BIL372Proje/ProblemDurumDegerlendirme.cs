using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIL372Proje
{
    public class ProblemDurumDegerlendirme
    {
        public string problemID { get; set; }
        public string yeniProblemID { get; set; }

        public string yeniProblemTanimi { get; set; }
        public string yeniHedef { get; set; }
        public int oncekiProblemSkoru { get; set; }

        public int tahminEdilenProblemSkoru { get; set; }

        public DateTime degerlendirmeTarihi { get; set; }

        public string degerlendirenKullaniciAdi { get; set; }
        


    }
}
