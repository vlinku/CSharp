using System;


namespace Paskaita3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //  Parašyti for, kuris išvestų kiekvieną skaičių pradedant nuo 0 ir baigiant 10.
            //  Kiekvieną skaičių išvesti skirtingoje eilutėje.
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1 uzduotis, 7 psl.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();


            // Parašyti for, kuris išvestų kas antrą skaičių pradedant 0 ir baigiant 15.
            // Kiekvieną skaičių išvesti toje pačioje eilutėje, po kiekvieno skaičiaus dedant tarpą.
             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("2 uzduotis, 7 psl.");

            for (int i = 0; i < 15; i += 2)
            {
                Console.Write(i + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            //Parašyti for, kuris išvestų kas trečią skaičių, pradedant 1 ir baigiant 20.
            //Kiekvieną skaičių išvesti toje pačioje eilutėje tačiau apskliaudžiant laužtiniais skliaustais.
            //Pvz.: [1][3][5]...
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("3 uzduotis, 7 psl.");

            for (int i = 1; i < 20; i += 3)
            {
                Console.Write("[" + i + "]");
            }

            Console.WriteLine();

           // Parašyti for, kuris eitų pro kiekvieną skaičių nuo 1 iki 10.
           // Jame apsirašyti if sąlygą, kuri patikrintų ar dabartinis skaičius yra lyginis,
           // jei taip tai šį skaičių išvesti.
           Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("4 uzduotis, 7 psl.");

            for (int i = 1; i <= 10; i++)
			{
                if ( i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
			}

            Console.WriteLine();

           // Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga).
           // Jei rėžiai tinkami, tuomet vykdyti for, kuris atskirose eilutėse išvestų kiekvieną skaičių iš tų rėžių, bei atskiriant tarpu -
           // tų skaičių kvadratus.

             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("5 uzduotis, 7 psl.");

             Console.WriteLine("Iveskite reziu pradzia ir pabaiga:");
            var rez1 = int.Parse(Console.ReadLine());
            var rez2 = int.Parse(Console.ReadLine());

            if (rez1 < rez2)
            {
                for (int i = rez1; i <= rez2; i++)
                {
                    Console.WriteLine(i + " " + i*i);

                }
			{

			}
            }

            Console.WriteLine();

            
           // Liepkite vartotojui įvesti rėžių pradžią ir pabaigą.
           // Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga).
           // Jei rėžiai tinkami, tuomet vykdyti for, kuris iš duotų skaičių išvestų visus
           // nelyginius skaičius arba tuos, kurie dalinasi iš 8.

             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("6 uzduotis, 7 psl.");

             Console.WriteLine("Iveskite reziu pradzia ir pabaiga:");
            var range1 = int.Parse(Console.ReadLine());
            var range2 = int.Parse(Console.ReadLine());

            if (range1 < range2)
            {
                for (int i = range1; i <= range2; i++)
                {
                    if(i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    

                }

            }
            Console.WriteLine();
            

            // (optional) Be daugybos veiksmo programoje, sudauginti du skaičius.

             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("7 uzduotis, 7 psl.");

             Console.WriteLine("Iveskite iveskite du skaicius:");
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var pradzia = 0; 
            for (int i = 1; i <= number2; i++)
			{
                  
                pradzia += number1;
                
			}

            Console.WriteLine(pradzia);
            Console.WriteLine();

            
           // Raskite visų skaičių nuo 1 iki 100 sumą.
             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("8 uzduotis, 10 psl.");


            var simto_suma = 0;
            for (int i = 1; i < 100; i++)
			{
                   simto_suma +=i;
			}

            Console.WriteLine(simto_suma);

            Console.WriteLine();
             

            var lyg_20_50_suma = 0;
           
            //Raskite visų lyginių skaičių nuo 20 iki 50 sumą. 
             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("9 uzduotis, 10 psl.");

            for (int i = 20; i < 50; i++)
			{
                if (i % 2 == 0)
                {
                    lyg_20_50_suma +=i;
                }
			}
            Console.WriteLine(lyg_20_50_suma);
           

            //Raskite visų nelyginių skaičių nuo 30 iki 60 sumą
             Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("10 uzduotis, 10 psl.");
            var nelyg_30_60_suma = 0;
            for (int i = 30; i < 60; i++)
            {
                if (i % 2 != 0)
                    {
                        nelyg_30_60_suma +=i;
                    }
            }
			
            Console.WriteLine(nelyg_30_60_suma);
            Console.WriteLine();
			
            //Rasti visų skaičių, žemesnių už 1000 ir kurie dalinasi iš 3 arba 5, sumą.
            var dal_3_arba_5 = 0;
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("11 uzduotis, 10 psl.");

            for (int i = 1; i < 1000; i++)
			{
                if (i % 3 == 0 || i % 5 == 0)
                {
                    dal_3_arba_5 +=i;
                }
			}
            Console.WriteLine(dal_3_arba_5);
            Console.WriteLine();
            

            //"Write a program that prints the numbers from 1 to 100.
            //But for multiples of three print “Fizz” instead of the number and for the multiples of five
            //print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”."

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("12 uzduotis, 11 psl.");

            for (int i = 1; i < 100; i++)
			{
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }


			}

            Console.ReadKey();

        }
    }
}
