using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class CollectionDemo
    {
        public void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Ajay");
            list.Add("Ravi");
            list.Add("Vijay");
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
        }
        public void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Popped element: " + pop);
        }
        public void doQueueDemo()
        {
            Console.WriteLine("\nIn doQueueList");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Viaj Raj");
            queue.Enqueue("JaiShankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Iterating the queue elements");
            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue elements: " + dequeue);
            Console.WriteLine("\nIterating the queue elements after dequeue one element");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ajai");
            set.Add("Ravi");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void doDictionaryDemo()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Ravi");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary");
            foreach (var data in dictionary)
            {
                Console.WriteLine("Key=" + data.Key + "& value=" + data.Value);
            }
        }
    }
}
