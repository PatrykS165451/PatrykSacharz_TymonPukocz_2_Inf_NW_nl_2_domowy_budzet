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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Con = new Functions();
            SumExpenses();
            SumIncomes();
            CountExpenses();
            CountIncomes();
            CountTotal();
        }
        Functions Con;
        private void SumExpenses()
        {
            try
            {
                string Query = "select sum(ExpAmt) from ExpenseTbl";
                DataTable dt = Con.GetData(Query);
                if (dt.Rows.Count > 0)
                {
                    ExpSum.Text = dt.Rows[0][0].ToString() + " zł";
                }
                else
                {
                    ExpSum.Text = "0 zł";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
            }
        }

        private void SumIncomes()
        {
            try
            {
                string Query = "select sum(IncAmt) from IncomeTbl";
                DataTable dt = Con.GetData(Query);
                if (dt.Rows.Count > 0)
                {
                    IncSum.Text = dt.Rows[0][0].ToString() + " zł";
                }
                else
                {
                    IncSum.Text = "0 zł";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
            }
        }

        private void CountExpenses()
        {
            string Query = "select count(*) from ExpenseTbl";
            DataTable dt = Con.GetData(Query);
            if (dt.Rows.Count > 0)
            {
                ExpCount.Text = "Łączna ilość wydatków: " + dt.Rows[0][0].ToString();
            }
            else
            {
                ExpCount.Text = "Łączna ilość wydatków: 0";
            }
        }

        private void CountIncomes()
        {
            string Query = "select count(*) from IncomeTbl";
            DataTable dt = Con.GetData(Query);
            if (dt.Rows.Count > 0)
            {
                IncCount.Text = "Łączna ilość przychodów: " + dt.Rows[0][0].ToString();
            }
            else
            {
                IncCount.Text = "Łączna ilość przychodów: 0";
            }
        }


        /* Inc=sum(IncAmt)
            Exp=sum(ExpAmt)
            res=Inc-Exp
            print res*/

        private void CountTotal()
        {
            try
            {
                // Zapytanie do obliczenia sumy przychodów
                string incomeQuery = "select sum(IncAmt) from IncomeTbl";
                DataTable incomeDt = Con.GetData(incomeQuery);
                decimal totalIncome = 0;
                if (incomeDt.Rows.Count > 0 && incomeDt.Rows[0][0] != DBNull.Value)
                {
                    totalIncome = Convert.ToDecimal(incomeDt.Rows[0][0]);
                }

                // Zapytanie do obliczenia sumy wydatków
                string expenseQuery = "select sum(ExpAmt) from ExpenseTbl";
                DataTable expenseDt = Con.GetData(expenseQuery);
                decimal totalExpense = 0;
                if (expenseDt.Rows.Count > 0 && expenseDt.Rows[0][0] != DBNull.Value)
                {
                    totalExpense = Convert.ToDecimal(expenseDt.Rows[0][0]);
                }

                // Obliczenie różnicy
                decimal totalAmount = totalIncome - totalExpense;
                AmountTotal.Text = totalAmount.ToString() + " zł";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
            }
        }



        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void DashboardBtn_Click_1(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void ExpenseBtn_Click_1(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        private void IncomeBtn_Click_1(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }
    }
}
