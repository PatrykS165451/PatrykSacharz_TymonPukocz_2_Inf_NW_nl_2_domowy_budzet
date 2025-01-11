using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace DomowyBudzet
{
    public partial class SignupForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\patry\Documents\wydatki.mdf;Integrated Security=True;Connect Timeout=30");
        public SignupForm()
        {
            InitializeComponent();
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void signup_Close_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_Password.PasswordChar = (signup_showPass.Checked) ? '\0' : '*';
            signup_PassConfirm.PasswordChar = (signup_showPass.Checked) ? '\0' : '*';
        }

        private void signup_Btn_Click(object sender, EventArgs e)
        {
            if (signup_UserName.Text == "" || signup_Password.Text == "" || signup_PassConfirm.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signup_Password.Text != signup_PassConfirm.Text)
            {
                MessageBox.Show("Hasła nie są takie same!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signup_Password.Text.Length < 8)
            {
                MessageBox.Show("Hasło musi mieć co najmniej 8 znaków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM Users WHERE username = @usern";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", signup_UserName.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {
                                string tempUsern = signup_UserName.Text.Substring(0, 1).ToUpper() + signup_UserName.Text.Substring(1);
                                MessageBox.Show(tempUsern + " już istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Users (username, password, date_create) VALUES (@usern, @pass, @date)";

                                using (SqlCommand insertuser = new SqlCommand(insertData, connect))
                                {
                                    insertuser.Parameters.AddWithValue("@usern", signup_UserName.Text.Trim());
                                    insertuser.Parameters.AddWithValue("@pass", signup_Password.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertuser.Parameters.AddWithValue("@date", DateTime.Now);
                                    insertuser.ExecuteNonQuery();
                                    MessageBox.Show("Rejestracja zakończona pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    connect.Close();
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
