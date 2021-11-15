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
    public partial class MudaheleDetayEklemeSayfasi : Form
    {
        public MudaheleDetayEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(aktiviteIDText.Text == string.Empty) && !(siraText.Text == string.Empty) && !(alanIDText.Text == string.Empty)
                && !(sinifIDText.Text == string.Empty) && !(mudaheleIDText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {



                    string sql = "INSERT INTO MudaheleDetay (AlanID, SinifID, MudaheleID, AktiviteID, Sira) Values (@alanID, @sinifID, @mudaheleID,  @aktiviteID, @sira);";

                    MudaheleDetay mudaheledetay = new MudaheleDetay { alanID = alanIDText.Text, sinifID = sinifIDText.Text , mudaheleID= mudaheleIDText.Text, aktiviteID=aktiviteIDText.Text, sira= Int16.Parse(siraText.Text)};
                    connection.Execute(sql, mudaheledetay);

                    this.Hide();
                    AdminPage f1 = new AdminPage();
                    f1.ShowDialog();

                }
            }


            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "Mudahele Detay page");
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
