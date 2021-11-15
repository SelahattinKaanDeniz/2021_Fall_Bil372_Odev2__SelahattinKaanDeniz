using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIL372Proje
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginSifreText.PasswordChar = '*';
            LoginSifreText.MaxLength = 50;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           ;
            if (!(LoginKullanıciAdiText.Text == string.Empty))
            {
                if (!(LoginSifreText.Text == string.Empty))
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BIL372")))
                    {
                        String Password = AESEncrypt.Encrypt(LoginSifreText.Text);
                        //Console.WriteLine(Password);
                     
                        var output = connection.Query<Kullanicilar>($"select * from Kullanicilar where KullaniciAdi = '" + LoginKullanıciAdiText.Text + "'and Sifre = '" + Password + "'").ToList();
                        if (output.Count == 1)
                        {
                            if (LoginKullanıciAdiText.Text == "KaanDeniz")
                            {
                                this.Hide();
                                AdminPage f1 = new AdminPage(); //this is the change, code for redirect  
                                f1.ShowDialog();
                            }
                            else
                            {
                                this.Hide();
                                ProblemEnterPage f1 = new ProblemEnterPage(); //this is the change, code for redirect  
                                f1.ShowDialog();
                            }
                        }
                        else if(output.Count > 1)
                        {
                            MessageBox.Show("Birden fazla aynı kullanıcı adı ve şifre var.", "login page");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya parola yanlış.", "login page");
                        }
                    }
                    



                }
                else
                {                   
                        MessageBox.Show("Lütfen Parolayı Giriniz.", "login page");
                 
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adını Giriniz.", "login page");

            }
        }
    }
}
