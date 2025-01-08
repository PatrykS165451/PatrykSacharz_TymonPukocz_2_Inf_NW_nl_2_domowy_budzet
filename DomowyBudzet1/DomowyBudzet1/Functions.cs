using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DomowyBudzet1
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;
        //Konstruktor klasy Functions
        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\patry\Documents\wydatkiDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        //Metoda pobierająca dane z bazy danych
        public DataTable GetData(string Query)
        {
            try
            {
                Con.Open();
                Cmd = new SqlCommand(Query, Con);
                Sda = new SqlDataAdapter(Cmd);
                dt = new DataTable();
                Sda.Fill(dt);
                Con.Close();
                return dt;
            }
            //Obsługa błędów
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                return null;
            }
        }

        //Metoda ustawiająca dane w bazie danych
        public int SetData(string Query)
        {
            int Cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }
    }
}
