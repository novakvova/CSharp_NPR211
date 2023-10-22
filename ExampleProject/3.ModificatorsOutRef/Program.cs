
using System.Text;

namespace _3.ModificatorsOutRef
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //TestOut();
            //TestRef();
            //summ("Сума елементів {0}", 12,23,12);

            double[] list = { 23, 18, 17 };
            summ(list: list, message: "Результат додавання {0}");
            
            ///Console.WriteLine("Summ = {0}", data);

        }

        private static void summ(string message = "text", params double[] list)
        {
            double result = 0.0;
            foreach (var item in list)
            {
                result += item;
            }
            Console.WriteLine(message, result);
        }

        private static void TestRef()
        {
            Console.WriteLine("Вкажіть значення a");
            string str = Console.ReadLine();
            int a = 0; //для ref - значення має буть ініціалізовано початково
            bool isConvert = myTyParseRef(str, ref a); //int.TryParse(str, out a);
            if (isConvert)
            {
                Console.WriteLine("Перетворення а успішно {0}", a);
            }
            else
            {
                Console.WriteLine("Дані вказано не коректно!");
            }
        }
        private static bool myTyParseRef(string str, ref int value)
        {
            try
            {
                value = int.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        } 


        private static void TestOut()
        {
            Console.WriteLine("Вкажіть значення a");
            string str = Console.ReadLine();
            int a;
            bool isConvert = myTryParse(str, out a); //int.TryParse(str, out a);
            if (isConvert)
            {
                Console.WriteLine("Перетворення а успішно {0}", a);
            }
            else
            {
                Console.WriteLine("Дані вказано не коректно!");
            }
        }

        private static bool myTryParse(string str, out int value)
        {
            value = 0;
            try
            {
                value = int.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}

