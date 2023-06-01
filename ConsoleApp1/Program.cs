using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NobelDijakClass;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NobelDij> nobelDijak = new List<NobelDij>();
            StreamReader sr = new StreamReader("nobel.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                NobelDij ujNobelDij = new NobelDij(Convert.ToInt32(sor[0]), sor[1], sor[2], sor[3]);
                nobelDijak.Add(ujNobelDij);
            }
            sr.Close();


            //4. Feladat
            for (int i = 0; i < nobelDijak.Count(); i++)
            {
                if (nobelDijak[i].Ev == 2017 && nobelDijak[i].Tipus == "irodalmi")
                {
                    Console.WriteLine($"4. feladat: {nobelDijak[i].Vezeteknev} {nobelDijak[i].Keresztnev}");
                    break;
                }
            }

            //6. Feladat
            Console.WriteLine("6. feladat:");
            for (int i = 0; i < nobelDijak.Count(); i++)
            {
                if (nobelDijak[i].Vezeteknev.Contains("Curie"))
                {
                    Console.WriteLine($"\t {nobelDijak[i].Ev}: {nobelDijak[i].Keresztnev} {nobelDijak[i].Vezeteknev}({nobelDijak[i].Tipus})");
                }
            }

            //7. Feladat
            Dictionary<string, int> tipusokSzama = new Dictionary<string, int>();
            for (int i = 0; i < nobelDijak.Count(); i++)
            {
                if (tipusokSzama.ContainsKey(nobelDijak[i].Tipus))
                    tipusokSzama[nobelDijak[i].Tipus] += 1;
                else
                    tipusokSzama.Add(nobelDijak[i].Tipus, 1);
            }
            Console.WriteLine("7. feladat:");
            foreach (var tipus in tipusokSzama)
            {
                Console.WriteLine($"{tipus.Key}\t \t \t {tipus.Value}db");
            }

            //8. Feladat
            StreamWriter sw = new StreamWriter("orvosi.txt", append: true);
            List<NobelDij> rendezettLista = nobelDijak;

            for (int i = 0; i < rendezettLista.Count(); i++)
            {
                if (rendezettLista[i].Tipus == "orvosi")
                    sw.WriteLine($"{rendezettLista[i].Ev};{rendezettLista[i].Tipus}");

                sw.Close();
            }
        }
    }
}
