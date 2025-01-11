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

namespace DomowyBudzet
{
    public partial class IncomeForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\patry\Documents\wydatki.mdf;Integrated Security=True;Connect Timeout=30";

        public IncomeForm()
        {
            InitializeComponent();

            displayCategoryList();
        }

        public void displayCategoryList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT category FROM categories WHERE type = @type";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");

                    Income_Category.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while(reader.Read())
                    {
                        Income_Category.Items.Add(reader["category"].ToString());
                    }
                }

                connect.Close();
            }

            //02:02:39
        }
        private void Income_AddBtn_Click(object sender, EventArgs e)
        {
            if (Income_Category.SelectedIndex == -1 || Income_Item.Text == "" || Income_Income.Text == "" || Income_Desc.Text == "")
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO income (category, item, income, description, date_income, date)" + "VALUES(@cat, @item, @income, @desc, @date_in, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", Income_Category.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", Income_Item.Text);
                        cmd.Parameters.AddWithValue("@income", Income_Income.Text);
                        cmd.Parameters.AddWithValue("@desc", Income_Desc.Text);
                        cmd.Parameters.AddWithValue("@date_in", Income_Date.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Dochód dodany pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();    
                }
            }
        }
    }
}
