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
    public partial class CiktiDetayEklemeSayfasi : Form
    {
        public CiktiDetayEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CiktiDetayEklemeSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(belirtecIDText.Text == string.Empty) && !(siraText.Text == string.Empty) && !(alanIDText.Text == string.Empty)
               && !(sinifIDText.Text == string.Empty) && !(ciktiIDText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {



                    string sql = "INSERT INTO CiktiDetay (AlanID, SinifID, CiktiID, BelirtecID, Sira) Values (@alanID, @sinifID, @ciktiID,  @belirtecID, @sira);";

                    CiktiDetay ciktidetay = new CiktiDetay { alanID = alanIDText.Text, sinifID = sinifIDText.Text, ciktiID = ciktiIDText.Text, belirtecID = belirtecIDText.Text, sira = Int16.Parse(siraText.Text) };
                    connection.Execute(sql, ciktidetay);

                    this.Hide();
                    AdminPage f1 = new AdminPage();
                    f1.ShowDialog();

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
