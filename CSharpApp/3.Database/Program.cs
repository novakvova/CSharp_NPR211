using System.Data.SqlClient;
using System.Text;

namespace _3.Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //Підлкючення до сервера
            //string conStr = "Data Source=.;Integrated Security=True;";
            //string conStr = "Server=20.65.144.204;User=kaban;Password=9[nV`e7VN`0%;";
            //string conStr = "Data Source=20.65.144.204;User=kaban;Password=9[nV`e7VN`0%;";
            string conStr = "Data Source=20.65.144.204;User ID=kaban;Password=9[nV`e7VN`0%;";

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("0.Вихід");
                Console.WriteLine("1.Створити нову БД");
                Console.WriteLine("2.Показати усі БД");
                Console.WriteLine("3.Видалить БД");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            CraateDatabase(con);
                            break;
                        }
                    case 2:
                        {
                            ShowAllDatabase(con);
                            break;
                        }
                    case 3:
                        {
                            DeleteDatabase(con);
                            break;
                        }
                }
            } while (action!=0);
            con.Close();

            //Console.WriteLine("Привіт козак!");
        }

        private static void CraateDatabase(SqlConnection con)
        {
            Console.WriteLine("Вкажіть назву бази даних:");
            string dbName = Console.ReadLine();


            var isEsixt = IsExistDatabase(dbName, con);
            if (isEsixt)
            {
                Console.WriteLine("База даних {0} уже існує", dbName);
                return;
            }
            //створення на сервері бази даних
            //string sql = "CREATE DATABASE "+dbName+";";
            string sql = $"CREATE DATABASE {dbName};";
            SqlCommand sqlCommand = con.CreateCommand(); //окманди виконуєються на основі підлкючення
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
        private static bool IsExistDatabase(string name, SqlConnection con)
        {
            //Перевірка чи існує база даних
            string sql = $"IF EXISTS (SELECT name FROM sys.databases WHERE name = '{name}')" +
                " SELECT 1 AS Result" +
                " ELSE" +
                " SELECT 0 AS Result";
            SqlCommand cmd = con.CreateCommand();
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
    
        private static void ShowAllDatabase(SqlConnection con)
        {
            //показати список БД
            string sql = "SELECT name FROM sys.databases WHERE database_id > 4;";
            SqlCommand sqlCommand = con.CreateCommand();
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


        private static void DeleteDatabase(SqlConnection con)
        {
            Console.WriteLine("Вкажіть назву бази даних:");
            string dbName = Console.ReadLine();


            var isEsixt = IsExistDatabase(dbName, con);
            if (!isEsixt)
            {
                Console.WriteLine("База даних не існує", dbName);
                return;
            }
            string sql = $"DROP DATABASE {dbName};";
            SqlCommand sqlCommand = con.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Успішно видалено БД :)");
        }
    }
}