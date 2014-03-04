using System;
using System.Collections.Generic;
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
            DateTime dt = new DateTime(Jaar, Maandnr, 1);
            sb.AppendLine(dt.Month + " " + dt.Year);


            return sb.ToString();
        }
    }
}
