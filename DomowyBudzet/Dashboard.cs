using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyBudzet
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wyloguj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wyjść?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Category_Button_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            Hide();
        }

        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            DashboardForm DashboardForm = new DashboardForm();
            DashboardForm.Show();
            Hide();
        }

        private void Expense_Button_Click(object sender, EventArgs e)
        {
            //ExpenseForm expenseForm = new ExpenseForm();
            //expenseForm.Show();
           // Hide();
        }

        private void Income_Button_Click(object sender, EventArgs e)
        {
           // IncomeForm incomeForm = new IncomeForm();
           // incomeForm.Show();
           // Hide();
        }
    }
}
