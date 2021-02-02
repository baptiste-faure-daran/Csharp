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
            Message message = new Message();

            string userInput = "";

            while (true)
            {
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine(message.CustomMessage);
            }
        }

    }
}
