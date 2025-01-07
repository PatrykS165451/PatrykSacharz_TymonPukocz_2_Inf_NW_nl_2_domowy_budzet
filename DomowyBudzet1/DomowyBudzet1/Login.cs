using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyBudzet1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Wprowadź nazwę użytkownika i hasło.");
            }
            else if (UsernameTb.Text == "admin" && PasswordTb.Text == "admin")
            {
                Incomes Obj = new Incomes();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lub hasło.");
            }
        }
    }
}
