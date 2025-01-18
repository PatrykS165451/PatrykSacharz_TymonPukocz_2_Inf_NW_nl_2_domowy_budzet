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
    public abstract class FinancialDataForm : Form
    {
        private Functions Con;

        public FinancialDataForm()
        {
            Con = new Functions();
        }

        protected abstract string TableName { get; }
        protected abstract string IdColumnName { get; }
        protected abstract string NameColumnName { get; }
        protected abstract string AmountColumnName { get; }
        protected abstract string CategoryColumnName { get; }
        protected abstract string DateColumnName { get; }
        protected abstract string DescriptionColumnName { get; }


        protected void ShowData(DataGridView dataGridView)
        {
            try
            {
                string Query = $"select * from {TableName}";
                DataTable dt = Con.GetData(Query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Brak danych do wyœwietlenia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d podczas pobierania danych: " + ex.Message);
            }
        }

        protected void AddData(string name, int amount, string category, DateTime date, string description)
        {
            try
            {
                string formatDate = date.ToString("MM/dd/yyyy");
                string Query = $"insert into {TableName} values('{name}','{amount}','{category}','{formatDate}','{description}')";
                Con.SetData(Query);
                MessageBox.Show("Dodano pomyœlnie.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        protected void EditData(int key, string name, int amount, string category, DateTime date, string description)
        {
            try
            {
                string formatDate = date.ToString("MM/dd/yyyy");
                string Query = $"update {TableName} set {NameColumnName} = '{name}', {AmountColumnName} = '{amount}', {CategoryColumnName} = '{category}', {DateColumnName} = '{formatDate}', {DescriptionColumnName} = '{description}' where {IdColumnName} = '{key}'";
                Con.SetData(Query);
                MessageBox.Show("Zedytowano pomyœlnie.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        protected void DeleteData(int key)
        {
            try
            {
                string Query = $"DELETE FROM {TableName} WHERE {IdColumnName} = {key}";
                Con.SetData(Query);
                MessageBox.Show("Usuniêto pomyœlnie.");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        protected void OnCellContentClick(DataGridView dataGridView, DataGridViewCellEventArgs e, TextBox nameTb, TextBox amtTb, TextBox catTb, DateTimePicker dateTb, TextBox descTb, ref int key)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                nameTb.Text = row.Cells[1].Value.ToString();
                amtTb.Text = row.Cells[2].Value.ToString();
                catTb.Text = row.Cells[3].Value.ToString();
                dateTb.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                descTb.Text = row.Cells[5].Value.ToString();
                key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

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
