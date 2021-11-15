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
    public partial class PersonelEklemeSayfasi : Form
    {
        public PersonelEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            if (!(KullaniciAdiText.Text == string.Empty) && !(AdText.Text == string.Empty) && !(SoyadText.Text == string.Empty)
               && !(IlKoduText.Text == string.Empty) && !(EvAdresiText.Text == string.Empty) && !(IlceKoduText.Text == string.Empty) && !(PostKoduText.Text == string.Empty)
               && !(EmailText.Text == string.Empty)  && !(CalistigiBirimKoduText.Text == string.Empty) && !(CepText.Text == string.Empty) && !(SicilNoText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO Personel (KullaniciAdi, Email, Ad, Soyad, SicilNo, Cep, EvAdresi, IlKodu, IlceKodu,PostaKodu,UstKullaniciAdi,CalistigiBirimKodu) " +
                        "Values (@kullaniciadi, @Email, @ad , @soyad, @sicilNo, @cep, @evAdresi, @ilKodu, @ilceKodu, @postaKodu, @ustKullaniciAdi, @calistigiBirimKodu);";
                    Personel personel = new Personel
                    {
                        kullaniciadi = KullaniciAdiText.Text,
                        Email = EmailText.Text,
                        ad = AdText.Text,
                        soyad = SoyadText.Text,
                        sicilNo = SicilNoText.Text,
                        cep = CepText.Text,
                        evAdresi = EvAdresiText.Text,
                        ilKodu = IlKoduText.Text,
                        ilceKodu = IlceKoduText.Text,
                        postaKodu = PostKoduText.Text,
                        ustKullaniciAdi = UstKullaniciAdiText.Text,
                        calistigiBirimKodu= CalistigiBirimKoduText.Text
                    };
                    connection.Execute(sql, personel);
                    this.Hide();
                    AdminPage f1 = new AdminPage();
                    f1.ShowDialog();
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Personel page");
            }
        }

        private void PersonelCikisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage f1 = new AdminPage();
            f1.ShowDialog();
        }
    }

  
    }

