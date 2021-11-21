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
    public partial class ProblemCiktiEklemeSayfasi : Form
    {
        public ProblemCiktiEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(alanIDEkleText.Text == string.Empty) && !(sinifIDEkleText.Text == string.Empty) && !(ciktiIDEkleText.Text == string.Empty)
               && !(problemIDEkleText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO ProblemCikti (AlanID, SinifID, CiktiID, ProblemID) " +
                        "Values (@alanID, @sinifID, @ciktiID, @problemID);";
                    ProblemCikti problemCikti = new ProblemCikti
                    {
                        alanID = alanIDEkleText.Text,
                        sinifID = sinifIDEkleText.Text,
                        ciktiID = ciktiIDEkleText.Text,
                        problemID = problemIDEkleText.Text


                    };
                    connection.Execute(sql, problemCikti);
                    this.Hide();
                    MudurPage f1 = new MudurPage();
                    f1.ShowDialog();
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Problem Cikti page");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MudurPage f1 = new MudurPage();
            f1.ShowDialog();
        }
    }
}
