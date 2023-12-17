using _3.Database.Entities;
using _3.Database.Helpers;
using _3.Database.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _3.Database
{
    public class ProductManager : IManager<Product>
    {
        private readonly CategoryManager _categoryManager;
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
            _categoryManager=new CategoryManager(_conn);
        }

        public event InsertCountDelegate InsertCount;

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _conn.Close();
        }

        public void GenerateRandom(int count)
        {
            throw new NotImplementedException();
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
            var dateCreate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string sql = "insert into tblProducts(CategoryId, Name, Description, Price, CreatedDate) " +
                "OUTPUT INSERTED.ID " +
                $"Values(@CategoryId, @Name, @Description, @Price, @CreatedDate);";

            Console.WriteLine("Оберіть категорію:");
            foreach (var cat in _categoryManager.GetList())
            {
                Console.WriteLine($"{cat.Id} - {cat.Name}");
            }
            Console.Write("->_");
            int catId = int.Parse(Console.ReadLine());

            Console.Write("Вкажіть назву: ");
            string name = Console.ReadLine();

            Console.Write("Вкажіть опис: ");
            string description = Console.ReadLine();

            Console.Write("Вкажіть ціну: ");
            decimal price = Decimal.Parse(Console.ReadLine());

            SqlCommand sqlCommand = _conn.CreateCommand();
            sqlCommand.CommandText = sql;

            sqlCommand.Parameters.Add(new("@Name", SqlDbType.NVarChar) { Value = name });
            sqlCommand.Parameters.Add(new("@CategoryId", SqlDbType.Int) { Value = catId });
            sqlCommand.Parameters.Add(new("@Description", SqlDbType.NVarChar) { Value = description });
            sqlCommand.Parameters.Add(new("@Price", SqlDbType.Decimal) { Value = price });
            sqlCommand.Parameters.Add(new("@CreatedDate", SqlDbType.DateTime) { Value = DateTime.Now });

            Int32 productId = (Int32)sqlCommand.ExecuteScalar();

            if(productId > 0)
            {
                while (true)
                {
                    Console.WriteLine("Вкажіть url - фото товару(пустий рядок - скасувать):");
                    string url = Console.ReadLine();
                    if (string.IsNullOrEmpty(url))
                    {
                        return;
                    }
                    var imageName = ImageWorker.ImageSave(url);
                    sql = "insert into tblProductImages(ProductId, Name, CreatedDate) Values(@ProductId, @Name, @CreatedDate);";
                    sqlCommand = _conn.CreateCommand();
                    sqlCommand.CommandText = sql;
                    sqlCommand.Parameters.Add(new("@Name", SqlDbType.NVarChar) { Value = imageName });
                    sqlCommand.Parameters.Add(new("@ProductId", SqlDbType.Int) { Value = productId });
                    sqlCommand.Parameters.Add(new("@CreatedDate", SqlDbType.DateTime) { Value = DateTime.Now });
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
