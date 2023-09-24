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
            ///Підлкючення до сервера
            ///string conStr = "Data Source=.;Integrated Security=True;";
            ///string conStr = "Server=20.65.144.204;User=kaban;Password=9[nV`e7VN`0%;";
            ///string conStr = "Data Source=20.65.144.204;User=kaban;Password=9[nV`e7VN`0%;";
           
            
            DatabaseManager databaseManager = new DatabaseManager();
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
                            databaseManager.CraateDatabase();
                            break;
                        }
                    case 2:
                        {
                            databaseManager.ShowAllDatabase();
                            break;
                        }
                    case 3:
                        {
                            databaseManager.DeleteDatabase();
                            break;
                        }
                }
            } while (action!=0);

            databaseManager.Dispose();
        }

        
    }
}