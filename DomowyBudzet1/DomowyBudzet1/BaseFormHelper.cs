using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomowyBudzet1
{
    public class BaseFormHelper
    {
        Functions Con;

        public BaseFormHelper()
        {
            Con = new Functions();
        }

        public void SumData(string query, Label targetLabel, string suffix)
        {
            try
            {
                DataTable dt = Con.GetData(query);
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    targetLabel.Text = dt.Rows[0][0].ToString() + " " + suffix;
                }
                else
                {
                    targetLabel.Text = "0 " + suffix;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
            }
        }

        public void CountData(string query, Label targetLabel, string prefix)
        {
            try
            {
                DataTable dt = Con.GetData(query);
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    targetLabel.Text = prefix + dt.Rows[0][0].ToString();
                }
                else
                {
                    targetLabel.Text = prefix + "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
            }
        }

        public decimal GetSum(string query)
        {
            DataTable dt = Con.GetData(query);
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDecimal(dt.Rows[0][0]);
            }
            return 0;
        }
    }
}
