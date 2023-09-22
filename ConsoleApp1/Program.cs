using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    public struct Konyvek
    {
        public string veznev;
        public string kernev;
        public string szuldatum;
        public string konyvcim;
        public string isbn;
        public string kiado;
        public string kiadasev;
        public int ar;
        public string tema;
        public int oldalszam;
        public int honorarium;

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Konyvek> l = new List<Konyvek>();
            Konyvek k = new Konyvek();
            foreach (var i in File.ReadAllLines("J:\\Aszt_alk\\ConsoleApp1\\konyvek.txt"))
            {
                string[] t = i.Split("\t");
                k.veznev = t[0];
                k.kernev = t[1];
                k.szuldatum = t[2];
                k.konyvcim = t[3];
                k.isbn = t[4];
                k.kiado = t[5];
                k.kiadasev = t[6];
                k.ar = Convert.ToInt32(t[7]);
                k.tema = t[8];
                k.oldalszam = Convert.ToInt32(t[9]);
                k.honorarium = Convert.ToInt32(t[10]);
                l.Add(k);


            }
            //2. feladat:
            Console.WriteLine("Az összes könyv a listaban: "+l.Count);
            

            //3. feladat:
            var legtobbHonor = l.Max(b =>  b.honorarium);
            var legtobbHonorIro = l.Where(b => b.honorarium == legtobbHonor).Select(b => $"{b.veznev} {b.kernev}").FirstOrDefault();
            Console.WriteLine("A legtöbbet kapó költő: " + legtobbHonorIro);

            //4.feladat:
            bool vaneimforatika = l.Any(b => b.tema.Equals("informatika"));
            if (vaneimforatika == true)
            {
                Console.WriteLine("Van informatika témájú könyv.");
            }
            else
            {
                Console.WriteLine("Nincs informatika témájú könyv.");
            }

            // 5. feladat:
            int konyvek2010 = l.Count(b => Convert.ToInt32(b.kiadasev) == 2010);
            Console.WriteLine("A 2010-ben kiadott könyvek száma: " + konyvek2010);

            // 6.feladat:
            var kingKonyvek = l.Where(b => b.veznev == "King" && b.kernev == "Stephen").Select(b => b.konyvcim);
            File.WriteAllLines("king.txt", kingKonyvek);

            // 7.feladat:


        }
    }
}