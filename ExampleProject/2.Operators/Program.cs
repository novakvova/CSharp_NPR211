using Bogus;
using System.Text;

namespace _2.Operators
{
    class Program
    {
        public static int Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Привіт козаки!");

            GenerationData();

            return 0;
        }
        private static void GenerationData(string local="uk")
        {
            var userFaker = new Faker<MyUserInfo>(local)
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.Description, f => f.Lorem.Lines(15));

            MyUserInfo user = userFaker.Generate();
            Console.WriteLine(user);
        }

        
    }
}
