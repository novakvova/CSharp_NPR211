using _3.Database.Entities;
using _3.Database.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _3.Database
{
    public class ProductManager : IManager<Product>
    {
        private SqlConnection _conn;
        public ProductManager(string nameDatabase)
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

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _conn.Close();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetList()
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT p.Id, p.CategoryId, c.Name as CategoryName, p.Name, p.Description, p.Price, p.CreatedDate " +
                "FROM tblProducts p " +
                "INNER JOIN tblCategories c " +
                "ON p.CategoryId = c.Id ";
            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;
            using(SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Product entity = new Product();
                    entity.Id = int.Parse(reader["Id"].ToString());
                    entity.Name = reader["Name"].ToString();
                    entity.Description = reader["Description"].ToString();
                    entity.CategoryName = reader["CategoryName"].ToString();
                    entity.CategoryId = int.Parse(reader["CategoryId"].ToString());
                    entity.CreatedDate = reader["CreatedDate"].ToString();
                    entity.Price = decimal.Parse(reader["Price"].ToString());
                    entity.Images = new List<string>();
                    string sqlImages = "SELECT Name " +
                        "FROM tblProductImages tpi " +
                        $"WHERE tpi.ProductId = {entity.Id}";
                    SqlCommand sqlImageCommand = _conn.CreateCommand();
                    sqlImageCommand.CommandText = sqlImages;
                    using(SqlDataReader imageReader = sqlImageCommand.ExecuteReader())
                    {
                        while (imageReader.Read())
                        {
                            entity.Images.Add(imageReader["Name"].ToString());
                        }
                    }
                    list.Add(entity);
                }
            }
            return list;
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
