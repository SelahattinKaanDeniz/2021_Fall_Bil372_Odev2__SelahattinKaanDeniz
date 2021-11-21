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
    public partial class MudurPage : Form
    {
        public MudurPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProblemMudaheleEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProblemMudaheleEklemeSayfasi f1 = new ProblemMudaheleEklemeSayfasi();
            f1.ShowDialog();
        }
        private void ProblemCiktiEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProblemCiktiEklemeSayfasi f1 = new ProblemCiktiEklemeSayfasi();
            f1.ShowDialog();
        }

        private void IlaveMudaheleDetayEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IlaveMudaheleDetayEkleSayfasi f1 = new IlaveMudaheleDetayEkleSayfasi();
            f1.ShowDialog();
        }

        private void IlaveCiktiDetayEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            IlaveCiktiDetayEklemeSayfasi f1 = new IlaveCiktiDetayEklemeSayfasi();
            f1.ShowDialog();
        }

        private void PersonelProblemEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelProblemSayfasi f1 = new PersonelProblemSayfasi();
            f1.ShowDialog();
        }

        private void ProblemCiktiDegerlendirmeEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProblemCiktiDegerlendirmeSayfasi f1 = new ProblemCiktiDegerlendirmeSayfasi();
            f1.ShowDialog();
        }

        private void ProblemDurumDegerlendirmesiEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProblemDurumDegerlendirmeSayfasi f1 = new ProblemDurumDegerlendirmeSayfasi();
            f1.ShowDialog();
        }

        private void CalisanProblemEkleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalisanProblemSayfasi f1 = new CalisanProblemSayfasi();
            f1.ShowDialog();
        }

        private void CalisanProblemListeleButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Environment.Exit(0);
        }
    }
}
