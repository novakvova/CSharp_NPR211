using System.Text;

namespace _8.MyYield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //yieldExample();
            //CloneObjectExample();
            Nurse[] list = new Nurse[3];
            list[0] = new Nurse
            {
                Name = "Іван Петрович",
                Experience = 5,
                Kind=Kind.HoneyBrother
            };
            list[1] = new Nurse
            {
                Name = "Аліна Масимівна",
                Experience = 15,
                Kind = Kind.Older
            };
            list[2] = new Nurse
            {
                Name = "Марина Юлянівна",
                Experience = 10,
                Kind = Kind.Midwife
            };
            Array.Sort(list);
            Array.Reverse(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        private static void yieldExample()
        {
            Console.WriteLine("Послідовність");
            Garage garage = new Garage();
            foreach (var item in garage)
            {
                Console.WriteLine(item);
            }
        }
    
        private static void CloneObjectExample()
        {
            Nurse ivan = new Nurse
            {
                Name = "Іван Петрович",
                Experience = 12,
                Kind = Kind.HoneyBrother
            };
            Nurse mykola = (Nurse)ivan.Clone();
            mykola.Name = "Микола Васильович";

            Console.WriteLine(ivan);
            Console.WriteLine(mykola);
        }
    }
}
