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
    public class CategoryManager : IDisposable
    { 
        private SqlConnection _conn;

        /// <summary>
        /// Підлкючення до конкретної бази даних на сервері
        /// </summary>
        /// <param name="nameDatabase">Назва бази даних</param>
        public CategoryManager(string nameDatabase)
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
        /// Додати категорію
        /// </summary>
        public void Insert(Category c)
        {
            //2004-12-08
            //2023-09-10 11:15:22
            string sql = "INSERT INTO tblCategories " +
                "(Name, Description, [Image], CreatedDate) " +
                $"VALUES(@Name, @Description, @Image, @CreatedDate);";
            SqlCommand sqlCommand = _conn.CreateCommand(); //окманди виконуєються на основі підлкючення
            sqlCommand.CommandText = sql; //текст команди

            // Create a parameter with NVarChar data type for Unicode strings and add it to the command's Parameters collection
            SqlParameter pName = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar);
            pName.Value = c.Name;
            sqlCommand.Parameters.Add(pName);

            SqlParameter pDescription = new SqlParameter("@Description", System.Data.SqlDbType.NVarChar);
            pDescription.Value = c.Description;
            sqlCommand.Parameters.Add(pDescription);

            SqlParameter pImage = new SqlParameter("@Image", System.Data.SqlDbType.NVarChar);
            pImage.Value = c.Image;
            sqlCommand.Parameters.Add(pImage);

            SqlParameter pCreatedDate = new SqlParameter("@CreatedDate", System.Data.SqlDbType.DateTime);
            pCreatedDate.Value = c.CreatedDate;
            sqlCommand.Parameters.Add(pCreatedDate);

            //виконати комнаду до сервера
            sqlCommand.ExecuteNonQuery();
        }

        /// <summary>
        /// Повертаємо список усіх категорій
        /// </summary>
        public List<Category> GetList()
        {
            List<Category> list = new List<Category>();
            //показати список БД
            string sql = "SELECT Id, Name, Description, [Image], CreatedDate " +
                         "FROM tblCategories;";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;
            //Результа сервера будемо читати через SqlDataReeader
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Category entity = new Category();
                    entity.Id = int.Parse(reader["Id"].ToString());
                    entity.Name = reader["Name"].ToString();
                    entity.Description = reader["Description"].ToString();
                    entity.Image = reader["Image"].ToString();
                    entity.CreatedDate = reader["CreatedDate"].ToString();
                    list.Add(entity);
                }
            }

            return list;
        }

        public void Dispose()
        {
            _conn.Close();
        }
    }
}
