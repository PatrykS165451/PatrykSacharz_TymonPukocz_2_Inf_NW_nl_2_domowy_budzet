using System.Data;
using System.Windows.Forms;

namespace DomowyBudzet1
{
    public partial class Expenses : Form
    {
        Functions Con;
        public Expenses()
        {
            InitializeComponent();
            Con = new Functions();
            ShowExpenses();
        }

        private void ShowExpenses()
        {
            try
            {
                string Query = "select * from ExpenseTbl";
                DataTable dt = Con.GetData(Query);
                if (dt != null && dt.Rows.Count > 0)
                {
                    ExpenseList.DataSource = dt;
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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Proszê wpisaæ informacje we wszystkich polach.");
            }
            else
            {
                try
                {
                    string EName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "insert into ExpenseTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, EName, Amt, Category, DateTb.Value.Date, Description);
                    Con.SetData(Query);
                    MessageBox.Show("Dodano pomyœlnie.");
                    ShowExpenses();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        /*private void ExpenseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = ExpenseList.SelectedRows[0].Cells[1].Value.ToString();
            AmountTb.Text = ExpenseList.SelectedRows[0].Cells[2].Value.ToString();
            CatTb.Text = ExpenseList.SelectedRows[0].Cells[3].Value.ToString();
            //DateTb.Value = Convert.ToDateTime(ExpenseList.SelectedRows[0].Cells[4].Value.ToString());
            DescTb.Text = ExpenseList.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ExpenseList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }*/

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Proszê wpisaæ informacje we wszystkich polach.");
            }
            else
            {
                try
                {
                    string IName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "update ExpenseTbl set ExpName = '{0}',ExpAmt = '{1}',ExpCat = '{2}',ExpDate = '{3}',ExpDesc = '{4}' where ExpId = '{5}'";
                    Query = string.Format(Query, IName, Amt, Category, DateTb.Value.Date, Description, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Zedytowano pomyœlnie.");
                    ShowExpenses();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Wybierz poprawny wpis do usuniêcia.");
            }
            else
            {
                try
                {
                    string EName = NameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "DELETE FROM ExpenseTbl WHERE ExpId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Usuniêto pomyœlnie.");
                    ShowExpenses();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ExpenseList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = ExpenseList.SelectedRows[0].Cells[1].Value.ToString();
            AmountTb.Text = ExpenseList.SelectedRows[0].Cells[2].Value.ToString();
            CatTb.Text = ExpenseList.SelectedRows[0].Cells[3].Value.ToString();
            DateTb.Value = Convert.ToDateTime(ExpenseList.SelectedRows[0].Cells[4].Value.ToString());
            DescTb.Text = ExpenseList.SelectedRows[0].Cells[5].Value.ToString();
            if (NameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ExpenseList.SelectedRows[0].Cells[0].Value.ToString());
            }
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
