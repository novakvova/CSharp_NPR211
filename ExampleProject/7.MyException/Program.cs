using System.Collections;
using System.Text;

namespace _7.MyException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //ExceptionInfo();
            try
            {
                DateTime dt = DateTime.Parse("12.10.1900");
                Student student = new Student("Мельник Іван", "Інформатика", dt);
                Console.WriteLine(student);
            }
            catch(StudentDateBirthException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("В роботі виникла помилка {0}", ex.Message);
            }
            
        }

        private static void ExceptionInfo()
        {
            try
            {
                Exception myex = new Exception("Помилка для мене :)");
                myex.HelpLink = "https://hard.rozetka.com.ua/ua/samsung_ls32bg702eixua/p368679933/";
                myex.Data.Add("DateCreate", DateTime.Now);
                myex.Data.Add("Monitor", "Перевірте монітор в розетці");
                throw myex;
                int a = 25;
                int b = 0;
                Console.WriteLine("Вкажіть значення b:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("b = {0}", b);

            }
            catch (FormatException fex)
            {
                Console.WriteLine("Дані вказано не вірно {0}", fex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Виникла помилка {0}", ex.Message);
                Console.WriteLine("HelpLink {0}", ex.HelpLink);
                foreach (DictionaryEntry de in ex.Data)
                {
                    Console.WriteLine($"-> {de.Key}: {de.Value}");
                }
            }
            finally
            {
                Console.WriteLine("Блок завершив роботу!");
            }
        }
    }
}
