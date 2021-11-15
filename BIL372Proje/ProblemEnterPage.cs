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
    public partial class ProblemEnterPage : Form
    {
        public ProblemEnterPage()
        {
            InitializeComponent();
        }

        private void ProblemEkleButton_Click(object sender, EventArgs e)
        {
            if (!(problemTanimiText.Text == string.Empty) && !(problemTanimlayanTCNOText.Text == string.Empty) && !(problemTanimlayiciAdiText.Text == string.Empty)
               && !(ProblemTanimlayiciSoyadiText.Text == string.Empty) && !(ProblemTipiIDText.Text == string.Empty) && !(hedeflenenAmacTanimiText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO Problem (ProblemTipiId, ProblemTanimi, ProblemiTanimlayiciAdi, ProblemiTanimlayiciSoyadi, ProblemiTanimlayanTCNOPasaportno, HedeflenenAmacTanimi) " +
                        "Values (@problemTipiID, @problemTanimi, @problemTanimlayiciAdi , @problemTanimlayiciSoyadi, @problemTanimlayanTCNOPasaportNo, @hedeflenenAmacTanimi);";
                    Problem problem = new Problem
                    {
                        problemTanimi = problemTanimiText.Text,
                        problemTanimlayanTCNOPasaportNo = problemTanimlayanTCNOText.Text,
                        problemTanimlayiciAdi = problemTanimlayiciAdiText.Text,
                        problemTanimlayiciSoyadi = ProblemTanimlayiciSoyadiText.Text,
                        problemTipiID = ProblemTipiIDText.Text,
                        hedeflenenAmacTanimi = hedeflenenAmacTanimiText.Text,

                    };
                    connection.Execute(sql, problem);
                    this.Hide();
                    AdminPage f1 = new AdminPage();
                    f1.ShowDialog();
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Problem Enter page");
            }
        }

        private void ProblemCikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }
    }
}
