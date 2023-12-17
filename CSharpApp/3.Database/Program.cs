using _3.Database.Entities;
using _3.Database.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _3.Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
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
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("\t0.Вихід");
                Console.WriteLine("\t1.Створити таблиці в базі даних");
                Console.WriteLine("\t2.Показати список таблиць в базі даних");
                Console.WriteLine("\t3.Видалить усі таблиці в базі даних");
                Console.WriteLine("\t4.Керування клієнтами");
                Console.WriteLine("\t5.Керування професіями");
                Console.WriteLine("\t6.Керування категоріями");
                Console.WriteLine("\t7.-------Заповнити таблиці даними-------");
                Console.WriteLine("\t8.Керування продуктами");
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
                            databaseManager.DropAllTables();
                            break;
                        }
                    case 4:
                        {
                            IManager<Client> manager = new ClientManager(nameDatabase);
                            workingManager("---Керування клієнтами----", manager);
                            break;
                        }
                    case 5:
                        {
                            IManager<Profession> manager = new ProfessionManager(nameDatabase);
                            workingManager("---Керування професіями----",manager);
                            //workingProfessionls(nameDatabase);
                            break;
                        }
                    case 6:
                        {
                            IManager<Category> manager = new CategoryManager(nameDatabase);
                            workingManager("---Керування категоріями----", manager);
                            break;
                        }
                    case 7:
                        {
                            databaseManager.SetInsertDataTables();
                            break;
                        }
                    case 8:
                        {
                            IManager<Product> manager = new ProductManager(nameDatabase);
                            workingManager("---Керування Продуктами----", manager);
                            break;
                        }
                }

            } while (action != 0);
            databaseManager.Dispose();
        }

        private static void workingManager<T>(string title, IManager<T> manager)
        {
            //manager.InsertCount += Manager_InsertCount;
            int action = 0;
            do
            {
                Console.WriteLine(title);
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("\t\t0.Вихід");
                Console.WriteLine("\t\t1.Показати список");
                Console.WriteLine("\t\t2.Додати");
                Console.WriteLine("\t\t3.Видалить");
                Console.WriteLine("\t\t4.Оновити");
                Console.WriteLine("\t\t5.Генерація рандом");
                Console.Write("\t->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            var list = manager.GetList();
                            foreach (var p in list)
                            {
                                Console.WriteLine(p);
                            }
                            break;
                        }
                    case 2:
                        {
                            manager.Insert();
                            Console.WriteLine("----Запис успішно створено-----");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Вкажіть id:");
                            int id = int.Parse(Console.ReadLine());
                            var p = manager.GetById(id);
                            if (p == null)
                            {
                                Console.WriteLine("----Зпис відстуній---");
                                break;
                            }
                            manager.Delete(p);
                            Console.WriteLine("-----Запис успішно видалено-----");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Вкажіть id професії:");
                            int id = int.Parse(Console.ReadLine());
                            var p = manager.GetById(id);
                            if (p == null)
                            {
                                Console.WriteLine("----Запис відстуній---");
                                break;
                            }
                            manager.Update(p);
                            Console.WriteLine("-----Запис успішно змінено-----");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Вкажіть кількість:");
                            int n = int.Parse(Console.ReadLine());
                            manager.GenerateRandom(n);
                            Console.WriteLine("-----Запис успішно згенеровані-----");
                            break;
                        }
                }

            } while (action != 0);
            manager.Dispose();
        }

        private static void Manager_InsertCount(int count)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"-----Додано {count}------");
            Console.ForegroundColor = defaultColor;

        }
    }
}