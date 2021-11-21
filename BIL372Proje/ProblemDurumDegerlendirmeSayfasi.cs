using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace BIL372Proje
{
    public partial class ProblemDurumDegerlendirmeSayfasi : Form
    {
        public ProblemDurumDegerlendirmeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(degerlendirenkullaniciadi.Text == string.Empty) && !(yenihedef.Text == string.Empty) && !(oncekiproblemskoru.Text == string.Empty) && !(tahminedilenproblemskoru.Text == string.Empty)
              && !(yeniproblemtanimi.Text == string.Empty) && !(problemidtext.Text == string.Empty) && !(yeniproblemid.Text == string.Empty) && !(degerlendirmetarihi.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO ProblemDurumDegerlendirme (ProblemID, YeniProblemID, YeniProblemTanımı, YeniHedef, OncekiProblemSkoru, TahminEdilenProblemSkoru, DegerlendirenKullaniciAdi, DegerlendirmeTarihi) " +
                        "Values (@problemID, @yeniProblemID, @yeniProblemTanimi, @yeniHedef, @oncekiProblemSkoru, @tahminEdilenProblemSkoru, @degerlendirenKullaniciAdi,  @degerlendirmeTarihi);";
                    ProblemDurumDegerlendirme problemDurumDegerlendirme = new ProblemDurumDegerlendirme
                    {                       
                        degerlendirenKullaniciAdi = degerlendirenkullaniciadi.Text,
                        yeniHedef = yenihedef.Text,
                        oncekiProblemSkoru = Int16.Parse(oncekiproblemskoru.Text),
                        tahminEdilenProblemSkoru = Int16.Parse(tahminedilenproblemskoru.Text),
                        yeniProblemTanimi = yeniproblemtanimi.Text,
                        problemID = problemidtext.Text,
                        yeniProblemID = yeniproblemid.Text,
                        degerlendirmeTarihi = Convert.ToDateTime(degerlendirmetarihi.Text),


                    };
                    connection.Execute(sql, problemDurumDegerlendirme);
                    this.Hide();
                    MudurPage f1 = new MudurPage();
                    f1.ShowDialog();
                }
            }



            else
            {
                MessageBox.Show("Lütfen bilgileri  giriniz.", "Problem Durum Degerlendirme  page");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MudurPage f1 = new MudurPage();
            f1.ShowDialog();
        }
    }
}
