using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacao.Entities
{
    internal class HourContract
    {
        public DateTime date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public override string ToString()
        {
            return $"{date.ToString("yyyy-MM-dd HH:mm:ss")} - ValuePerHour: {ValuePerHour}, Hours: {Hours}";
        }
    }
}
