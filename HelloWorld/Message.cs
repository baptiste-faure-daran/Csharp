using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {

        private int _lowerThreshold;
        private int _higherThreshold;
        private int _middleThreshold;

        private ITimeGiver _timeGiver;
        private IUserGiver _userGiver;

        public string CustomMessage => getMessage();

        public DateTime theDate
        {
            get => _timeGiver.getCurrentTime();
        }

        public string userName
        {
            get => _userGiver.getCurrentUser();
        }
    
        public Message()
            : this(new TimeGiver(), new UserGiver())
            
        {
        }

        public Message(ITimeGiver timeGiver, IUserGiver userGiver)
            : this(
                  9,
                  13,
                  18,
                  timeGiver,
                  userGiver)
        {
        }

        public Message(int lower, int middle, int higher) 
            : this(lower, middle, higher, new TimeGiver(), new UserGiver())
        {
        }
        
        public Message(int lower, int middle, int higher, ITimeGiver timeGiver, IUserGiver userGiver)
        {
            _lowerThreshold = lower;
            _middleThreshold = middle;
            _higherThreshold = higher;

            _timeGiver = timeGiver;
            _userGiver = userGiver;
        }

        private string getMessage()
        {

            string messageBeginning;

            if (theDate.DayOfWeek == DayOfWeek.Saturday || theDate.DayOfWeek == DayOfWeek.Sunday ||
          (theDate.DayOfWeek == DayOfWeek.Friday && theDate.Hour >= _higherThreshold) ||
          (theDate.DayOfWeek == DayOfWeek.Monday && theDate.Hour < _lowerThreshold))
            {
                messageBeginning = "Bon week-end";
            }
            else if (theDate.Hour < _lowerThreshold || theDate.Hour >= _higherThreshold)
            {
                messageBeginning = "Bonsoir";
            }
            else if (theDate.Hour < _middleThreshold)
            {
                messageBeginning = "Bonjour";
            }
            else
            {
                messageBeginning = "Bon apres-midi";
            }

            return (messageBeginning + " " + userName);

        }

        // DISPLAY MESSAGE AVANT CREATION CLASSE DATETIME
        /*
        public void displayMessage()
        {
            var time = theDate.DayOfWeek;

            switch(time)
            {
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                
                    if(theDate.Hour > 9 & theDate.Hour < 13)
                    {
                        Console.WriteLine("Bonjour " + UserName);

                    } else if (theDate.Hour > 13 & theDate.Hour < 18)
                    {
                        Console.WriteLine("Bon après-midi " + UserName);

                    } else
                    {
                        Console.WriteLine("Bonsoir  " + userName);
                    }
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:

                    Console.WriteLine("Bon Weekend " + UserName);
                    break;

                case DayOfWeek.Monday:
                case DayOfWeek.Thursday:

                    if (theDate.Hour > 9 & theDate.Hour < 13)
                    {
                        Console.WriteLine("Bonjour " + UserName);

                    }
                    else if (theDate.Hour > 13 & theDate.Hour < 18)
                    {
                        Console.WriteLine("Bon après-midi " + UserName);

                    }
                    else
                    {
                        Console.WriteLine("Bon weekend " + userName);
                    }
                    break;

            }   
        }
        */

    }
}
