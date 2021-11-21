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
    public partial class IlaveMudaheleDetayEkleSayfasi : Form
    {
        public IlaveMudaheleDetayEkleSayfasi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(problemIDText.Text == string.Empty) && !(sinifIDText.Text == string.Empty) && !(AktiviteIDText.Text == string.Empty) && !(ekleyenKullaniciAdiText.Text == string.Empty)
              && !(siraEkleText.Text == string.Empty) && !(eklenmeTarihiText.Text == string.Empty) && !(alanIDText.Text == string.Empty) && !(MudaheleIDText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO IlaveMudahaleDetay (AlanID, SinifID, MudaheleID, ProblemID, AktiviteID, Sira, EkleyenKullaniciAdi, EklenmeTarihi) " +
                        "Values (@alanID, @sinifID, @mudaheleID, @problemID, @aktiviteID, @sira, @ekleyenKullaniciAdi,  @eklenmeTarihi);";
                    IlaveMudaheleDetay ilaveMudaheleDetay = new IlaveMudaheleDetay
                    {
                        alanID = alanIDText.Text,
                        sinifID = sinifIDText.Text,
                        mudaheleID = MudaheleIDText.Text,
                        sira= Int16.Parse(siraEkleText.Text),
                        aktiviteID = AktiviteIDText.Text,
                        problemID = problemIDText.Text,
                        ekleyenKullaniciAdi = ekleyenKullaniciAdiText.Text,
                        eklenmeTarihi= Convert.ToDateTime(eklenmeTarihiText.Text),


                    };
                    connection.Execute(sql, ilaveMudaheleDetay);
                    this.Hide();
                    MudurPage f1 = new MudurPage();
                    f1.ShowDialog();
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri  giriniz.", "Ilave Mudahele Detay page");
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
