using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            Console.WriteLine("Az összes könyv a listaban: "+l.Count);
        }
    }
}