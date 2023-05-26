using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CRUD_MYSQL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_password.Text))
            {
                try
                {
                    Action.Login(connection.SQL_login, txt_username.Text, txt_password.Text);

                    if (connection.Session == true)
                    {
                        connection.Tes.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Tolong Isi Semua Kolom");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
