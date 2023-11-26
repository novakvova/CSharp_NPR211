using System.Collections;
using System.Text;

namespace _9.Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //ArrayList mas = new ArrayList();
            //mas.Add(12);
            //mas.Add("Сало");
            //mas.Add("Корова");
            //mas.Add(true);
            //foreach (var item in mas)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable ht = new Hashtable();
            //ht.Add("Яблуко", "Apple");
            //ht.Add("Стіл", "Table");
            //ht.Add("Парта", "Table");
            //foreach (string s in ht.Keys)
            //{
            //    Console.WriteLine($"{s}\t{ht[s]}");
            //}

            SortedList sl = new SortedList();
            sl.Add("Яблуко", "Apple");
            sl.Add("Стіл", "Table");
            sl.Add("Жінка", "Woman");

            foreach (string s in sl.Keys)
            {
                Console.WriteLine($"{s}\t{sl[s]}");
            }
        }
    }
}
