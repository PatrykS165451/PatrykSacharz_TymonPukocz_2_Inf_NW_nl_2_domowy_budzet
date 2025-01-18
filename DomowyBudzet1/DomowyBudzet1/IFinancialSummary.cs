using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowyBudzet1
{
    public interface IFinancialSummary
    {
        string GetTotalExpenses();
        string GetTotalIncomes();
        string GetTotalAmount();
        string CountExpenses();
        string CountIncomes();
    }
}
