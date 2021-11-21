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
    public partial class PersonelProblemSayfasi : Form
    {
        public PersonelProblemSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(KullanıcıAdıText.Text == string.Empty) && !(ProblemIDText.Text == string.Empty) )
              
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {

                    string sql = "INSERT INTO PersonelProblem (ProblemID, KullaniciAdi) Values (@problemID, @kullaniciAdi);";

                    PersonelProblem personelProblem = new PersonelProblem { kullaniciAdi = KullanıcıAdıText.Text, problemID = ProblemIDText.Text };
                    connection.Execute(sql, personelProblem);

                    this.Hide();
                    MudurPage f1 = new MudurPage();
                    f1.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri  giriniz.", "Personel Problem page");
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
