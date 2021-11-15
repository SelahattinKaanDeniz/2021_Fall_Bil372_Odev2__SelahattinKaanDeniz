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
    public partial class BirimEklemeSayfasi : Form
    {
        public BirimEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirimEklemeSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(BirimKoduText.Text == string.Empty) && !(BirimAdıText.Text == string.Empty) && !(BirimMudurKullaniciAdiText.Text == string.Empty)
               && !(IlKoduText.Text == string.Empty) && !(BulunduguAdresText.Text == string.Empty) && !(IlceKoduText.Text == string.Empty) && !(PostaKoduText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO Birimler (BirimKodu, BirimAdi, UstBirimKodu, BulunduguAdres, IlKodu, IlceKodu, PostaKodu, BirimMudurKullaniciAdi) Values (@birimKodu, @birimAdi, @ustBirimKodu , @bulunduguAdres, @ilKodu, @ilceKodu, @postaKodu, @birimMudurKullaniciAdi);";
                    Birim birim = new Birim { birimKodu = BirimKoduText.Text, birimAdi = BirimAdıText.Text, ustBirimKodu = UstBirimKoduText.Text 
                    , bulunduguAdres= BulunduguAdresText.Text, ilKodu= IlKoduText.Text, ilceKodu=IlceKoduText.Text, postaKodu=PostaKoduText.Text,
                    birimMudurKullaniciAdi=BirimMudurKullaniciAdiText.Text};
                    connection.Execute(sql, birim);
                    this.Hide();
                    AdminPage f1 = new AdminPage();
                    f1.ShowDialog();
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "ilce page");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
