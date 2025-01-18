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
        private IFinancialSummary _financialSummary;  // Deklaracja zmiennej typu interfejsu

        public Dashboard()
        {
            InitializeComponent();
            _financialSummary = new FinancialSummary();  // Używamy interfejsu, a nie konkretnej klasy
            LoadFinancialData();  // Ładowanie danych do interfejsu użytkownika
        }

        private void LoadFinancialData()
        {
            // Używamy metod interfejsu do uzyskania danych
            ExpSum.Text = _financialSummary.GetTotalExpenses();
            IncSum.Text = _financialSummary.GetTotalIncomes();
            AmountTotal.Text = _financialSummary.GetTotalAmount();
            ExpCount.Text = _financialSummary.CountExpenses();
            IncCount.Text = _financialSummary.CountIncomes();
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