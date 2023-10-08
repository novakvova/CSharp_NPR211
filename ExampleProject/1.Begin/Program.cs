using System.Globalization;
using System.Text;

namespace _1.Begin
{
    class Program
    {
        public static void Main(string []args)
        {
            //CTS - загально прийняті стандартні типи даних. Які є у всіх мовах на .NET
            //System.Byte,  SByte, Intl6, Int32, Int64, UIntl6, UInt32, UInt64,
            //Single, Double, Object, Char, String, Decimal, Boolean
            //CLR - Середовище виконання
            Console.InputEncoding=Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;
             //CultureInfo culture = new CultureInfo("uk-ua");
            CultureInfo culture = new CultureInfo("en");
            //string,
            // DateTime dt = DateTime.Now;
            DateTime dt = new DateTime(2004,6,30);
            
            string str = dt.ToString("D", culture);
            Console.WriteLine("Зараз час "+ str);
            //
            // Object hello=12;
            // Console.WriteLine("Вкажіть значення: ");
            // hello = Convert.ToDecimal(Console.ReadLine(), culture);
            // string str = hello.ToString();
            // Console.WriteLine("Ви вказали: " + str);
            // Console.WriteLine("sizeof(byte) = {0}", sizeof(byte));
        }
    }
}

