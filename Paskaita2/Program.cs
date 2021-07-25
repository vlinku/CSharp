using System;


namespace Paskaita2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Pirma uzduotis
            var a = 4;
            var b = 5;
            var c = 8;

            var suma = a + b;
            var skirtumas = a - b;
            var daugyba = a * b;
            var dalyba = (double)a / b;
            Console.WriteLine("1) {0} + {1} = {2}", a, b, suma);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("{0} - {1} = {2}", a, b, skirtumas);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("{0} * {1} = {2}", a, b, daugyba);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("{0} / {1} = {2}", a, b, dalyba);
            Console.WriteLine();
            Console.ReadKey();


            // Antra uzduotis

            var kvadratas = a * a;
            var kubas = a * a * a;

            Console.WriteLine("2) {0} * {0} = {1}", a, kvadratas);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("{0} * {0} * {0} = {1}", a, kubas);
            Console.WriteLine();
            Console.ReadKey();

            // Trecia uzduotis

            var trijuSkaiciuDaugyba = a * b * c;
            Console.WriteLine("3) {0} * {1} * {2} = {3}", a, b, c, trijuSkaiciuDaugyba);
            Console.WriteLine();
            Console.ReadKey();

            // Ketvirta uzduotis

            var d = -1;
            var e = 4;
            var f = 6;
            var atsakymas1 = d + e * f;


            Console.WriteLine("4) {0} + {1} * {2} = {3}", d, e, f, atsakymas1);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            var g = 35;
            var h = 5;
            var j = 7;
            var atsakymas2 = (g + h) % j;

            Console.WriteLine("4.1) {0} + {1} % {2} = {3}", g, h, j, atsakymas2);
            Console.ReadKey();

            Console.WriteLine("-----------------------------");

            var i = 14;
            var k = -4;
            var l = 6;
            var m = 11;
            var atsakymas3 = i + k * l / m;

            Console.WriteLine();
            Console.WriteLine("4.2) {0} + {1} * {2} / {3} = {4}", i, k, l, m, atsakymas3);
            Console.ReadKey();

            Console.WriteLine("-----------------------------");

            var n = 2;
            var o = 15;
            var p = 6;
            var r = 1;
            var s = 7;
            var atsakymas4 = n + o / p * r - s % n;

            Console.WriteLine();
            Console.WriteLine("4.3) {0} + {1} / {2} * {3} - {4} % {5} = {6} ", n, o, p, r, s, n, atsakymas4);
            Console.ReadKey();

            Console.WriteLine("-----------------------------");

            // Penkta uzduotis

            var t = 8;

            Console.WriteLine("{0} * {1} = {2}", t, 0, t * 0);
            Console.WriteLine("{0} * {1} = {2}", t, 1, t * 1);
            Console.WriteLine("{0} * {1} = {2}", t, 2, t * 2);
            Console.WriteLine("{0} * {1} = {2}", t, 3, t * 3);
            Console.WriteLine("{0} * {1} = {2}", t, 4, t * 4);
            Console.WriteLine("{0} * {1} = {2}", t, 5, t * 5);
            Console.WriteLine("{0} * {1} = {2}", t, 6, t * 6);
            Console.WriteLine("{0} * {1} = {2}", t, 7, t * 7);
            Console.WriteLine("{0} * {1} = {2}", t, 8, t * 8);
            Console.WriteLine("{0} * {1} = {2}", t, 9, t * 9);
            Console.ReadKey();

            Console.WriteLine("-----------------------------");

            // Sesta uzduotis

            int skaicius = 65;
            int skaicius1 = skaicius / 10;
            int skaicius2 = skaicius % 10;

            int skAtsakymas = skaicius1 * skaicius2;
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, skAtsakymas);
            Console.ReadKey();


        }
    }
}
