using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie
{
    public class Jackie
    {
        public int Year { get; set; }
        public int Races { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int Poles { get; set; }
        public int Fastests { get; set; }

        public Jackie()
        {
        }

        public Jackie(int year, int races, int wins, int podiums, int poles, int fastests)
        {
            Year = year;
            Races = races;
            Wins = wins;
            Podiums = podiums;
            Poles = poles;
            Fastests = fastests;
        }

        public override string ToString()
        {
            return $"Year: {Year}\n" +
                   $"Year: {Races}\n" +
                   $"Year: {Wins}\n" +
                   $"Year: {Podiums}\n" +
                   $"Year: {Poles}\n" +
                   $"Year: {Fastests}\n";
        }
    }
}
