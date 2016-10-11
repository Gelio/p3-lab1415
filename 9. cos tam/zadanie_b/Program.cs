using System;

namespace PO_BST
{
	public class Program
	{
		static void Main(string[] args)
		{
			//root:
			//        50
			//       /  \
			//   75       25
			//  /  \     /  \  
			//100  65   30  15
			//               \
			//               14
			//                \
			//                13
			//                 \
			//                  0

			Console.WriteLine("\n------------Etap1--------------");

            //Console.Write("\nTest wstepny 1:    ");
            //var root0 = DrzewoBinarne<int>.Start(1);
            //foreach (var n in root0.WKolejnosci())
            //    Console.Write("{0}, ", n);
            //Console.Write("\nTest wstepny 2:    ");
            //root0=root0.Dodaj(2).Dodaj(3).Dodaj(0);
            //foreach (var n in root0.WKolejnosci())
            //    Console.Write("{0}, ", n);
            //Console.Write("\nTest wstepny 3:    ");
            //root0=null;
            //foreach (var n in root0.WKolejnosci())
            //    Console.Write("{0}, ", n);
            //Console.WriteLine();

            //var root = DrzewoBinarne<int>.Start(50)
            //    .Dodaj(25)
            //    .Dodaj(15)
            //    .Dodaj(14)
            //    .Dodaj(13)
            //    .Dodaj(0)
            //    .Dodaj(30)
            //    .Dodaj(75)
            //    .Dodaj(65)
            //    .Dodaj(100);

            //Console.WriteLine("\nDrzewo 1:");
            //root.Wypisz();
            //Console.WriteLine("Licznik (powinien być 40): " + DrzewoBinarne<int>.Licznik);

            //var rootWith18And25 = root.Dodaj(18).Dodaj(35);
            //Console.WriteLine ("\nOrginalne drzewo 1 po modyfikacjach - powinno być takie samo jak drzewo 1:");
            //root.Wypisz();
            //Console.WriteLine("\nDrzewo 1 po dodaniu 18 i 35 (drzewo 2)");
            //rootWith18And25.Wypisz();
            //Console.WriteLine("Licznik (powinien być 48): " + DrzewoBinarne<int>.Licznik);

            //var rootWith75 = root.Dodaj(75);
            //Console.WriteLine("\nOrginalne drzewo 1 po modyfikacjach - powinno być takie samo jak drzewo 1:");
            //root.Wypisz();
            //Console.WriteLine("\nDrzewo 1 po dodaniu 75 - nic nie zmieniamy");
            //rootWith75.Wypisz();
            //Console.WriteLine("Licznik (powinien być 49): " + DrzewoBinarne<int>.Licznik);

            //var rootWithout15 = root.UsunPoddrzewo(15);
            //Console.WriteLine("\nOrginalne drzewo 1 po kolejnych modyfikacjach - powinno być takie samo jak drzewo 1:");
            //root.Wypisz();
            //Console.WriteLine("\nDrzewo 1 po usunięciu wierzchołka 15 (drzewo 3)");
            //rootWithout15.Wypisz();
            //Console.WriteLine("Licznik(powinien 51): " + DrzewoBinarne<int>.Licznik);

            //var rootWithout125 = root.UsunPoddrzewo(125);
            //Console.WriteLine("\nOrginalne drzewo 1 po kolejnych modyfikacjach - powinno być takie samo jak drzewo 1:");
            //root.Wypisz();
            //Console.WriteLine("\nDrzewo 1 po usunięciu wierzchołka 125 - nic nie zmieniamy");
            //rootWithout125.Wypisz();
            //Console.WriteLine("Licznik (powinien być 53): " + DrzewoBinarne<int>.Licznik);

            //var rootWithout50 = root.UsunPoddrzewo(50);
            //Console.WriteLine("\nDrzewo 1 po usunięciu wierzchołka 50 - puste");
            //rootWithout50.Wypisz();
            //Console.WriteLine("Licznik (powinien być 53): " + DrzewoBinarne<int>.Licznik);

			Console.WriteLine("\n------------Etap2--------------");

            //var rootWith25Found = root.Szukaj(25);
            //Console.WriteLine("\nOrginalne drzewo 1 po modyfikacjach - powinno być takie samo jak drzewo 1:");
            //root.Wypisz();
            //Console.WriteLine("\nPoddrzewo o korzeniu w 25 (drzewo 4)");
            //rootWith25Found.Wypisz();
            //Console.WriteLine("Licznik (powinien być 53): " + DrzewoBinarne<int>.Licznik);

            //var rootWith125NotFound = root.Szukaj(125);
            //Console.WriteLine("\nOrginalne drzewo 1 po modyfikacjach - powinno być takie samo jak drzewo 1:");
            //root.Wypisz();
            //Console.WriteLine("\nDrzewo o korzeniu w 125 - puste");
            //rootWith125NotFound.Wypisz();
            //Console.WriteLine("Licznik (powinien być 53): " + DrzewoBinarne<int>.Licznik);

            //Console.WriteLine();
            //Console.Write("Liczba pełnych wierzchołków w drzewie 1:  ");
            //Console.WriteLine(root.LiczbaPelnychWierzcholkow());
            //Console.Write("Liczba pełnych wierzchołków w drzewie 2:  ");
            //Console.WriteLine(rootWith18And25.LiczbaPelnychWierzcholkow());
            //Console.Write("Liczba pełnych wierzchołków w drzewie 3:  ");
            //Console.WriteLine(rootWithout15.LiczbaPelnychWierzcholkow());
            //Console.Write("Liczba pełnych wierzchołków w drzewie 4:  ");
            //Console.WriteLine(rootWith25Found.LiczbaPelnychWierzcholkow());

			Console.WriteLine("\n------------Etap3--------------");

            //var root2 = DrzewoBinarne<WierzcholekIndeksowalny<int>>.Start(new WierzcholekIndeksowalny<int>(50))
            //    .Dodaj(new WierzcholekIndeksowalny<int>(25))
            //    .Dodaj(new WierzcholekIndeksowalny<int>(15))
            //    .Dodaj(new WierzcholekIndeksowalny<int>(0))
            //    .Dodaj(new WierzcholekIndeksowalny<int>(30))
            //    .Dodaj(new WierzcholekIndeksowalny<int>(75))
            //    .Dodaj(new WierzcholekIndeksowalny<int>(65))
            //    .Dodaj(new WierzcholekIndeksowalny<int>(100));

            //Console.WriteLine("\nIndeksowanie drzewa 1");
            //root2.Indeksuj();
            //root2.Wypisz();
            Console.WriteLine();
		}
	}

	public interface IIndeksowalny
	{
		int IndeksWejsciowy { get; set; }
		int IndeksWyjsciowy { get; set; }
	}
}
