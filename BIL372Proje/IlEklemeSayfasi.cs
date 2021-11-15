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
    public partial class IlEklemeSayfasi : Form
    {
        public IlEklemeSayfasi()
        {
            InitializeComponent();
        }

        private void IlEkleButton_Click(object sender, EventArgs e)
        {
            if (!(IlEklemeIlKoduText.Text == string.Empty))
            {
                if (!(IlEklemeIlAdiText.Text == string.Empty))
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                    {


                        string sql = "INSERT INTO Iller (IlKodu, IlAdi) Values (@ilKodu, @ilAdi);";
                        Il il = new Il { ilKodu = IlEklemeIlKoduText.Text, ilAdi = IlEklemeIlAdiText.Text };
                        connection.Execute(sql, il);
                        this.Hide();
                        AdminPage f1 = new AdminPage();  
                        f1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen İl Adını Giriniz.", "il page");
                }
            }
            else
            {
                MessageBox.Show("Lütfen İl Kodunu Giriniz.", "il page");
            }
        }
    }
}
