using System;
namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doDictioneryDemo();
            doQueueDemo();
            doSetDemo();
        }
        private static void doListDemo()
        {
            Console.WriteLine("In doListDemo");
            List<string> list=new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ajay");
            list.Add("Ravi");
            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("In doListDemo");
            Stack<string> list = new Stack<string>();
            list.Push("Harshal");
            list.Push("Vijay");
            list.Push("Ajay");
            list.Push("Ravi");
            string pop = list.Pop();
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element: "+pop);
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("In doQueueDemo");
            Queue<string> list = new Queue<string>();
            list.Enqueue("Harshal");
            list.Enqueue("Vijay");
            list.Enqueue("Ajay");
            list.Enqueue("Ravi");
            Console.WriteLine("Head:" + list.Peek());
            Console.WriteLine("Iterating the queue element");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            string dequeue=list.Dequeue();
            Console.WriteLine("Dequeue element: "+dequeue);
        }
        private static void doSetDemo()
        {
            Console.WriteLine("In doSetDemo");
            var Set=new HashSet<string>();
            Set.Add("Ravi");
            Set.Add("Vijay");
            Set.Add("Ajay");
            Set.Add("Ravi");
            HashSet<string>.Enumerator enumerator = Set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doDictioneryDemo()
        {
            Console.WriteLine("In doDictionaryDemo");
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(100,"Ravi");
            dict.Add(101,"Vijay");
            dict.Add(102,"Ajay");
            dict.Add(103,"Ravi");
            
            foreach(var element in dict)
            {
                Console.WriteLine("Key"+element.Key+"Value"+element.Value);
            }
        }
    }
}