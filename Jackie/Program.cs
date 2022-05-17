using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jackie
{
    internal class Program
    {
        private static List<Jackie> _jackies = new List<Jackie>();

        static void Main(string[] args)
        {
            //adatok beolvasasa a megadott file-ból
            Beolvasas("jackie.txt");

            //hány adatsort tartalmaz
            int adatokszama = _jackies.Count();
            Console.WriteLine($"3. feladat:\n {adatokszama}");


            //melyik évben indult a legtöbb versenyen
            int legtobbverseny = _jackies.Max(jackie => jackie.Races);

            int evszam = _jackies.Single(jackie => jackie.Races == legtobbverseny)
                                 .Year;

            Console.WriteLine($"4. feladat:\n {evszam}");


            //Határozza meg és írja ki a minta szerint, hogy Jackie Stewart számára melyik évtized
            //mennyire volt sikeres a megnyert versenyek száma alapjan! Az évtized alatt az évek
            //tízes csoportját érjük, azaz például a 70-es évek alatt az I970-I979-ig terjedő tartományt.

            int evtized1 = _jackies.Where(jackie => jackie.Year >= 1960 && jackie.Year <= 1969)
                                   .Sum(jackie => jackie.Wins);
            int evtized2 = _jackies.Where(jackie => jackie.Year >= 1970 && jackie.Year <= 1979)
                                   .Sum(jackie => jackie.Wins); 

            Console.WriteLine($"5. feladat:\n\t70-es évek: {evtized2} megnyert verseny\n\t60-es évek: {evtized1} megnyert verseny ");



            Console.ReadKey();
        }


        static void Beolvasas(string file)
        {
            Jackie jackie = null;
            string egySorAdatai = string.Empty;
            string[] adatok = null;

            using (FileStream fs = new(file, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF7))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        egySorAdatai = sr.ReadLine();
                        adatok = egySorAdatai.Split('\t');

                        jackie = new Jackie();
                        jackie.Year = int.Parse(adatok[0]);
                        jackie.Races = int.Parse(adatok[1]);
                        jackie.Wins = int.Parse(adatok[2]);
                        jackie.Podiums = int.Parse(adatok[3]);
                        jackie.Poles = int.Parse(adatok[4]);
                        jackie.Fastests = int.Parse(adatok[5]);

                        _jackies.Add(jackie);
                    }
                }
            }
        }

    }
}

