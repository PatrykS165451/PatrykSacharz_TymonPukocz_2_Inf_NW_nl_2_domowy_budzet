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
        private readonly BaseFormHelper helper;

        public Dashboard()
        {
            InitializeComponent();
            helper = new BaseFormHelper();
            SumExpenses();
            SumIncomes();
            CountExpenses();
            CountIncomes();
            CountTotal();
        }

        private void SumExpenses()
        {
            string query = "select sum(ExpAmt) from ExpenseTbl";
            helper.SumData(query, ExpSum, "zł");
        }

        private void SumIncomes()
        {
            string query = "select sum(IncAmt) from IncomeTbl";
            helper.SumData(query, IncSum, "zł");
        }

        private void CountExpenses()
        {
            string query = "select count(*) from ExpenseTbl";
            helper.CountData(query, ExpCount, "Łączna ilość wydatków: ");
        }

        private void CountIncomes()
        {
            string query = "select count(*) from IncomeTbl";
            helper.CountData(query, IncCount, "Łączna ilość przychodów: ");
        }

        private void CountTotal()
        {
            try
            {
                decimal totalIncome = helper.GetSum("select sum(IncAmt) from IncomeTbl");
                decimal totalExpense = helper.GetSum("select sum(ExpAmt) from ExpenseTbl");
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
