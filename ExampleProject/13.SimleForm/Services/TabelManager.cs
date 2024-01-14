using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;

namespace _13.SimleForm.Services
{
    public class TabelManager
    {
        private readonly SqlConnection _con;
        public TabelManager(string databaseName)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string host = configuration.GetConnectionString("Host");
            string user = configuration.GetConnectionString("User");
            string password = configuration.GetConnectionString("Password");
            string conStr = $"Data Source={host};User ID={user};Password={password};" +
                $"MultipleActiveResultSets=true;";
            conStr += $"Initial Catalog={databaseName};";
            try
            {
                _con = new SqlConnection(conStr);
                _con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення!!! " + ex.Message);
            }
        }

        public List<string> GetAllTabels()
        {
            List<string> tabels = new List<string>();
            //показати список БД
            string sql = "SELECT name FROM sys.tables";
            SqlCommand sqlCommand = _con.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    tabels.Add((string)reader["name"]);
                }
            }
            return tabels;
        }
    }
}
