// See https://aka.ms/new-console-template for more information
using System.Text;

namespace _1.Begin
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("Я додав функцію Main :)");
            int action = -1;
            do
            {
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("0. Вихід");
                Console.WriteLine("1. Додати");
                Console.WriteLine("2. Відняти");
                Console.WriteLine("3. Помножити");
                Console.WriteLine("4. Поділити");
                Console.Write("->_");
                if (!int.TryParse(Console.ReadLine(), out action))
                {
                    action = -1;
                    continue;
                }
                //action = int.Parse(Console.ReadLine());
                switch(action)
                {
                    case 1:
                        {
                            InputValue(out int a, out int b);
                            int result = a + b;
                            Console.WriteLine("Результат: "+result);
                            break;
                        }
                    case 2:
                        {
                            //int a, b;
                            InputValue(out int a, out int b);
                            int result = a - b;
                            Console.WriteLine("Результат: " + result);
                            break;
                        }

                }

            } while (action!=0);
           

            Console.ReadLine();
        }
        //ref, out
        public static void InputValue(out int a, out int b)
        {
            Console.WriteLine("Вкажіть значення a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Вкажіть значення b");
            b = int.Parse(Console.ReadLine());
        }
    }
}


