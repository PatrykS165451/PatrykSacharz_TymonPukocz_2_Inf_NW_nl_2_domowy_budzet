using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowyBudzet1
{
    public class FinancialSummary : IFinancialSummary
    {
        private Functions _con;

        public FinancialSummary()
        {
            _con = new Functions();  // Inicjalizacja klasy pomocniczej Functions
        }

        public string GetTotalExpenses()
        {
            try
            {
                string query = "select sum(ExpAmt) from ExpenseTbl";
                DataTable dt = _con.GetData(query);  // Pobieranie danych z bazy danych
                return dt.Rows.Count > 0 ? dt.Rows[0][0].ToString() + " zł" : "0 zł";
            }
            catch (Exception ex)
            {
                throw new Exception("Błąd podczas pobierania danych wydatków: " + ex.Message);
            }
        }

        public string GetTotalIncomes()
        {
            try
            {
                string query = "select sum(IncAmt) from IncomeTbl";
                DataTable dt = _con.GetData(query);  // Pobieranie danych z bazy danych
                return dt.Rows.Count > 0 ? dt.Rows[0][0].ToString() + " zł" : "0 zł";
            }
            catch (Exception ex)
            {
                throw new Exception("Błąd podczas pobierania danych przychodów: " + ex.Message);
            }
        }

        public string GetTotalAmount()
        {
            try
            {
                decimal totalIncome = 0;
                string incomeQuery = "select sum(IncAmt) from IncomeTbl";
                DataTable incomeDt = _con.GetData(incomeQuery);
                if (incomeDt.Rows.Count > 0 && incomeDt.Rows[0][0] != DBNull.Value)
                    totalIncome = Convert.ToDecimal(incomeDt.Rows[0][0]);

                decimal totalExpense = 0;
                string expenseQuery = "select sum(ExpAmt) from ExpenseTbl";
                DataTable expenseDt = _con.GetData(expenseQuery);
                if (expenseDt.Rows.Count > 0 && expenseDt.Rows[0][0] != DBNull.Value)
                    totalExpense = Convert.ToDecimal(expenseDt.Rows[0][0]);

                return (totalIncome - totalExpense).ToString() + " zł";
            }
            catch (Exception ex)
            {
                throw new Exception("Błąd podczas obliczania sumy: " + ex.Message);
            }
        }

        public string CountExpenses()
        {
            string query = "select count(*) from ExpenseTbl";
            DataTable dt = _con.GetData(query);
            return dt.Rows.Count > 0 ? "Łączna ilość wydatków: " + dt.Rows[0][0].ToString() : "Łączna ilość wydatków: 0";
        }
        public string CountIncomes()
        {
            string query = "select count(*) from IncomeTbl";
            DataTable dt = _con.GetData(query);
            return dt.Rows.Count > 0 ? "Łączna ilość przychodów: " + dt.Rows[0][0].ToString() : "Łączna ilość przychodów: 0";
        }


    }
}
