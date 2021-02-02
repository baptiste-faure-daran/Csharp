using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FakeTimeGiver : ITimeGiver
    {
        private DayOfWeek _dayOfWeek;
        private int _hour;


        public FakeTimeGiver(DayOfWeek DoW, int hour)
        {
            _dayOfWeek = DoW;
            _hour = hour;
        }

 
        public DateTime getCurrentTime()
        {
            DateTime dt = new DateTime(1, 1, 1, _hour, 1, 1);

            while (dt.DayOfWeek != _dayOfWeek)
            {
                dt = dt.AddDays(1);
            }

            return dt;
        }
    }
}
