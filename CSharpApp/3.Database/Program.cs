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
            
            DatabaseManager databaseManager = new DatabaseManager();
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("0.Вихід");
                Console.WriteLine("1.Створити нову БД");
                Console.WriteLine("2.Показати усі БД");
                Console.WriteLine("3.Видалить БД");
                Console.WriteLine("4.Робота із таблицями в БД");
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
                    case 4:
                        {
                            Console.WriteLine("Вкажіть назву бази даних: ");
                            string nameDatabase = Console.ReadLine();
                            workingTabels(nameDatabase);
                            break;
                        }
                }
            } while (action!=0);

            databaseManager.Dispose();
        }
        /// <summary>
        /// Робота із таблицями
        /// </summary>
        /// <param name="nameDatabase">Назва бази даних</param>

        private static void workingTabels(string nameDatabase)
        {
            var databaseManager = new DatabaseManager(nameDatabase);
            var proffesionManager = new ProfessionManager(nameDatabase);
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("\t0.Вихід");
                Console.WriteLine("\t1.Створити таблиці в базі даних");
                Console.WriteLine("\t2.Показати список таблиць в базі даних");
                Console.WriteLine("\t3.Додати клієнтів (INSERT)");
                Console.WriteLine("\t4.Показати список клієнтів");
                Console.WriteLine("\t5.Показати список професій");
                Console.Write("\t->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            databaseManager.CreateTabels();
                            break;
                        }
                    case 2:
                        {
                            databaseManager.ShowAllTabels();
                            break;
                        }
                    case 3:
                        {
                            databaseManager.InsertClients();
                            break;
                        }
                    case 4:
                        {
                            databaseManager.ShowAllClients();
                            break;
                        }
                    case 5:
                        {
                            var list = proffesionManager.GetList();
                            foreach (var p in list)
                            {
                                Console.WriteLine(p);
                            }
                            break;
                        }
                }

            } while (action != 0);
            databaseManager.Dispose();
        }

        
    }
}