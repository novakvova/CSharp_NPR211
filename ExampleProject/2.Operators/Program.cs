using Bogus;
using System.Net.Security;
using System.Text;

namespace _2.Operators
{
    class Program
    {
        public static int Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("Привіт козаки!");

            //GenerationData(3,"en",2);

            //OperatorIf();

            ArrayExample();

            return 0;
        }
        private static void GenerationData(int count=5, string local="uk", int lines=3)
        {
            var userFaker = new Faker<MyUserInfo>(local)
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Description, f => f.Lorem.Lines(lines));

            ///for (int i = 0; i < count; i++)
            ///{
            ///    MyUserInfo user = userFaker.Generate();
            ///    Console.WriteLine(user);
            ///    Console.WriteLine();
            ///}
            
            ///Random r = new Random();
            ///int n = r.Next(5,10);
            ///MyUserInfo []users = new MyUserInfo[n];
            ///for (int i = 0; i < n; i++)
            ///{
            ///    users[i] = userFaker.Generate();
            ///}
            ///foreach (MyUserInfo user in users)
            ///{
            ///    Console.WriteLine(user);
            ///    Console.WriteLine();
            ///}
        
            ///While and do while - C++
        }

        private static void OperatorIf()
        {
            //==, !=, >=, <=, >, <, ||, &&, ! 
            string str = "";
            //true або false
            if(str.Length!=0)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("STR Length == 0");
            }
            //int a = str.Length==0 ? -1 : str.Length;
        }
        
        private static void ArrayExample()
        {
            ///object[] list = { 12, "Hello", 0.23, false };
            ///foreach(var item in list)
            ///{
            ///    Console.WriteLine(item);
            ///}

            ///int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, };
            ///foreach(int i in list)
            ///{
            ///    Console.WriteLine(i);
            ///}

            ///Random random = new Random();
            ///
            ///Console.Write("Вкажіть розмір масиву ->_");
            ///int n = int.Parse(Console.ReadLine());
            ///int[] mas = new int[n];
            ///for(int i = 0; i < n; i++) { mas[i] = random.Next(0, 255); }
            ///foreach(var item in mas)
            ///{
            ///    Console.Write("{0}\t", item);
            ///}
            ///Console.WriteLine();

            int n=3, m=2;
            int[,] matrix;
            matrix = new int[n,m];
            Random r = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    matrix[i,j] = r.Next(1, 20);
                }
            }
            Console.WriteLine("Array foreach {0}x{1}", n, m);
            foreach (int i in matrix)
            {
                Console.WriteLine("i = {0}", i);
            }

            Console.WriteLine("Array for {0}x{1}", n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
