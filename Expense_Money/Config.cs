using System.Data.SqlClient;
namespace Expense_Money
{
    internal class Config
    {
        public string sql = "Data Source=DESKTOP-LDKS2EL\\SQLEXPRESS;initial Catalog=Expense_Date;Integrated Security=True";
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public void connect() {
            conn.ConnectionString = sql;
            conn.Open();
        }
    }
}
