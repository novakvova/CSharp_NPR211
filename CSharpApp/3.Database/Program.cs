using _3.Database.Entities;
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
                Console.WriteLine("\t3.Керування клієнтами");
                Console.WriteLine("\t5.Керування професіями");
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
                            workingClients(nameDatabase);
                            break;
                        }
                    case 5:
                        {
                            workingProfessionls(nameDatabase);
                            break;
                        }
                }

            } while (action != 0);
            databaseManager.Dispose();
        }


        /// <summary>
        /// Робота із Професіями
        /// </summary>
        /// <param name="nameDatabase">Назва бази даних</param>
        private static void workingProfessionls(string nameDatabase)
        {
            var proffesionManager = new ProfessionManager(nameDatabase);
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("\t\t0.Вихід");
                Console.WriteLine("\t\t1.Показати список професій");
                Console.WriteLine("\t\t2.Додати професію");
                Console.WriteLine("\t\t3.Видалить професію");
                Console.WriteLine("\t\t4.Оновити професію");
                Console.Write("\t->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            var list = proffesionManager.GetList();
                            foreach (var p in list)
                            {
                                Console.WriteLine(p);
                            }
                            break;
                        }
                    case 2:
                        {
                            Profession profession = new Profession();
                            Console.WriteLine("Вкажіть назву професії:");
                            profession.Name = Console.ReadLine();
                            proffesionManager.Insert(profession);
                            Console.WriteLine("-----Професію успішно створено-----");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Вкажіть id професії:");
                            int id = int.Parse(Console.ReadLine());
                            var p = proffesionManager.GetById(id);
                            if (p == null)
                            {
                                Console.WriteLine("----Професія відстуня---");
                                break;
                            }
                            proffesionManager.Delete(p);
                            Console.WriteLine("-----Професію успішно видалено-----");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Вкажіть id професії:");
                            int id = int.Parse(Console.ReadLine());
                            var p = proffesionManager.GetById(id);
                            if (p == null)
                            {
                                Console.WriteLine("----Професія відстуня---");
                                break;
                            }
                            Console.WriteLine("Вкажіть нову назву професії: ");
                            p.Name = Console.ReadLine();
                            proffesionManager.Update(p);
                            Console.WriteLine("-----Професію успішно змінено-----");
                            break;
                        }
                }

            } while (action != 0);
            proffesionManager.Dispose();
        }


        /// <summary>
        /// Робота із Клієнтами
        /// </summary>
        /// <param name="nameDatabase">Назва бази даних</param>
        private static void workingClients(string nameDatabase)
        {
            var clientManager = new ClientManager(nameDatabase);
            var proffesionManager = new ProfessionManager(nameDatabase);
            int action = 0;
            do
            {
                Console.WriteLine("Оберіть операцію:");
                Console.WriteLine("\t\t0.Вихід");
                Console.WriteLine("\t\t1.Показати список кліжнтів");
                Console.WriteLine("\t\t2.Додати клієнта");
                Console.WriteLine("\t\t3.Видалить кліжнта");
                Console.WriteLine("\t\t4.Оновити кліжнта");
                Console.Write("\t->_");
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        {
                            var list = clientManager.GetList();
                            foreach (var p in list)
                            {
                                Console.WriteLine(p);
                            }
                            break;
                        }
                    case 2:
                        {
                            Client entity = new Client();
                            Console.WriteLine("Вкажіть прізвище клієнта:");
                            entity.LastName = Console.ReadLine();
                            Console.WriteLine("Вкажіть ім'я клієнта:");
                            entity.FirstName = Console.ReadLine();
                            Console.WriteLine("Беріть професію:");
                            foreach (var p in proffesionManager.GetList())
                            {
                                Console.WriteLine(p);
                            }
                            Console.Write("->_");
                            entity.ProfessionId = int.Parse(Console.ReadLine());
                            //clientManager.Insert(entity);
                            Console.WriteLine("-----Клієнта успішно створено-----");
                            break;
                        }
                        //case 3:
                        //    {
                        //        Console.WriteLine("Вкажіть id професії:");
                        //        int id = int.Parse(Console.ReadLine());
                        //        var p = proffesionManager.GetById(id);
                        //        if (p == null)
                        //        {
                        //            Console.WriteLine("----Професія відстуня---");
                        //            break;
                        //        }
                        //        proffesionManager.Delete(p);
                        //        Console.WriteLine("-----Професію успішно видалено-----");
                        //        break;
                        //    }

                        //case 4:
                        //    {
                        //        Console.WriteLine("Вкажіть id професії:");
                        //        int id = int.Parse(Console.ReadLine());
                        //        var p = proffesionManager.GetById(id);
                        //        if (p == null)
                        //        {
                        //            Console.WriteLine("----Професія відстуня---");
                        //            break;
                        //        }
                        //        Console.WriteLine("Вкажіть нову назву професії: ");
                        //        p.Name = Console.ReadLine();
                        //        proffesionManager.Update(p);
                        //        Console.WriteLine("-----Професію успішно змінено-----");
                        //        break;
                        //    }
                }

            } while (action != 0);
            clientManager.Dispose();
            proffesionManager.Dispose();    
        }
    }
}