using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;

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

        /// <summary>
        /// Перевірка існування БД на сервері
        /// </summary>
        /// <param name="name">Назва бази</param>
        /// <param name="conStr">Строка підлкючення</param>
        /// <returns>Повертає bool, True - якщо існує</returns>
        private bool IsExistDatabase(string name)
        {
            //Перевірка чи існує база даних
            string sql = $"IF EXISTS (SELECT name FROM sys.databases WHERE name = '{name}')" +
                " SELECT 1 AS Result" +
                " ELSE" +
                " SELECT 0 AS Result";
            SqlCommand cmd = _con.CreateCommand();
            cmd.CommandText = sql;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    int result = int.Parse(reader["Result"].ToString());
                    if (result > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void DeleteDatabase(string databaseName)
        {
            var isEsixt = IsExistDatabase(databaseName);
            if (!isEsixt)
            {
                MessageBox.Show("База даних не існує"+databaseName);
                return;
            }
            string sql = $"DROP DATABASE {databaseName};";
            SqlCommand sqlCommand = _con.CreateCommand(); //команди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
        }
    }
}
