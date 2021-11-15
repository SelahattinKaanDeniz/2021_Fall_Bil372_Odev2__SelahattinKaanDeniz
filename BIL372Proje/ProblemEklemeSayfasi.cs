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
    public partial class ProblemEklemeSayfasi : Form
    {
        public ProblemEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProblemEkleButton_Click(object sender, EventArgs e)
        {

            if (!(ProblemTanimiText.Text == string.Empty) && !(ProblemTanimlayanTCNOText.Text == string.Empty) && !(ProblemTanimlayiciAdiText.Text == string.Empty)
               && !(ProblemTanimlayiciSoyadiText.Text == string.Empty) && !(ProblemTipiIDText.Text == string.Empty) && !(HedeflenenAmacTanimiText.Text == string.Empty)) { 

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO Problem (ProblemTipiId, ProblemTanimi, ProblemiTanimlayiciAdi, ProblemiTanimlayiciSoyadi, ProblemiTanimlayanTCNOPasaportno, HedeflenenAmacTanimi) " +
                        "Values (@problemTipiID, @problemTanimi, @problemTanimlayiciAdi , @problemTanimlayiciSoyadi, @problemTanimlayanTCNOPasaportNo, @hedeflenenAmacTanimi);";
                    Problem problem = new Problem
                    {
                        problemTanimi = ProblemTanimiText.Text,
                        problemTanimlayanTCNOPasaportNo = ProblemTanimlayanTCNOText.Text,
                        problemTanimlayiciAdi = ProblemTanimlayiciAdiText.Text,
                        problemTanimlayiciSoyadi = ProblemTanimlayiciSoyadiText.Text,
                        problemTipiID = ProblemTipiIDText.Text,
                        hedeflenenAmacTanimi = HedeflenenAmacTanimiText.Text,
                        
                    };
                    connection.Execute(sql, problem);
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

        private void ProblemCikisButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage f1 = new AdminPage();
            f1.ShowDialog();
        }
    }
}
