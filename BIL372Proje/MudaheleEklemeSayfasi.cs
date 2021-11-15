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
    public partial class MudaheleEklemeSayfasi : Form
    {
        public MudaheleEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(SinifIDText.Text == string.Empty) && !(AlanIDText.Text == string.Empty) && !(MudaheleIDText.Text == string.Empty) && !(MudaheleAdiText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {
                    
                    
                      
                        string sql = "INSERT INTO Mudahele (AlanID, SinifID, MudaheleID, MudaheleAdi) Values (@alanID, @sinifID, @mudaheleID , @mudaheleAdi);";
                        
                        Mudahele mudahele = new Mudahele { alanID = AlanIDText.Text, sinifID = SinifIDText.Text, mudaheleID = MudaheleIDText.Text, mudaheleAdi= MudaheleAdiText.Text };
                        connection.Execute(sql, mudahele);

                        this.Hide();
                        AdminPage f1 = new AdminPage();
                        f1.ShowDialog();
                   
                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Mudahele page");
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
