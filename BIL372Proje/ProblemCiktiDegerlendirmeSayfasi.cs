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
    public partial class ProblemCiktiDegerlendirmeSayfasi : Form
    {
        public ProblemCiktiDegerlendirmeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(problemIDText.Text == string.Empty) && !(belirtecIDText.Text == string.Empty)
                && !(skorTarihiText.Text == string.Empty))

            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {

                    string sql = "INSERT INTO ProblemCiktiDegerlendirme (ProblemID, BelirtecID, Skor, SkorTarihi) Values (@problemID, @belirtecID, @skor, @skorTarihi);";
                    ProblemCiktiDegerlendirme problemCiktiDegerlendirme = new ProblemCiktiDegerlendirme { 
                        skor= Int16.Parse(skorText.Text),
                        belirtecID = belirtecIDText.Text, 
                        problemID = problemIDText.Text ,
                       skorTarihi= Convert.ToDateTime(skorTarihiText.Text)
                    };
                        

                    connection.Execute(sql, problemCiktiDegerlendirme);

                    this.Hide();
                    MudurPage f1 = new MudurPage();
                    f1.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri  giriniz.", "Problem Cikti Degerlendirme  page");
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
