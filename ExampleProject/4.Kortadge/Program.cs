using System.Text;
using System.Windows.Markup;

namespace _4.Kortadge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //---------------One------------------
            //(string, int, string) values = ("Альона", 5, "Іванка");
            //var values = ("Альона", 5, "Іванка");

            //Console.WriteLine("Item1 {0}", values.Item1);
            //Console.WriteLine("Item2 {0}", values.Item2);
            //Console.WriteLine("Item3 {0}", values.Item3);

            //(int id, string name) values = (12, "Іван");
            //var values = (id: 12, name: "Іван");

            //Console.WriteLine(values.id);
            //Console.WriteLine(values.name);

            //var girl = new { id = 12, name = "Світлана" };

            var girl = (id: 12, name: "Світлана");
            Console.WriteLine("Girl {0}, {1}", girl.id, girl.name);

            //Console.WriteLine("Привіт козаки!");
        }
    }
}