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
    public partial class SinifEklemeSayfasi : Form
    {
        public SinifEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void SinifEkleButton_Click(object sender, EventArgs e)
        {
            if (!(SinifIDText.Text == string.Empty) && !(SinifAdiText.Text == string.Empty) && !(AlanTipiText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {
                    if (AlanTipiText.Text == "0" || AlanTipiText.Text == "1")
                    {
                        bool abc;
                        string sql = "INSERT INTO Siniflar (SinifID, SinifAdi, AlanTipi) Values (@sinifID, @sinifAdi, @alanTipi);";
                        if (AlanTipiText.Text == "0")
                        {
                            abc = false;
                        }
                        else
                        {
                            abc = true;
                        }
                        Sinif sinif = new Sinif { sinifID = SinifIDText.Text, sinifAdi = SinifAdiText.Text, alanTipi = abc };
                        connection.Execute(sql, sinif);

                        this.Hide();
                        AdminPage f1 = new AdminPage();
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Alan Tipini formata uygun giriniz.", "Sinif page");
                    }
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Sinif page");
            }
        }

        private void SinifCikisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage f1 = new AdminPage();
            f1.ShowDialog();
        }
    }
}
