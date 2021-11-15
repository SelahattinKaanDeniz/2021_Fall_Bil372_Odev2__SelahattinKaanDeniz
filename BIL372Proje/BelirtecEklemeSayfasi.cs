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
    public partial class BelirtecEklemeSayfasi : Form
    {
        public BelirtecEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(belirtecIDText.Text == string.Empty) && !(belirtecTanimiText.Text == string.Empty) )
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {



                    string sql = "INSERT INTO Belirtecler (BelirtecID, BelirtecTanimi) Values (@belirtecID, @belirtecTanimi);";

                    Belirtec belirtec = new Belirtec { belirtecID = belirtecIDText.Text, belirtecTanimi = belirtecTanimiText.Text };
                    connection.Execute(sql, belirtec);

                    this.Hide();
                    AdminPage f1 = new AdminPage();
                    f1.ShowDialog();

                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Belirtec page");
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
