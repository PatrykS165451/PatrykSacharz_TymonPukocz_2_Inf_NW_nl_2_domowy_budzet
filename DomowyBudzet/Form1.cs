using System.Data;
using Microsoft.Data.SqlClient;

namespace DomowyBudzet
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\patry\Documents\wydatki.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_SignUp_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
            Hide();
        }


        //Metoda odpowiadaj¹ca za zalogowanie u¿ytkownika
        private void login_Button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                string selectData = "SELECT * FROM Users WHERE username = @usern AND password = @pass";

                using(SqlCommand command = new SqlCommand(selectData, connect))
                {
                    command.Parameters.AddWithValue("@usern", login_UserName.Text.Trim());
                    command.Parameters.AddWithValue("@pass", login_Password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if(table.Rows.Count > 0)
                    {
                        MessageBox.Show("Zalogowano pomyœlnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Niepoprawne dane logowania!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_Password.PasswordChar = (login_showPass.Checked) ? '\0' : '*';
        }
    }
}
