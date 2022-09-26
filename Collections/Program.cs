using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AutoSharp> autoShops = new List<AutoSharp>();

            autoShops.Add(new AutoSharp("Car1", 120, 25000));
            autoShops.Add(new AutoSharp("Car2", 120, 25500));
            autoShops.Add(new AutoSharp("Car3", 120, 14000));

            foreach (var item in autoShops)
            {
                Console.WriteLine(item.CarName);
            }

            autoShops.Sort();

            foreach (var item in autoShops)
            {
                Console.WriteLine(item.CarName);
            }
        }

        public static void Exmpl01()
        {
            Random rnd = new Random();

            ArrayList arr = new ArrayList();

            //arr.Add(rnd.Next());

            for (int i = 0; i < 5; i++)
            {
                arr.Add(rnd.Next()); // Boxing
            }
        }

        public static void RemoveElement(int i, int j, ArrayList arr)
        {
            arr.RemoveAt(1);
            arr.RemoveRange(i, j); // 1-5
            arr.Remove(new object());
        }

        public static void WriteCollection(ArrayList arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine("{0}\t", item);
            }
            Console.WriteLine("\n");
        }

        // Необобщенные коллекций, нужно задвать конкретный тип
        static void Exmpl02() // Hashtable
        {
            Hashtable ht = new Hashtable();
            ht.Add("alex", "1234");
            ht.Add("alex85", "12345346");
            ht.Add("alex86", "54321");

            //Считать коллекцию

            ICollection keys = ht.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine(item + ":" + ht[item]);
            }
        }

        static void Exampl03() // Queque
        {
            Random rnd = new Random();
            Queue qe = new Queue();
            for (int i = 0; i < 10; i++)
            {
                qe.Enqueue(rnd.Next());
            }

            Console.WriteLine("Количество элементов: " + qe.Count);
            foreach (var item in qe)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(qe.Peek());

            Console.WriteLine(qe.Dequeue());
        }

        static void Exampl04() //Stack
        {
            Stack mst = new Stack();
            mst.Push("a");
            mst.Push("b");
            mst.Push("c");
            mst.Push("d");
            mst.Push("e");

            foreach (var item in mst)
            {
                Console.WriteLine("pop -> {0}", mst.Pop());
            }

            if (mst.Count == 0)
            {
                Console.WriteLine("stack empty");
            }
        }

        static void Exampl05() //Dictionary
        {
            Random rnd = new Random();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                dic.Add(i, rnd.Next().ToString());
            }

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + item.Value);
            }
        }

        static void Exampl06() // SortedList
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(1, "a");
            list.Add(2, "b");
            list.Add(3, "c");
            list.Add(4, "d");
            list.Add(5, "e");
            list.Add(6, "f");
            list.Add(7, "g");
            list.Add(8, "h");
            list.Add(9, "i");

            ICollection<int> keys = list.Keys;

            foreach (var item in list)
            {
                Console.WriteLine("{0} - {0}", item);
            }
        }

        static void Exampl07() // list
        {
            List<int> ints = new List<int>();
        }

        static void Exampl08() //LinkedList - двусвязный список
        {
            LinkedList<int> list = new LinkedList<int>();   

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            list.AddAfter(list.Last, 4);

            foreach (var item in list)
            {

            }
        }

        //SortedDictionary

        //Паралельные коллекций

        //Разрядные коллекций


        //Интерфейс IComparable


    }

    public class AutoSharp : IComparable<AutoSharp>
    {
        public string CarName { get; set; }
        public int MaxSpeed { get; set; }
        public int Cost { get; set; }

        public AutoSharp(string CarName, int MaxSpeed, int Cost)
        {
            this.CarName = CarName;
            this.MaxSpeed = MaxSpeed;
            this.Cost = Cost;
        }

        public int CompareTo(AutoSharp obj)
        {
            if (this.Cost > obj.Cost)
                return 1;
            else if (this.Cost > obj.Cost)
               return -1;
            else
                return 0;
        }
    }
}
