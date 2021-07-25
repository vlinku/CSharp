using System;

namespace Paskaita1
{
    class Program
    {
        static void Main(string[] args)
        {

             string Vardas = "Vilius";
           string Pavardė = "Linkunaitis";
             int Amzius = 35;
             double Svoris = 110.15;
             var Aukstoji_Mokykla = "KTU";
             var AkademinesGrupesKodas = "TBM 5/3";
             string kursas = "Pirmas Kursas";
            int kreditu_skaicius = 160;

           Console.WriteLine("Sveikas, Pasauli!");
           Console.ReadKey();

            //ctrl + k + c uzdeda komentarus
            //ctrl + k + u nuima komentarus

            //Pirmas Uzduotis
            Console.Write("Labas ");
            Console.WriteLine("Vilius");
            Console.ReadKey();

            //Antra Uzduotis
            int amzius = 35;
           Console.WriteLine("Įvestas amžius: {0}", amzius);
            Console.ReadKey();

            //Trecia Uzduotis

            int skaicius = 25;
           // Console.Write(""+skaicius+skaicius+skaicius+skaicius+skaicius);
            Console.Write("{0}{0}{0}{0}{0}", skaicius);
            Console.WriteLine();
            Console.ReadKey();

            //Ketvirta Uzduotis
            Console.Write("{0} {0} {0} {0} {0}", skaicius);
            Console.ReadKey();
            Console.WriteLine();
            //Console.Write(skaicius + " " + skaicius + " " + skaicius + " " + skaicius + " " + skaicius + " ");

           // Penkta Uzduotis

            Console.WriteLine("****");
            Console.WriteLine("*  *");
            Console.WriteLine("*  *");
            Console.WriteLine("****");
             Console.ReadKey();

            // Sesta Uzduotis

            var automobilio_marke = "Subaru";
            var modelis = "Outback";
            var metai = 2015;
            var rida = 93000;

            Console.WriteLine("Automobilio {0} {1} ({2} m.) rida - {3} km.",automobilio_marke,modelis,metai,rida );
            Console.ReadKey();
          

        }

    }
}
