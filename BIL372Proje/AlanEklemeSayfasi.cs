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
    public partial class AlanEklemeSayfasi : Form
    {
        public AlanEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void AlanEkleButton_Click(object sender, EventArgs e)
        {
            if (!(AlanIDText.Text == string.Empty) && !(AlanAdiText.Text == string.Empty) && !(AlanTipiText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {
                    if (AlanTipiText.Text == "0" || AlanTipiText.Text == "1")
                    {
                        bool abc;
                        string sql = "INSERT INTO Alanlar (AlanID, AlanAdi, AlanTipi) Values (@alanID, @alanAdi, @alanTipi);";
                        if (AlanTipiText.Text == "0")
                        {
                            abc = false;
                        }
                        else
                        {
                            abc = true;
                        }
                        Alan alan = new Alan { alanID = AlanIDText.Text, alanAdi = AlanAdiText.Text, alanTipi = abc };
                        connection.Execute(sql, alan);

                        this.Hide();
                        AdminPage f1 = new AdminPage();
                        f1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Alan Tipini formata uygun giriniz.", "Alan page");
                    }
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Alan page");
            }
        }

        private void AlanCikisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage f1 = new AdminPage();
            f1.ShowDialog();
        }
    }
}
