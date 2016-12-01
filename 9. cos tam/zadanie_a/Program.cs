using System;

namespace PO_BST
{
	public class Program
	{
		static void Main(string[] args)
		{
			//root:
			//           50
			//          /  \
			//       25     75
			//      / \    /  \  
			//    15  30  65   100
			//   / \       \
			//  14 17      70
			// /                
			//0                  

			Console.WriteLine("\n------------Etap1--------------");

            Console.Write("\nTest wstepny 1:    ");
            var root0 = BinarySearchTree<int>.SingleNode(1);
            foreach (var n in root0.InOrder())
                Console.Write("{0}, ", n);
            Console.Write("\nTest wstepny 2:    ");
            root0 = root0.Add(2).Add(3).Add(0);
            foreach (var n in root0.InOrder())
                Console.Write("{0}, ", n);
            Console.Write("\nTest wstepny 3:    ");
            root0 = null;
            foreach (var n in root0.InOrder())
                Console.Write("{0}, ", n);
            Console.WriteLine();

            var root = BinarySearchTree<int>.SingleNode(50)
                .Add(25)
                .Add(15)
                .Add(14)
                .Add(17)
                .Add(0)
                .Add(30)
                .Add(75)
                .Add(65)
                .Add(70)
                .Add(100);

            Console.WriteLine("\nDrzewo 1:");
            root.Write();
            Console.WriteLine("Licznik (powinien być 42): " + BinarySearchTree<int>.Counter);

            var rootWith18And25 = root.Add(18).Add(35);
            Console.WriteLine("\nOrginalne drzewo 1 po modyfikacjach - powinno być takie samo jak drzewo 1:");
            root.Write();
            Console.WriteLine("\nDrzewo 1 po dodaniu 18 i 35 (Drzewo 2)");
            rootWith18And25.Write();
            Console.WriteLine("Licznik (powinien być 51): " + BinarySearchTree<int>.Counter);

            var rootWith75 = root.Add(75);
            Console.WriteLine("\nOrginalne drzewo 1 po modyfikacjach - powinno być takie samo jak drzewo 1:");
            root.Write();
            Console.WriteLine("\nDrzewo 1 po dodaniu 75 - nic nie zmieniamy");
            rootWith75.Write();
            Console.WriteLine("Licznik (powinien być 52): " + BinarySearchTree<int>.Counter);

            var rootWithout15 = root.RemoveSubTree(15);
            Console.WriteLine("\nOrginalne drzewo 1 po kolejnych modyfikacjach - powinno być takie samo jak drzewo 1:");
            root.Write();
            Console.WriteLine("\nDrzewo 1 po usunięciu wierzchołka 15 (Drzewo 3)");
            rootWithout15.Write();
            Console.WriteLine("Licznik (powinien być 54): " + BinarySearchTree<int>.Counter);

            var rootWithout125 = root.RemoveSubTree(125);
            Console.WriteLine("\nOrginalne drzewo 1 po kolejnych modyfikacjach - powinno być takie samo jak drzewo 1:");
            root.Write();
            Console.WriteLine("\nDrzewo 1 po usunięciu wierzchołka 125 - nic nie zmieniamy");
            rootWithout125.Write();
            Console.WriteLine("Licznik (powinien być 56): " + BinarySearchTree<int>.Counter);

            var rootWithout50 = root.RemoveSubTree(50);
            Console.WriteLine("\nDrzewo 1 po usunięciu wierzchołka 50 - puste");
            rootWithout50.Write();
            Console.WriteLine("Licznik (powinien być 56): " + BinarySearchTree<int>.Counter);

            Console.WriteLine("\n------------Etap2--------------");

            var rootWith25Found = root.Search(25);
            Console.WriteLine("\nOrginalne drzewo 1 po modyfikacjach - powinno być takie samo jak drzewo 1:");
            root.Write();
            Console.WriteLine("\nDrzewo o korzeniu w 25 (Drzewo 4)");
            rootWith25Found.Write();
            Console.WriteLine("Licznik (powinien być 56): " + BinarySearchTree<int>.Counter);

            var rootWith125NotFound = root.Search(125);
            Console.WriteLine("\nOrginalne drzewo 1 po modyfikacjach - powinno być takie samo jak drzewo 1:");
            root.Write();
            Console.WriteLine("\nDrzewo o korzeniu w 125 - puste");
            rootWith125NotFound.Write();
            Console.WriteLine("Licznik (powinien być 56): " + BinarySearchTree<int>.Counter);

            Console.WriteLine();
            Console.Write("Liczba liści w drzewie 1:  ");
            Console.WriteLine(root.NumberOfLeaves());
            Console.Write("Liczba liści w drzewie 2:  ");
            Console.WriteLine(rootWith18And25.NumberOfLeaves());
            Console.Write("Liczba liści w drzewie 3:  ");
            Console.WriteLine(rootWithout15.NumberOfLeaves());
            Console.Write("Liczba liści w drzewie 4:  ");
            Console.WriteLine(rootWith25Found.NumberOfLeaves());

            Console.WriteLine("\n------------Etap3--------------");

            //var root2 = BinarySearchTree<IndexableNode<int>>.SingleNode(new IndexableNode<int>(50))
            //    .Add(new IndexableNode<int>(25))
            //    .Add(new IndexableNode<int>(15))
            //    .Add(new IndexableNode<int>(0))
            //    .Add(new IndexableNode<int>(30))
            //    .Add(new IndexableNode<int>(75))
            //    .Add(new IndexableNode<int>(65))
            //    .Add(new IndexableNode<int>(100));

            //Console.WriteLine("\nIndeksowanie drzewa 1");
            //root2.Index();
            //root2.Write();
            //Console.WriteLine();
		}
	}
}
