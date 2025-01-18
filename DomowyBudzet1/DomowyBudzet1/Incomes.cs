using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowyBudzet1
{
    public partial class Incomes : FinancialDataForm
    {
        public Incomes()
        {
            InitializeComponent();
            ShowData(IncomeList);
        }

        protected override string TableName => "IncomeTbl";
        protected override string IdColumnName => "IncId";
        protected override string NameColumnName => "IncName";
        protected override string AmountColumnName => "IncAmt";
        protected override string CategoryColumnName => "IncCat";
        protected override string DateColumnName => "IncDate";
        protected override string DescriptionColumnName => "IncDesc";

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmtTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Proszę wpisać informacje we wszystkich polach.");
            }
            else
            {
                AddData(NameTb.Text, Convert.ToInt32(AmtTb.Text), CatTb.Text, DateTb.Value.Date, DescTb.Text);
                ShowData(IncomeList);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmtTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Proszę wpisać informacje we wszystkich polach.");
            }
            else
            {
                EditData(key, NameTb.Text, Convert.ToInt32(AmtTb.Text), CatTb.Text, DateTb.Value.Date, DescTb.Text);
                ShowData(IncomeList);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Wybierz poprawny wpis do usunięcia.");
            }
            else
            {
                DeleteData(key);
                ShowData(IncomeList);
            }
        }

        private void IncomeList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            OnCellContentClick(IncomeList, e, NameTb, AmtTb, CatTb, DateTb, DescTb, ref key);
        }

        int key = 0;


        private void IncomeBtn_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void ExpenseBtn_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}