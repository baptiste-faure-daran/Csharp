using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {

        string theDay = DateTime.Now.ToString("dddd");
        string theTime = DateTime.Now.ToString("HH");
        string userName = Environment.UserName;

        public Message()
        {


        }

        public void display()
        {

            if (theDay == "lundi" || theDay == "mardi" || theDay == "mercredi" || theDay == "jeudi")
            {
                if (theTime == "9" || theTime == "10" || theTime == "11" || theTime == "12")
                {
                    Console.WriteLine("Bonjour " + userName);

                }
                else if (theTime == "13" || theTime == "14" || theTime == "15" || theTime == "16" || theTime == "17")
                {
                    Console.WriteLine("Bon après-midi " + userName);

                }
                else
                {
                    Console.WriteLine("Bonsoir " + userName);

                }

            }
            else if (theDay == "vendredi")
            {

                if (theTime == "9" || theTime == "10" || theTime == "11" || theTime == "12")
                {
                    Console.WriteLine("Bonjour " + userName);

                }
                else if (theTime == "13" || theTime == "14" || theTime == "15" || theTime == "16" || theTime == "17")
                {
                    Console.WriteLine("Bon après-midi " + userName);

                }
                else
                {
                    Console.WriteLine("Bon Weekend " + userName);

                }

            }


        }

    }
}
