using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var pm = new Piramide();
            
            Console.WriteLine("=== ETAP 1 ===");
            //2 punkty

            //char[][] piramide1 = pm.BuildPiramide();
            //pm.PrintPiramide(piramide1);

            //char[][] piramide2 = pm.BuildPiramide(material: 'M');
            //pm.PrintPiramide(piramide2);

            //char[][] piramide3 = pm.BuildPiramide(3, 'S');
            //pm.PrintPiramide(piramide3);

            //char[][] piramide4 = pm.BuildPiramide(-10, 'Z');
            //pm.PrintPiramide(piramide4);

            Console.WriteLine();

            Console.WriteLine("=== ETAP 2 ===");
            //1.5 punktu

            //char material5;
            //char[][] piramide5 = pm.AddPiramides(out material5, piramide1, piramide2, piramide3);
            //Console.WriteLine("Out material: {0}\n", material5);
            //pm.PrintPiramide(piramide5);

            //char material6;
            //char[][] piramide6 = pm.AddPiramides(out material6, new[] { piramide2, piramide3 });
            //Console.WriteLine("Out material: {0}\n", material6);
            //pm.PrintPiramide(piramide6);

            Console.WriteLine();

            Console.WriteLine("=== ETAP 3 ===");
            //1.5 punktu

            //char[][] piramide7 = pm.BuildPiramideFromScrap(new object[] { 2.9, "Some text", 'C', -100, 2, 'c', 3.8, 4 });
            //pm.PrintPiramide(piramide7);

            //char[][] piramide8 = pm.BuildPiramideFromScrap(new object[] { 2.9, "Some text", -100, 2, 3.8, 4 });
            //pm.PrintPiramide(piramide8);

            //char[][] piramide9 = pm.BuildPiramideFromScrap(new object[] { 2.9, "Some text", 'C', -100, 'c', 3.8 });
            //pm.PrintPiramide(piramide9);

            //char[][] piramide10 = pm.BuildPiramideFromScrap(new object[] { 2.9, "Some text", 3.8 });
            //pm.PrintPiramide(piramide10);

            Console.WriteLine();
        }
    }
}
