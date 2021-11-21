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
    public partial class CalisanProblemSayfasi : Form
    {
        public CalisanProblemSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(kullaniciadi.Text == string.Empty) && !(alanid.Text == string.Empty) && !(sinifid.Text == string.Empty) && !(mudaheleid.Text == string.Empty)
             && !(aktiviteid.Text == string.Empty) && !(aktiviteaciklama.Text == string.Empty) && !(problemid.Text == string.Empty) && !(tarih.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO CalisanProblem (ProblemID, KullaniciAdi, AlanID, SinifID, MudaheleID, AktiviteID, AktiviteAciklama, Tarihi) " +
                        "Values (@problemID, @kullaniciAdi, @alanID, @sinifID, @mudaheleID, @aktiviteID, @aktiviteAciklama,  @degerlendirmeTarihi);";
                    CalisanProblem calisanProblem = new CalisanProblem
                    {
                        kullaniciAdi= kullaniciadi.Text,
                        alanID = alanid.Text,
                        sinifID =sinifid.Text,
                        mudaheleID = mudaheleid.Text,
                        aktiviteID = aktiviteid.Text,
                        aktiviteAciklama = aktiviteaciklama.Text,   
                        degerlendirmeTarihi = Convert.ToDateTime(tarih.Text),
                        problemID= problemid.Text,


                    };
                    connection.Execute(sql, calisanProblem);
                    this.Hide();
                    MudurPage f1 = new MudurPage();
                    f1.ShowDialog();
                }
            }



            else
            {
                MessageBox.Show("Lütfen bilgileri  giriniz.", "Calisan Problem  page");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
