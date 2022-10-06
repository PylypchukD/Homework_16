using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class MyDateTime
    {
        private readonly DateTime date;
        public MyDateTime(DateTime date)
        {
            this.date = date;
        }

        public static MyDateTime operator -(MyDateTime dateTime1, MyDateTime dateTime2)
        {
            TimeSpan timeSpan = dateTime1.date - dateTime2.date;
            return new MyDateTime(dateTime1.date.AddDays(timeSpan.Days));
        }

        public static MyDateTime Sub(MyDateTime dateTime1, MyDateTime dateTime2)
        {
            return dateTime1 - dateTime2;
        }

        public override string ToString()
        {
            return date.ToString();
        }
    }
}
