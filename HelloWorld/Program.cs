using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to start");

            bool work = true;

            while(work)
            {
                if(Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    Message message = new Message();
                    message.display();

                }
                Console.ReadLine();
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);

                }
            }

            

        }
       
    }
}
