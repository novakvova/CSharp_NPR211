using System.Globalization;
using System.Text;

namespace _1.Begin
{
    class Program
    {
        public static int Main(string []args)
        {
            //CTS - загально прийняті стандартні типи даних. Які є у всіх мовах на .NET
            //System.Byte,  SByte, Intl6, Int32, Int64, UIntl6, UInt32, UInt64,
            //Single, Double, Object, Char, String, Decimal, Boolean
            //CLR - Середовище виконання
            Console.Title = "Козакі";
            
            //string, 
            //StringBuilder
            //int a = default;
            Console.WriteLine("double = {0}",double.Epsilon);
            Console.WriteLine("double = {0:f324}",double.Epsilon);
            Console.InputEncoding=Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;
            int c = 26;
            string str = $"Сьогодні температура {c}";
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Ваші параметри {0} - {1}", i, args[i]);
            }

            Console.ReadKey();
            
            // String name="Vova";
            // Console.WriteLine("Name = {0}", name);
            // CultureInfo culture = new CultureInfo("uk-ua");
            //CultureInfo culture = new CultureInfo("en");
            //string,
            // DateTime dt = DateTime.Now;
            // DateTime dt = new DateTime(2004,6,30, 13,24,50);
            
            //string str = dt.ToString("D", culture);
            // string str = dt.ToString(culture);
            // Console.WriteLine("Зараз час "+ str);
            //
            // Object hello=12;
            // Console.WriteLine("Вкажіть значення: ");
            // hello = Convert.ToDecimal(Console.ReadLine(), culture);
            // string str = hello.ToString();
            // Console.WriteLine("Ви вказали: " + str);
            // Console.WriteLine("sizeof(byte) = {0}", sizeof(byte));
            return 0;
        }
    }
}

