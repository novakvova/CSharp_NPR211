using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Database
{
    public class DatabaseManager : IDisposable
    {
        private SqlConnection _conn;
        /// <summary>
        /// Підлкючення до сервера
        /// </summary>
        public DatabaseManager()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string conStr = configuration.GetConnectionString("MSSQLServerConnection") ?? "Data Source=.;Integrated Security=True;";

            _conn = new SqlConnection(conStr);
            _conn.Open();
        }
        /// <summary>
        /// Підлкючення до конкретної бази даних на сервері
        /// </summary>
        /// <param name="nameDatabase">Назва бази даних</param>
        public DatabaseManager(string nameDatabase)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string conStr = configuration.GetConnectionString("MSSQLServerConnection") ?? "Data Source=.;Integrated Security=True;";
            conStr += $"Initial Catalog={nameDatabase};";

            _conn = new SqlConnection(conStr);
            _conn.Open();
        }

        public void CraateDatabase()
        {
            Console.WriteLine("Вкажіть назву бази даних:");
            string dbName = Console.ReadLine();

            var isEsixt = IsExistDatabase(dbName);
            if (isEsixt)
            {
                Console.WriteLine("База даних {0} уже існує", dbName);
                return;
            }
            //створення на сервері бази даних
            //string sql = "CREATE DATABASE "+dbName+";";
            string sql = $"CREATE DATABASE {dbName};";
            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Успішно створено БД :)");
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
            SqlCommand cmd = _conn.CreateCommand();
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

        public void ShowAllDatabase()
        {
            //показати список БД
            string sql = "SELECT name FROM sys.databases WHERE database_id > 4;";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Console.WriteLine("Списко база даних:");
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"]);
                }
            }
        }

        public void DeleteDatabase()
        {
            Console.WriteLine("Вкажіть назву бази даних:");
            string dbName = Console.ReadLine();


            var isEsixt = IsExistDatabase(dbName);
            if (!isEsixt)
            {
                Console.WriteLine("База даних не існує", dbName);
                return;
            }
            string sql = $"DROP DATABASE {dbName};";
            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Успішно видалено БД :)");
        }


        public void CreateTabels()
        {
            string sql = "CREATE TABLE tblClients (" +
                "Id INT PRIMARY KEY IDENTITY(1,1)," +
                "FirstName NVARCHAR(50) NOT NULL," +
                "LastName NVARCHAR(50) NOT NULL," +
                "Phone NVARCHAR(20) NOT NULL," +
                "DateOfBirth DATE NULL," +
                "CreatedDate DATETIME NOT NULL," +
                "Sex bit NOT NULL);";

            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("------Таблицю успішно створено------");
        }
        //Показать список таблиць в БД
        public void ShowAllTabels()
        {
            //показати список БД
            string sql = "SELECT name FROM sys.tables";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Console.WriteLine("\tСписок таблиць:");
                while (reader.Read())
                {
                    Console.WriteLine("\t"+reader["name"]);
                }
            }
        }

        public void Dispose()
        {
            _conn.Close();
        }

        public void InsertClients()
        {
            string sql = "INSERT INTO tblClients " +
                "(FirstName, LastName, Phone, DateOfBirth, CreatedDate, Sex) " +
                "VALUES('Назар', 'Мельник', '+380 98 89 45 144', '2004-12-08', '2023-09-10 11:15:22', 1);";

            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("------Додано запис------");
        }

        public void ShowAllClients()
        {
            //показати список БД
            string sql = "SELECT Id, FirstName, LastName, Phone, DateOfBirth, CreatedDate, Sex " +
                         "FROM tblClients;";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                Console.WriteLine("\tКлієнти:");
                while (reader.Read())
                {
                    Console.WriteLine("\t" + reader["Id"]+"\t"+
                        reader["LastName"]+" "+reader["FirstName"] +"\t"+
                        reader["Phone"] + "\t" + reader["DateOfBirth"]);
                }
            }
        }
    }
}
