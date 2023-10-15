using _3.Database.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Database
{
    /// <summary>
    /// Керування таблицею і даними по професіям
    /// </summary>
    public class ProfessionManager : IDisposable
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

        public void Dispose()
        {
            _conn.Close();
        }
    }
}
