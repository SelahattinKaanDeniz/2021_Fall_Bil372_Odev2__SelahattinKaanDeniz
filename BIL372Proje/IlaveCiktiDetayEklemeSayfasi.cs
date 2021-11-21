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
    public partial class IlaveCiktiDetayEklemeSayfasi : Form
    {
        public IlaveCiktiDetayEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(problemIDText.Text == string.Empty) && !(sinifIDText.Text == string.Empty) && !(belirtecIDText.Text == string.Empty) && !(ekleyenKullaniciAdiText.Text == string.Empty)
              && !(siraText.Text == string.Empty) && !(eklenmeTarihiText.Text == string.Empty) && !(alanIDText.Text == string.Empty) && !(mudaheleIDText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO IlaveCiktiDetay (AlanID, SinifID, MudaheleID, ProblemID, BelirtecID, Sira, EkleyenKullaniciAdi, EklenmeTarihi) " +
                        "Values (@alanID, @sinifID, @mudaheleID, @problemID, @belirtecID, @sira, @ekleyenKullaniciAdi,  @eklenmeTarihi);";
                    IlaveCiktiDetay ilaveCiktiDetay = new IlaveCiktiDetay
                    {
                        alanID = alanIDText.Text,
                        sinifID = sinifIDText.Text,
                        mudaheleID = mudaheleIDText.Text,
                        sira = Int16.Parse(siraText.Text),
                        belirtecID = belirtecIDText.Text,
                        problemID = problemIDText.Text,
                        ekleyenKullaniciAdi = ekleyenKullaniciAdiText.Text,
                        eklenmeTarihi = Convert.ToDateTime(eklenmeTarihiText.Text),


                    };
                    connection.Execute(sql, ilaveCiktiDetay);
                    this.Hide();
                    MudurPage f1 = new MudurPage();
                    f1.ShowDialog();
                }
            }



            else
            {
                MessageBox.Show("Lütfen bilgileri  giriniz.", "Ilave Cikti  Detay page");
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
