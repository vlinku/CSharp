using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //Liepkite vartotojui įvesti savo vardą ir amžių. Į ekraną išveskite:“Jūsų vardas {vardas},
            //o amžius {amžius}.”

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 uzduotis, 26 psl.");
            Console.WriteLine();
            Console.WriteLine("Jusu vardas:");
            var vardas = Console.ReadLine();

            Console.WriteLine("Jusu amzius:");
            var amzius = int.Parse(Console.ReadLine());

            Console.WriteLine("Jusu vardas {0}, o amzius {1}", vardas, amzius);
            Console.WriteLine();

            //Liepkite vartotojui įvesti bet kokį simbolį. Atspausdinkite 3x3 kvadratą iš to simbolio.

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("2 uzduotis, 26 psl.");
            Console.WriteLine("Iveskite 1 simboli:");
            var simbolis = Console.ReadLine();
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine("{0}{0}{0}", simbolis);
            Console.WriteLine();
            //Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("3 uzduotis, 26 psl.");
            Console.WriteLine("Iveskite skaiciu:");
            var skaicius = int.Parse(Console.ReadLine());
            var kvadratas = skaicius * skaicius;
            Console.WriteLine("{0} * {0} = {1} ", skaicius, kvadratas);
            


            Console.WriteLine();

            //Liepkite vartotojui įvesti tris skaičius.
            //Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, nurodant atliekamus veiksmus
            //ir šių skaičių reikšmes ekrane. 

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("4 uzduotis, 26 psl.");

            Console.WriteLine("Iveskite 3 skaicius:");
            var pirmas = int.Parse(Console.ReadLine());
            var antras = int.Parse(Console.ReadLine());
            var trecias = int.Parse(Console.ReadLine());

            var suma = pirmas + antras + trecias;
            var skirtumas = pirmas - antras - trecias;
            var daugyba = pirmas * antras * trecias;
            var dalyba = pirmas / antras / trecias;

            Console.WriteLine("Suma: {0} + {1} + {2} = {3}", pirmas, antras, trecias, suma);
            Console.WriteLine("Skirtumas: {0} - {1} - {2} = {3}", pirmas, antras, trecias, skirtumas);
            Console.WriteLine("Daugyba: {0} * {1} * {2} = {3}", pirmas, antras, trecias, daugyba);
            Console.WriteLine("Dalyba: {0} / {1} / {2} = {3}", pirmas, antras, trecias, dalyba);
            Console.WriteLine();

            
            //Liepkite vartotojui įvesti bet kokį sveikąjį skaičių.
            //Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5.
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("5 uzduotis, 27 psl.");

            Console.WriteLine("Iveskite viena bet kokį sveikajį skaiciu:");
            var sveikasis = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} * {1} = {2}", sveikasis, 0, sveikasis * 0);
            Console.WriteLine("{0} * {1} = {2}", sveikasis, 1, sveikasis * 1);
            Console.WriteLine("{0} * {1} = {2}", sveikasis, 2, sveikasis * 2);
            Console.WriteLine("{0} * {1} = {2}", sveikasis, 3, sveikasis * 3);
            Console.WriteLine("{0} * {1} = {2}", sveikasis, 4, sveikasis * 4);
            Console.WriteLine("{0} * {1} = {2}", sveikasis, 5, sveikasis * 5);
            Console.WriteLine();

           
           // Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį
             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("6 uzduotis, 27 psl.");

            Console.WriteLine("Iveskite 3 skaicius:");
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            var vidurkis = (first + second + third)/3;

            Console.WriteLine("Vidurkis: ({0} + {1} + {2})/3 = {3}", first, second, third, vidurkis);
            Console.WriteLine();
             
             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("7 uzduotis, 27 psl.");
           // Parašykite programą, kuri laipsnius paverstų į kelvinus ir fahrenheitus

           // Farenheitas = 1C * 9 / 5 +32; Kelvinas = 0C + 273.15;

            Console.WriteLine("Iveskite Celsijaus laipsnius('pvz.: 20.5') :");
            var laipsnis = Convert.ToDouble(Console.ReadLine());
            var Farenheitas = laipsnis * ((double)9 / 5) + 32;
            var Kelvinas = laipsnis + 273.15;

            Console.WriteLine("{0} Celsijaus laipsniu yra {1} Farenheito laipsniu ir {2} Kelvino laipsniu",laipsnis, Farenheitas, Kelvinas);
            Console.WriteLine();
            

            // Liepkite vartotojui įvesti tris sveikuosius skaičius. Parašykite šias atskiras if sąlygas:
            // 1.1 patikrinkite ar pirmas ir antras skaičiai yra lygūs;
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 uzduotis, 39 psl.");

            Console.WriteLine("Iveskite 3 skaicius:");

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Pirmas {0} ir antras {1} skaiciai yra lygus", a, b);
                Console.ReadKey();
            }

            //1.2 patikrinkite ar antras ir trečias skaičiai yra lygūs;

            if (b == c)
            {
                Console.WriteLine("Antras {0} ir trecias {1} skaiciai yra lygus", b, c);
                Console.ReadKey();
            }

            // patikrinkite ar pirmas skaičius yra didesnis už antrąjį;

            if (a > b)
            {
                Console.WriteLine("Pirmas skaicius {0} yra didesnis uz antra {1} skaiciu", a, b);
                Console.ReadKey();
            }

            //patikrinkite ar antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę
            //(trečias skaičius padaugintas iš dviejų);

            if (b > c * 2)
            {
                Console.WriteLine("Antras skaicius {0} yra didesnis uz 2x trecio skaiciaus reiksme {1}", b, c);
                Console.ReadKey();
            }

            //  patikrinkite ar pirmas skaičius yra lyginis
            //  (dalinti per % iš 2 ir žiūrėti ar gautas atsakymas yra lygus nuliui);

            if (a % 2 == 0)
            {
                Console.WriteLine("Pirmas skaicius {0} yra lyginis", a);
                Console.ReadKey();
            }
            //patikrinkite ar antras skaičius yra nelyginis
            //(dalinti per % iš 2 ir žiūrėti ar gautas atsakymas nėra lygus nuliui);

            if (b % 2 != 0)
            {
                Console.WriteLine("Antras skaicius {0} yra nelyginis", b);
                Console.ReadKey();
            }

            //  patikrinkite ar trečias skaičius yra teigiamas (daugiau už 0);

            if (c > 0)
            {
                Console.WriteLine("Trecias skaicius {0} yra teigiamas", c);
                Console.ReadKey();
            }

            //  patikrinkite ar trečias skaičius yra neigiamas (mažiau už 0).

            if (c < 0)
            {
                Console.WriteLine("Trecias skaicius {0} yra neigiamas", c);
                Console.ReadKey();
            }

             
            Console.WriteLine();

            //Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite,
            //kad “jūs galite balsuoti”.

             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("2 uzduotis, 40 psl.");

            Console.WriteLine("Iveskite savo amziu:");
            var age = int.Parse(Console.ReadLine());
            if (age >=18)
            {
                Console.WriteLine(" Jus galite balsuoti!");
            }
            Console.WriteLine();

            

           // Liepkite vartotojui įvesti bet kokį teigiamą skaičių. Parašykite šias atskiras if sąlygas:
            //patikrinti ar skaičius neigiamas, jei taip - aprėkti vartotoją :)
            //patikrinti ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
            //patikrinti ar skaičius lyginis;
            //patikrinti ar skaičius dalinasi iš 4;
            //patikrinti ar skaičius yra didesnis nei 10.
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("3 uzduotis, 40 psl.");

            Console.WriteLine("Iveskite bet koki teigiama skaiciu:");
            var betKoks = int.Parse(Console.ReadLine());

            if(betKoks < 0 )
            {
                Console.WriteLine("Kvaily prasiau ivesti teigiama, o ne neigiama skaiciu!");
            }

             if(betKoks > 0 )
            {
                Console.WriteLine("Saunuolis, ivedei teisinga skaiciu!");
            }

              if(betKoks % 2 == 0 )
            {
                Console.WriteLine("Skaicius yra lyginis");
            }

              if(betKoks % 4 == 0 )
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }

               if(betKoks > 10  )
            {
                Console.WriteLine("Skaicius yra didesnis uz 10");
            }

                Console.WriteLine();
            
          //  Liepkite vartotojui įvesti penkis savo pažymius, raskite šių pažymių vidurkį,
          //  patikrinkite ar vidurkis yra lygus arba didesnis už 5.

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("4 uzduotis, 40 psl.");

            Console.WriteLine("Iveskite savo gautus 5 pazymius:");

            var pirmasPaz = int.Parse(Console.ReadLine());
            var antrasPaz = int.Parse(Console.ReadLine());
            var treciasPaz = int.Parse(Console.ReadLine());
            var ketvirtasPaz = int.Parse(Console.ReadLine());
            var penktasPaz = int.Parse(Console.ReadLine());

            var pazVidurkis = (double)(pirmasPaz + antrasPaz + treciasPaz + ketvirtasPaz + penktasPaz)/5;

            if (pazVidurkis >= 5 )
            {
                Console.WriteLine("Saunu, Jusu vidurkis {0} yra didenis arba lygus uz 5", pazVidurkis);
            }

            Console.WriteLine();

            
            //Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
            //ar pirmas skaičius didesnis už antrą;
            //ar antras skaičius didesnis už trečią;
            //ar trečias skaičius skaičius didesnis už pirmą;
            //ar pirmi du skaičiai lygūs

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 uzduotis, 45 psl.");

            Console.WriteLine("Iveskite 3 skaicius:");

            var d = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());
            var f = int.Parse(Console.ReadLine());

            if (d > e)
            {
                Console.WriteLine("Pirmas skaicius {0} didesnis uz antra skaiciu {1} ", d, e);
                Console.ReadKey();
            }
            else if (e > f)
            {
                Console.WriteLine("Antras skaicius {0} didesnis uz trecia skaiciu {1} ", e, f);
                Console.ReadKey();
            }
            else if (f > d)
            {
                Console.WriteLine("Trecias skaicius {0} didesnis uz pirma skaiciu {1} ", f, d);
                Console.ReadKey();
            }

            else if (d == e)
            {
                Console.WriteLine("Pirmas skaicius {0} yra lygus antram skaiciui {1} ", d, e);
                Console.ReadKey();
            }

            Console.WriteLine();

            
          //  Liepkite vartotojui įvesti egzamino rezultatą (0-100), su viena sąlyga,
          //  per atskiras else if dalis, patikrinti šias ribas:
          //  ar gautas rezultatas yra lygus 100;
          //  ar gautas rezultatas yra lygus arba didesnis nei 80;
          //  ar gautas rezultatas yra lygus arba didesnis nei 50;
          //  ar gautas rezultatas yra lygus arba didesnis nei 20;
          //  ar gautas rezultatas yra mažesnis nei 20;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("2 uzduotis, 45 psl.");

            Console.WriteLine("Iveskite egzamino rezultata (0-100):");
            var rez = int.Parse(Console.ReadLine());
            
            if (rez == 100 )
            {
                Console.WriteLine("Egzamino rezultatas {0} yra puikus", rez);
            }
            
            else if (rez >= 80)
            {
                Console.WriteLine("Egzamino rezultatas {0} yra labai geras ", rez);
            }  
            else if (rez >= 50)
            {
                Console.WriteLine("Egzamino rezultatas {0} yra vidutinis ", rez);
            }   
             else if (rez >= 20)
            {
                Console.WriteLine("Egzamino rezultatas {0} yra prastas ", rez);
            }   
            else if (rez < 20)
            {
                Console.WriteLine("Egzamino rezultatas {0} . Egzaminas neislaikytas", rez);
            }   
            
            Console.WriteLine();
          
            //Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
            //ar temperatūra < 0 - išvesti “žiauriai šalta”;
            //ar temperatūra < 10 - išvesti “labai šalta”;
            //ar temperatūra < 20 - išvesti “šalta”;
            //ar temperatūra < 30 - išvesti “normali temperatūra”;
            //ar temperatūra < 40 - išvesti “karšta”;
            //ar temperatūra > 40 - išvesti “visiškai degina”;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("3 uzduotis, 46 psl.");

            Console.WriteLine("Iveskite sios dienos temperatura:");
            var temp = int.Parse(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Ziauriai Salta");
            }
            else if (temp < 10)
            {
                Console.WriteLine("Labai salta");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Salta");
            }
            else if (temp < 30)
            {
                Console.WriteLine("Normali temperatura");
            }
            else if (temp <= 40)
            {
                Console.WriteLine("Karsta");
            }
            else if (temp > 40)
            {
                Console.WriteLine("Degina");
            }

            Console.WriteLine();
            
            //Liepkite vartotojui įvesti gautą pažymį, atlikite šiuos veiksmus:
            //jei 10 - išveskite “Puikiai”;
            //jei 8-9 - išveskite “Labai gerai”;
            //jei 5-7 - išveskite “Patenkinamai”;
            //jei 3-4 - išveskite “Prastai”;
            //jei 1-2 - išveskite “Labai blogai”;

             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("4 uzduotis, 46 psl.");

             Console.WriteLine("Iveskite gauta pazymi:");
            var pazymis = int.Parse(Console.ReadLine());

             if (pazymis == 10 )
            {
                Console.WriteLine("Puikiai");
            }
            else if (pazymis > 7)
            {
                Console.WriteLine("Labai Gerai");
            }  
            else if (pazymis > 4)
            {
                Console.WriteLine("Patenkinamai");
            }  
             else if (pazymis > 2)
            {
                Console.WriteLine("Prastai");
            }  
            else if (pazymis >= 0)
            {
                Console.WriteLine("Labai Prastai");
            }  

             Console.WriteLine();
            
            //Liepkite vartotojui įvesti du skaičius.
            //Raskite kuris skaičius yra didesnis.
            //Su viena if sąlyga (bei visomis jos dalimis) atlikite šiuos patikrinimus:
            //ar pirmas skaičius didesnis už antrą skaičių;
            //ar antras skaičius didesnis už pirmą;
            //jei niekas neatitinka - tuomet skaičiai lygūs.
                  
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 uzduotis, 54 psl.");

            Console.WriteLine("Iveskite 2 skaicius:");

            var o = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            if (o > s)
            {
                Console.WriteLine("Pirmas skaicius {0} didesnis uz antra skaiciu {1} ", o, s);
                Console.ReadKey();
            }

            else if (o < s)
            {
                Console.WriteLine("Antras skaicius {1} didesnis uz pirma skaiciu {1} ", o, s);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus ", o, s);
                Console.ReadKey();
            }

            Console.WriteLine();
            
            //Liepkite vartotojui įvesti vieną norimą skaičių. Su viena if sąlyga (ir visomis jos dalimis),
            //patikrinkite šiuos dalykus:
           // ar skaičius neigiamas;
           // ar skaičius teigiamas;
           // ar skaičius lygus 0.
           Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("2 uzduotis, 54 psl.");

            Console.WriteLine("Iveskite 1 skaiciu:");
            var sk = int.Parse(Console.ReadLine());

            if (sk > 0)
            {
                Console.WriteLine("Skaicius yra teigiamas");
            }
            else if (sk < 0)
            {
                Console.WriteLine("Skaicius yra neigiamas");
            }
            else
            {
                Console.WriteLine("Skaicius yra lygus 0");
            }

            Console.WriteLine();
            

            //Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra didžiausias.

             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 uzduotis, 59 psl.");

            Console.WriteLine("Iveskite 3 skaicius:");
            var sk1 = int.Parse(Console.ReadLine());
            var sk2 = int.Parse(Console.ReadLine());
            var sk3 = int.Parse(Console.ReadLine());

            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine("Skaicius {0} yra didziausias", sk1);
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                 Console.WriteLine("Skaicius {0} yra didziausias", sk2);
            }
            else
            {
                Console.WriteLine("Skaicius {0} yra didziausias", sk3);
            }

            Console.WriteLine();
            
            //Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra mažiausias.

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("2 uzduotis, 59 psl.");

            Console.WriteLine("Iveskite 3 skaicius:");
            var maz1 = int.Parse(Console.ReadLine());
            var maz2 = int.Parse(Console.ReadLine());
            var maz3 = int.Parse(Console.ReadLine());

            if (maz1 < maz2 && maz1 < maz3)
            {
                Console.WriteLine("Skaicius {0} yra maziausias", maz1);
            }
            else if (maz2 < maz1 && maz2 < maz3)
            {
                 Console.WriteLine("Skaicius {0} yra maziausias", maz2);
            }
            else
            {
                Console.WriteLine("Skaicius {0} yra maziausias", maz3);
            }

            Console.WriteLine();
            

            //Liepkite įvesti trijų egzaminų rezultatus. Suraskite pažymių vidurkį.
            //Atlikite šiuos patikrinimus:
            //ar gautas vidurkis yra [8-10];
            //ar gautas vidurkis yra [5-8);
            //ar gautas vidurkis yra < 5.

             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("3 uzduotis, 59 psl.");

            Console.WriteLine("Iveskite 3 pazymus:");
            var gr1 = int.Parse(Console.ReadLine());
            var gr2 = int.Parse(Console.ReadLine());
            var gr3 = int.Parse(Console.ReadLine());
            var AVG = (double)(gr1 + gr2 +gr3)/3; 

            if(AVG <=10 && AVG >= 8)
            {
                Console.WriteLine("Gautas vidurkis {0} yra [8-10]", AVG);
            }
            else if(AVG <8 && AVG >= 5)
            {
                Console.WriteLine("Gautas vidurkis {0} yra [5-8]", AVG);
            }
            else if (AVG < 5)
            {
                Console.WriteLine("Gautas vidurkis {0} yra < 5", AVG);
            }
            

            //Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
            //ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
            //ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
            //ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
            //ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("4 uzduotis, 59 psl.");

            Console.WriteLine("Iveskite 2 skaicius:");
            var nr1 = int.Parse(Console.ReadLine());
            var nr2 = int.Parse(Console.ReadLine());

            if (nr1 > nr2 || nr1 == 0)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antraji arba lygus 0");
            }

            if (nr2 > nr1 || nr1 == 5)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz pirmaji arba lygus 5");
            }

            if (nr1 > nr2 && nr1 == 20)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antraji ir yra lygus 20");
            }

             if (nr2 > nr1 && nr2 < 100)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz pirmaji ir yra mazesns uz 100");
            }
            Console.ReadKey();
        }
    }

}