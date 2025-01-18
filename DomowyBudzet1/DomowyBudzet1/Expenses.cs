using System.Data;
using System.Windows.Forms;

namespace DomowyBudzet1
{
    public partial class Expenses : FinancialDataForm
    {
        public Expenses()
        {
            InitializeComponent();
            ShowData(ExpenseList);
        }

        protected override string TableName => "ExpenseTbl";
        protected override string IdColumnName => "ExpId";
        protected override string NameColumnName => "ExpName";
        protected override string AmountColumnName => "ExpAmt";
        protected override string CategoryColumnName => "ExpCat";
        protected override string DateColumnName => "ExpDate";
        protected override string DescriptionColumnName => "ExpDesc";

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Proszê wpisaæ informacje we wszystkich polach.");
            }
            else
            {
                AddData(NameTb.Text, Convert.ToInt32(AmountTb.Text), CatTb.Text, DateTb.Value.Date, DescTb.Text);
                ShowData(ExpenseList);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Proszê wpisaæ informacje we wszystkich polach.");
            }
            else
            {
                EditData(key, NameTb.Text, Convert.ToInt32(AmountTb.Text), CatTb.Text, DateTb.Value.Date, DescTb.Text);
                ShowData(ExpenseList);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Wybierz poprawny wpis do usuniêcia.");
            }
            else
            {
                DeleteData(key);
                ShowData(ExpenseList);
            }
        }

        private void ExpenseList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            OnCellContentClick(ExpenseList, e, NameTb, AmountTb, CatTb, DateTb, DescTb, ref key);
        }

        int key = 0;

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

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
