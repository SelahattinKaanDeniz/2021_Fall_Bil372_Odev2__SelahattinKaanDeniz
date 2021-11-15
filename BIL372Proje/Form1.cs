using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIL372Proje
{
    public partial class Form1 : Form
    {
        List<Kullanicilar> kullanicilar;
        public Form1()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = kullanicilar;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            kullanicilar = db.GetKullanicilar(lastNameText.Text);
            UpdateBinding();
        }
    }
}
