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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void PersonelEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelEklemeSayfasi f1 = new PersonelEklemeSayfasi(); 
            f1.ShowDialog();
        }

        private void IlEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IlEklemeSayfasi f1 = new IlEklemeSayfasi(); 
            f1.ShowDialog();
        }

        private void İlceEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IlceEklemeSayfasi f1 = new IlceEklemeSayfasi(); 
            f1.ShowDialog();
        }

        private void BirimEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BirimEklemeSayfasi f1 = new BirimEklemeSayfasi(); 
            f1.ShowDialog();
        }

        private void ProblemEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProblemEklemeSayfasi f1 = new ProblemEklemeSayfasi();
            f1.ShowDialog();

        }

        private void AlanEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlanEklemeSayfasi f1 = new AlanEklemeSayfasi();
            f1.ShowDialog();
        }

        private void MudaheleDetayEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MudaheleDetayEklemeSayfasi f1 = new MudaheleDetayEklemeSayfasi();
            f1.ShowDialog();
        }

        private void CiktiEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CiktiEklemeSayfasi f1 = new CiktiEklemeSayfasi();
            f1.ShowDialog();
        }

        private void BelirtecEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            BelirtecEklemeSayfasi f1 = new BelirtecEklemeSayfasi();
            f1.ShowDialog();
        }

        private void CiktiDetayEkleButton_Click(object sender, EventArgs e)
        {
              this.Hide();
              CiktiDetayEklemeSayfasi f1 = new CiktiDetayEklemeSayfasi();
              f1.ShowDialog();
        }

        private void ProblemBirimEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProblemBirimEkleSayfasi f1 = new ProblemBirimEkleSayfasi();
            f1.ShowDialog();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }

        private void SinifEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinifEklemeSayfasi f1 = new SinifEklemeSayfasi();
            f1.ShowDialog();
        }

        private void MudaheleEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MudaheleEklemeSayfasi f1 = new MudaheleEklemeSayfasi();
            f1.ShowDialog();
        }

        private void AktiviteEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AktiviteEklemeSayfasi f1 = new AktiviteEklemeSayfasi();
            f1.ShowDialog();
        }

        private void kullaniciEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullaniciEklemeSayfasi f1 = new KullaniciEklemeSayfasi();
            f1.ShowDialog();
        }
    }
}
