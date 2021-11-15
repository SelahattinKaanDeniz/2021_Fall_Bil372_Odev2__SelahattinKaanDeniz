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
    public partial class AktiviteEklemeSayfasi : Form
    {
        public AktiviteEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(AktiviteIDText.Text == string.Empty) && !(AktiviteTanimiText.Text == string.Empty) )
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {



                    string sql = "INSERT INTO Aktiviteler (AktiviteID, AktiviteTanimi) Values (@aktiviteID, @aktiviteTanimi );";

                    Aktivite aktivite = new Aktivite { aktiviteID = AktiviteIDText.Text, aktiviteTanimi = AktiviteTanimiText.Text };
                    connection.Execute(sql, aktivite);

                    this.Hide();
                    AdminPage f1 = new AdminPage();
                    f1.ShowDialog();

                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Aktivite page");
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
