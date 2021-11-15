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
    public partial class ProblemBirimEkleSayfasi : Form
    {
        public ProblemBirimEkleSayfasi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(problemIDText.Text == string.Empty) && !(birimIDText.Text == string.Empty) && !(eslesmeTarihiText.Text == string.Empty))
            {
          

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {



                    string sql = "INSERT INTO ProblemBirim (ProblemID, BirimID, EslesmeTarihi) Values (@problemID, @birimID, @eslesmeTarihi);";

                    ProblemBirim problembirim = new ProblemBirim { problemID = problemIDText.Text, birimID = birimIDText.Text, eslesmeTarihi = Convert.ToDateTime(eslesmeTarihiText.Text) };
                    connection.Execute(sql, problembirim);

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
