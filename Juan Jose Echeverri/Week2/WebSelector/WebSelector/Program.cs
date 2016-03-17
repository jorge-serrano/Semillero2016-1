using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.WriteLine("                            Welcome to our Social Media Connect");
            Console.WriteLine();
            Console.WriteLine("> Por favor escoja una opcion: ");
            Console.WriteLine("     1) Facebook");
            Console.WriteLine("     2) Twitter");
            Console.WriteLine("     3) G+");
            Console.WriteLine("");
            
            string User, Pass, Url;
            Factory SendToFactory = new Factory();

            int CommandEntry;
            CommandEntry = int.Parse(Console.ReadLine());
            switch (CommandEntry)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("**                   FACEBOOK                  **");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("");
                    Console.WriteLine("UserName: ");
                    User = Console.ReadLine();
                    Console.WriteLine("PassWord: ");
                    Pass = Console.ReadLine();
                    Url = "http://wwww.Facebook.com";
                    

                    Console.WriteLine(SendToFactory.RequestNet("FB", User, Pass, Url));
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("**                   TWITTER                   **");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("");
                    Console.WriteLine("UserName: ");
                    User = Console.ReadLine();
                    Console.WriteLine("PassWord: ");
                    Pass = Console.ReadLine();
                    Url = "http://wwww.Twitter.com";

                    Console.WriteLine(SendToFactory.RequestNet("TT", User, Pass, Url));
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("**                       G+                    **");
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("");
                    Console.WriteLine("UserName: ");
                    User = Console.ReadLine();
                    Console.WriteLine("PassWord: ");
                    Pass = Console.ReadLine();
                    Url = "http://wwww.plus.google.com";

                    Console.WriteLine(SendToFactory.RequestNet("G+", User, Pass, Url));
                    break;
                default:
                    Console.Clear();
                    goto Inicio;
            }
            Console.ReadKey();

        }
    }
}
