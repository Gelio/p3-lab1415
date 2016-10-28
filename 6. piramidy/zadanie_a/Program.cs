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

            char[][] piramide1 = pm.BuildPyramid();
            pm.PrintPyramid(piramide1);

            char[][] piramide2 = pm.BuildPyramid(material: 'M');
            pm.PrintPyramid(piramide2);

            char[][] piramide3 = pm.BuildPyramid(3, 'S');
            pm.PrintPyramid(piramide3);

            char[][] piramide4 = pm.BuildPyramid(-10, 'Z');
            pm.PrintPyramid(piramide4);

            Console.WriteLine();

            Console.WriteLine("=== ETAP 2 ===");
            //1.5 punktu

            char material5;
            char[][] piramide5 = pm.AddPyramids(out material5, piramide1, piramide2, piramide3);
            Console.WriteLine("Out material: {0}\n", material5);
            pm.PrintPyramid(piramide5);

            char material6;
            char[][] piramide6 = pm.AddPyramids(out material6, new[] { piramide2, piramide3 });
            Console.WriteLine("Out material: {0}\n", material6);
            pm.PrintPyramid(piramide6);

            Console.WriteLine();

            Console.WriteLine("=== ETAP 3 ===");
            //1.5 punktu

            char[][] piramide7 = pm.BuildPyramidFromScrap(new object[] { 2.9, "Some text", 'C', -100, 2, 'c', 3.8, 4 });
            pm.PrintPyramid(piramide7);

            char[][] piramide8 = pm.BuildPyramidFromScrap(new object[] { 2.9, "Some text", -100, 2, 3.8, 4 });
            pm.PrintPyramid(piramide8);

            char[][] piramide9 = pm.BuildPyramidFromScrap(new object[] { 2.9, "Some text", 'C', -100, 'c', 3.8 });
            pm.PrintPyramid(piramide9);

            char[][] piramide10 = pm.BuildPyramidFromScrap(new object[] { 2.9, "Some text", 3.8 });
            pm.PrintPyramid(piramide10);

            Console.WriteLine();
        }
    }
}
