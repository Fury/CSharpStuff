using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Les1_3_dll.deel3
{
    public class Maand
    {
        public int Maandnr { get; set; }
        public int Jaar { get; set; }

        public Maand()
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(Maandnr) + " " + Jaar);
            sb.AppendLine();
            sb.AppendLine();

            for (int i = 1; i <= 7; i++)
            {
                DateTime dt = new DateTime(Jaar, Maandnr, i);
                sb.Append(DateTimeFormatInfo.CurrentInfo.GetDayName(dt.DayOfWeek));
                bool notAtEnd = true;
                do
                {
                    if (dt.Month == Maandnr)
                    {
                        sb.Append("\t " + dt.Day);
                        dt = dt.AddDays(7);
                    }
                    else
                    {
                        Console.WriteLine(dt.Month);
                        notAtEnd = false;
                    }

                } while (notAtEnd);
                sb.Append("\n");
            }

            return sb.ToString();

        }
    }
}
