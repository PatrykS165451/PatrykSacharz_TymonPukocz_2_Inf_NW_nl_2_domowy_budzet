﻿using System;
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
                    ExpSum.Text = "Łączna suma wydatków: " + dt.Rows[0][0].ToString() + " zł";
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
                    IncSum.Text = "Łączna suma przychodów: " + dt.Rows[0][0].ToString() + " zł";
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
