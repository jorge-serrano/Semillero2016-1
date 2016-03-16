using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = "HOLA".ToCharArray();
            List<char> list = new List<char>();
            Queue<char> queue = new Queue<char>();
            Stack<char> stack = new Stack<char>();
            Hashtable ht = new Hashtable();
            Dictionary<int, char> dct;
            for (int i = 0; i < chars.Length; i++)
            {
                //list.Add(chars[i]);
                queue.Enqueue(chars[i]);
                stack.Push(chars[i]);
                ht.Add(i%2,i);
            }
            list.AddRange("HOLA");
            
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine("List[{0}] = {1} ", i, list[i]);
                Console.WriteLine("Queue[{0}] = {1} ", i, queue.Dequeue());
                Console.WriteLine("Stack[{0}] = {1} ", i, stack.Pop());
                Console.ReadLine();

            }
        }
    }
}
