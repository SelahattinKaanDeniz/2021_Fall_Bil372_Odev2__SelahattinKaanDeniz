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
    public partial class CiktiEklemeSayfasi : Form
    {
        public CiktiEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(alanIDText.Text == string.Empty) && !(sinifIDText.Text == string.Empty) && !(ciktiIDText.Text == string.Empty) && !(ciktiAdiText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {



                    string sql = "INSERT INTO Cikti (AlanID, SinifID, CiktiID, CiktiAdi) Values (@alanID, @sinifID, @ciktiID , @ciktiAdi);";

                    Cikti cikti = new Cikti { alanID = alanIDText.Text, sinifID = sinifIDText.Text, ciktiID = ciktiIDText.Text, ciktiAdi = ciktiAdiText.Text };
                    connection.Execute(sql, cikti);

                    this.Hide();
                    AdminPage f1 = new AdminPage();
                    f1.ShowDialog();

                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Cikti page");
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
