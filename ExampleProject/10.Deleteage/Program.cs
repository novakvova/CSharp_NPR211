using System.Text;

namespace _10.Deleteage
{
    internal class Program
    {
        //Вказівник, який може вказувать на метод
        //що повертає ціле число і приймає два параметра цілих
        public delegate int BinaryOP(int x, int y);
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Яку операцію виконать:");
            Console.WriteLine("0. Додавання");
            Console.WriteLine("1. Віднімання");
            Console.Write("->_");
            ListOperation operation = (ListOperation)int.Parse(Console.ReadLine());
            BinaryOP binaryOP_delegate;
            switch(operation)
            {
                case ListOperation.Add:
                    {
                        binaryOP_delegate = new BinaryOP(PlusMethod);
                        break;
                    }
                default:
                    {
                        binaryOP_delegate= new BinaryOP(MinusMethod);
                        break;
                    }
            }
            int a=34, b=12;
            //Console.WriteLine("Результат вашої дії {0}", binaryOP_delegate(a,b));
            Console.WriteLine("Результат вашої дії {0}", binaryOP_delegate.Invoke(a,b));
            //Console.WriteLine($"{a}+{b} = " + PlusMethod(a,b));
            //Console.WriteLine($"{a}-{b} = " + MinusMethod(a,b));
        }

        static int PlusMethod(int a, int b)
        {
            return a + b;
        }
        static int MinusMethod(int a, int b)
        {
            return a - b;
        }
    }
}
