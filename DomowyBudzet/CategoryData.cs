using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

//Klasa CategoryData odpowiada za dodanie kategorii do bazy danych

namespace DomowyBudzet
{
    internal class CategoryData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\patry\Documents\wydatki.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }

        //poniższa metoda łączy się z bazą danych i dodaje do niej nową kategorię (nazwa, typ, data dodania)
        public List<CategoryData> GetCategories()
        {
            List<CategoryData> categories = new List<CategoryData>();
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM categories";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoryData category = new CategoryData();
                            category.ID = reader.GetInt32(0);
                            category.Category = reader.GetString(1);
                            category.Type = reader.GetString(2);
                            category.Date = reader.GetDateTime(3).ToShortDateString();
                            categories.Add(category);
                        }
                    }
                }
            }
            return categories;
        }
    }
}
