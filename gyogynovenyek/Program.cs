using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyogynovenyek
{
    class Program
    {
        static List<noveny> novenyek = new List<noveny>();
        static Dictionary<string,int> gyujtheto = new Dictionary<string,int>();

        static void Beolvas()
        {
            StreamReader file = new StreamReader("noveny.csv");
            while (!file.EndOfStream)
            {
                novenyek.Add(new noveny(file.ReadLine()));
            }
            file.Close();

        }

        static void elso()
        {
            int db = 0;
            foreach (var item in novenyek)
            {
                db++;
            }
            Console.WriteLine("Növények száma: {0}",db);
        }

        static void masodik()
        {
            Console.WriteLine("\n 2. feladat: gyűjthető részek: ");

            foreach (var t in novenyek)
            {
                if (!gyujtheto.ContainsKey(t.Resz))
                {
                    gyujtheto.Add(t.Resz,0);
                    
                }

            }
            
            foreach (var m in novenyek)
            {
                gyujtheto[m.Resz]++;

            }

            foreach (var item in gyujtheto)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        static void harmadik()
        {
            Console.WriteLine("\n 3. feladat");
            int max = novenyek[0].Idotartam;
            for (int i = 0; i < novenyek.Count; i++)
            {
                if (max< novenyek[i].Idotartam)
                {
                    max = novenyek[i].Idotartam;
                }
            }
            

            foreach (var item in novenyek)
            {
                if (item.Idotartam == max)
                {
                    Console.WriteLine(item.Nev+": "+max);
                }  
            }

        }


        static void negyedik()
        {
            Console.Write("\n4. feladat Átlagos gyűjthető időtartam: ");
            double osszeg = 0;

            foreach (var item in novenyek)
            {
                osszeg += item.Idotartam;
            }
            Console.WriteLine(osszeg / novenyek.Count);
        }
        static void Main(string[] args)
        {
            Beolvas();
            elso();
            masodik();
            harmadik();
            negyedik();

            Console.ReadKey();
        }
    }
}
