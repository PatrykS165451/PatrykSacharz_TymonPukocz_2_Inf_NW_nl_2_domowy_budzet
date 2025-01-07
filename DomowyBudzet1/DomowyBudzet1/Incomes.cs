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
    public partial class Incomes : Form
    {
        Functions Con;
        public Incomes()
        {
            Con = new Functions();
            InitializeComponent();
            ShowIncomes();
        }

        private void ShowIncomes()
        {
            try
            {
                string Query = "select * from IncomeTbl";
                DataTable dt = Con.GetData(Query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    IncomeList.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Brak danych do wyświetlenia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
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


        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmtTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Proszę wpisać informacje we wszystkich polach.");
            }
            else
            {
                try
                {
                    string IName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmtTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "insert into IncomeTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, IName, Amt, Category, DateTb.Value.Date, Description);
                    Con.SetData(Query);
                    MessageBox.Show("Dodano pomyślnie.");
                    ShowIncomes();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;

        private void IncomeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = IncomeList.SelectedRows[0].Cells[1].Value.ToString();
            AmtTb.Text = IncomeList.SelectedRows[0].Cells[2].Value.ToString();
            CatTb.Text = IncomeList.SelectedRows[0].Cells[3].Value.ToString();
            //DateTb.Value = Convert.ToDateTime(IncomeList.SelectedRows[0].Cells[4].Value.ToString());
            DescTb.Text = IncomeList.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(IncomeList.SelectedRows[0].Cells[0].Value.ToString());
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
                try
                {
                    string IName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmtTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "update IncomeTbl set IncName = '{0}',IncAmt = '{1}',IncCat = '{2}',IncDate = '{3}',IncDesc = '{4}')";
                    Query = string.Format(Query, IName, Amt, Category, DateTb.Value.Date, Description);
                    Con.SetData(Query);
                    MessageBox.Show("Dodano pomyślnie.");
                    ShowIncomes();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
