using _3.Database.Entities;
using _3.Database.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace _3.Database
{
    /// <summary>
    /// Керування таблицею і даними по професіям
    /// </summary>
    public class ProfessionManager : IManager<Profession>
    {
        private SqlConnection _conn;
        /// <summary>
        /// Підлкючення до конкретної бази даних на сервері
        /// </summary>
        /// <param name="nameDatabase">Назва бази даних</param>
        public ProfessionManager(string nameDatabase)
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

        /// <summary>
        /// Повертаємо список усіх професій
        /// </summary>
        public List<Profession> GetList()
        {
            List<Profession> list = new List<Profession>();
            //показати список БД
            string sql = "SELECT Id, Name " +
                "FROM tblProfessions;";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Profession profession = new Profession();
                    profession.Id = int.Parse(reader["Id"].ToString());
                    //profession.Id(int.Parse(reader["Id"].ToString()));
                    profession.Name = reader["Name"].ToString();
                    list.Add(profession);
                }
            }

            return list;
        }

        /// <summary>
        /// Додати професію
        /// </summary>
        public void Insert(Profession p)
        {
            string sql = $"INSERT INTO tblProfessions ([Name]) VALUES(N'{p.Name}');";
            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Отримати професію по Id
        /// </summary>
        public Profession GetById(int id)
        {
            List<Profession> list = new List<Profession>();
            //показати список БД
            string sql = "SELECT Id, Name " +
                "FROM tblProfessions " +
                $"WHERE Id={id};";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if(reader.Read())
                {
                    Profession profession = new Profession();
                    profession.Id = int.Parse(reader["Id"].ToString());
                    //profession.Id(int.Parse(reader["Id"].ToString()));
                    profession.Name = reader["Name"].ToString();
                    return profession;
                }
            }
            return null;
        }

        /// <summary>
        /// Видалить професію по Id
        /// </summary>
        /// <param name="profession"></param>
        public void Delete(Profession profession)
        {
            string sql = $"DELETE FROM tblProfessions WHERE Id={profession.Id};";
            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Оновити професію
        /// </summary>
        public void Update(Profession p)
        {
            string sql = $"UPDATE tblProfessions SET Name=N'{p.Name}' WHERE Id={p.Id};";
            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди
            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
        }

        public void Dispose()
        {
            _conn.Close();
        }
    }
}
