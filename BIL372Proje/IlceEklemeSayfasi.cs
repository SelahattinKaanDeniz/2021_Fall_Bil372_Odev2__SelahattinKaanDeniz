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
    public partial class IlceEklemeSayfasi : Form
    {
        public IlceEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void IlceEkleButton_Click(object sender, EventArgs e)
        {
            if (!(IlceAdiText.Text == string.Empty) && !(IlceKoduText.Text == string.Empty) && !(IlKoduText.Text == string.Empty))
            {

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                {


                    string sql = "INSERT INTO Ilceler (IlKodu, IlceKodu, IlceAdi) Values (@ilKodu, @ilceKodu, @ilceAdi);";
                    Ilce ilce = new Ilce { ilKodu = IlKoduText.Text, ilceAdi = IlceAdiText.Text, ilceKodu = IlceKoduText.Text };
                    connection.Execute(sql, ilce);
                    this.Hide();
                    AdminPage f1 = new AdminPage(); 
                    f1.ShowDialog();
                }
            }

        
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.", "ilce page");
            }
        }
    }
    }

