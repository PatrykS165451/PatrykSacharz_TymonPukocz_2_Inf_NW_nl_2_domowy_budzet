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
    public partial class CategoryForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\patry\Documents\wydatki.mdf;Integrated Security=True;Connect Timeout=30";
        public CategoryForm()
        {
            InitializeComponent();

            //displayCategories();
        }

        //Mam problem z poniższą metodą, po zalogowaniu się wypluwa problem z SQLem. 1:20:00

        public void displayCategories()
        {
            CategoryData categoryData = new CategoryData();
            List<CategoryData> categories = categoryData.GetCategories();
            Category_GridView.DataSource = categories;
        }

        private void Category_AddBtn_Click(object sender, EventArgs e)
        {
            if (Category_TxtBox.Text == "" || Category_CmbBox.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();
                    string insertData = "INSERT INTO categories (category, type, date_insert) " + "VALUES(@cat, @type, @date)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {

                        cmd.Parameters.AddWithValue("@cat", Category_TxtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", Category_CmbBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        //exception, do naprawienia.
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Kategoria dodana pomyślnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                displayCategories();
            }
        }

        private void Category_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private int getID = 0;

        private void Category_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Category_GridView.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells["id"].Value.ToString());
                Category_TxtBox.Text = row.Cells["category"].Value.ToString();
                Category_CmbBox.SelectedItem = row.Cells["type"].Value.ToString();
            }
        }

        private void Category_EdtBtn_Click(object sender, EventArgs e)
        {
            if (Category_TxtBox.Text == "" || Category_CmbBox.SelectedIndex == -1)
            {
                MessageBox.Show("Proszę wybrać kategorię.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Czy na pewno chcesz edytować kategorię o nr: " + getID + "?", "Edytuj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();
                        string updateData = "UPDATE categories SET category = @cat, type = @type WHERE id = @id";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("id", getID);
                            cmd.Parameters.AddWithValue("@cat", Category_TxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", Category_CmbBox.Text.Trim());

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Edycja zakończona sukcesem.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connect.Close();
                    }
                }
            }
            displayCategories();
        }
    }
}
