using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Drawing;

namespace _13.SimleForm.Services
{
    public class DatabaseManager
    {
        private readonly SqlConnection _con;
        public DatabaseManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string host = configuration.GetConnectionString("Host");
            string user = configuration.GetConnectionString("User");
            string password = configuration.GetConnectionString("Password");
            string conStr = $"Data Source={host};User ID={user};Password={password};MultipleActiveResultSets=true;";
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

        public List<string> GetListDatabases()
        {
            var list = new List<string>();
            //показати список БД
            string sql = "SELECT name FROM sys.databases WHERE database_id > 4;";
            SqlCommand sqlCommand = _con.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Console.WriteLine("Списко база даних:");
                while (reader.Read())
                {
                    list.Add(reader["name"].ToString());
                }
            }
            return list;
        }
    }
}
