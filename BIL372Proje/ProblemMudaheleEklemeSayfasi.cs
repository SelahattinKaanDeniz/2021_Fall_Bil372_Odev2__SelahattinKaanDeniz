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
    public partial class ProblemMudaheleEklemeSayfasi : Form
    {
        public ProblemMudaheleEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(problemMudaheleAlanIDEkleText.Text == string.Empty) && !(problemMudaheleSinifIDEkleText.Text == string.Empty) && !(problemMudaheleMudaheleIDEkleText.Text == string.Empty)
               && !(problemMudaheleProblemIDEkleText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO ProblemMudahele (AlanID, SinifID, MudaheleID, ProblemID) " +
                        "Values (@alanID, @sinifID, @mudaheleID, @problemID);";
                    ProblemMudahele problemMudahele = new ProblemMudahele
                    {
                        alanID = problemMudaheleAlanIDEkleText.Text,
                        sinifID = problemMudaheleSinifIDEkleText.Text,
                        mudaheleID = problemMudaheleMudaheleIDEkleText.Text,
                        problemID = problemMudaheleProblemIDEkleText.Text


                    };
                    connection.Execute(sql, problemMudahele);
                    this.Hide();
                    MudurPage f1 = new MudurPage();
                    f1.ShowDialog();
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Problem Mudahele page");
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
    

