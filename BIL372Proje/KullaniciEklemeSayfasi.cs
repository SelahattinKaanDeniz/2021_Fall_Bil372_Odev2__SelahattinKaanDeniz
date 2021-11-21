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
    public partial class KullaniciEklemeSayfasi : Form
    {
        public KullaniciEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(kullaniciAdiText.Text == string.Empty) && !(sifreText.Text == string.Empty) )
            {
                bool flag1 = false;
                bool flag2 = false;
                bool flag3 = false;
                /*  ^(?=.*[A - Z])(?=.*[.!(){ }
                  []:;,?/-]).{ 8,}$*/
                string specialChar = @"!/()?.-;',";
                foreach (var item in specialChar)
                {
                    if (sifreText.Text.Contains(item))
                        flag3 = true;
                }
                if (sifreText.Text.Length >= 8)
                {
                    flag2 = true;
                }
                for (int i = 0; i< sifreText.Text.Length;i++)
                {
                    if (Char.IsUpper(sifreText.Text[i]))
                        flag1 = true;
                    
                }
                if (flag1 == true && flag2 == true && flag3 == true)
                {

                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                    {

                        string sql = "INSERT INTO Kullanicilar (KullaniciAdi, Sifre) Values (@kullaniciadi, @sifre);";
                        String Password = AESEncrypt.Encrypt(sifreText.Text);
                        Kullanicilar kullanici = new Kullanicilar { kullaniciadi = kullaniciAdiText.Text, sifre = Password };
                        connection.Execute(sql, kullanici);

                        this.Hide();
                        AdminPage f1 = new AdminPage();
                        f1.ShowDialog();

                    }
                }
                else {

                    MessageBox.Show("Şifre en az 8 karakter uzunluğunda, en az bir büyük harf ve en az bir noktalama işareti içermeli.", "Kullanici page");
                }

            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Cikti Detay page");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage f1 = new AdminPage();
            f1.ShowDialog();
        }
    }
}
