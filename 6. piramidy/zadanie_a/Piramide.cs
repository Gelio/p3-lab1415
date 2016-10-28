using System;

namespace Lab6
{
    public class Piramide
    {
        /// <summary>
        /// Metoda buduję nową piramidę.
        /// </summary>
        /// <param name="height">Wysokość piramidy (liczba poziomów). Parametr ma wartość domyślną 5 i nazwę height.</param>
        /// <param name="material">Znak z jakiego ma być zbudowana piramida. Parametr ma wartość domyślną 'o' i nazwę material.</param>
        /// <returns>Nowa piramida</returns>
        /// <remarks>
        /// 1. Jeśli podana wysokość jest nie dodatnia, metoda używa parametru domyślnego.
        /// 2. Nie zapamiętujemy w tablicach pustych miejsc.
        /// </remarks>
        public char[][] BuildPyramid(int height = 5, char material = 'o')
        {
            if (height < 0)
                return this.BuildPyramid(material: material);

            char[][] pyramid = new char[height][];
            int width = 2*height - 1;
            
            for (int i=0; i < height; i++)
            {
                int leftPadding = height - 1 - i;
                int bricks = 2 * i + 1;
                pyramid[i] = new char[leftPadding + bricks + 1];
                for (int j=0; j < bricks; j++)
                {
                    pyramid[i][leftPadding + j] = material;
                }
                
            }
            return pyramid;
        }

        /// <summary>
        /// Metoda wypisuje piramidę
        /// </summary>
        /// <param name="pyramid">Piramida do wypisania</param>
        public void PrintPyramid(char[][] pyramid)
        {
            for (int i=0; i < pyramid.Length; i++)
            {
                Console.WriteLine(pyramid[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Metoda dodaje piramidy podane jako parametr lub parametry. Wynikowa piramida ma wysokość równą sumie wysokości piramid składowych i 
        /// zbudowana jest ze znaku będącego maksymalnym ze znaków piramid składowych.
        /// </summary>
        /// <param name="material">Parametr wyjściowy o nazwie material do zwrócenia wartości nowego materiału. </param>
        /// <param name="pyramids">Piramidy do dodania. Mogą być w postaci tablicy, lub pojedynczych piramid.</param>
        /// <returns>Nowa piramida.</returns>
        public char[][] AddPyramids(out char material, params char[][][] pyramids)
        {
            int totalHeight = 0;
            char outputMaterial = Char.MaxValue;
            Array.ForEach(pyramids, delegate (char[][] pyramid)
            {
                totalHeight += pyramid.Length;
                if (pyramid.Length > 0)
                {
                    char currentMaterial = pyramid[0][pyramid.Length - 1];
                    if (outputMaterial == Char.MaxValue|| outputMaterial < currentMaterial)
                        outputMaterial = currentMaterial;
                }
                    
            });
            material = outputMaterial;
            return this.BuildPyramid(totalHeight, material);
        }

        /// <summary>
        /// Metoda buduje piramidę w oparciu o podaną tablicę obiektów. 
        /// Wysokość piramidy jest wyznaczana następująco:
        /// 1. Dla każdego obiektu sprawdzamy czy jest typu int.
        /// 2. Jako wysokość przyjmujemy maksymalny z wyników udanych konwersji.
        /// 3. Jeśli żadna z konwersji się nie powiodła budujemy piramidę o domyślnym rozmiarze.
        /// 
        /// Znak z jakiego zbudowana jest nowa piramida wyznaczamy następująco:
        /// 1. Dla każdego z obiektów sprawdzamy czy jest typu char.
        /// 2. Jako materiał na nową piramidę przyjmujemy minimalny z wyników udanych konwersji.
        /// 3. Jeśli żadna z konwersji się nie powiodła budujemy piramidę z domyślnego materiału.
        /// </summary>
        /// <param name="objects">Obiekty dostępne do budowy piramidy. Mogą być w postaci tablicy lub osobnych obiektów.</param>
        /// <returns>Nowa piramida</returns>
        /// <remarks>
        /// UWAGA 1: Nie można używać konstrukcji try ... catch ...
        /// UWAGA 2: W tym miejscu nie wiemy jaka jest domyśna wysokość i domyślny materiał do budowy piramidy.
        ///          Należy odpowiednio wywołać metodę BuildPyramid, bo tylko ona ma te informacje)
        /// </remarks>
        public char[][] BuildPyramidFromScrap(object[] objects)
        {
            int totalHeight = 0;
            char material = Char.MaxValue;
            Array.ForEach(objects, delegate (object obj)
            {
                if (obj is int)
                    totalHeight = Math.Max(totalHeight, (int)obj);

                if (obj is char && (material == Char.MaxValue || (char)obj < material))
                    material = (char)obj;
            });

            char[][] pyramid;
            if (totalHeight > 0 && material != Char.MaxValue)
                pyramid = this.BuildPyramid(totalHeight, material);
            else if (totalHeight > 0)
                pyramid = this.BuildPyramid(totalHeight);
            else if (material != Char.MaxValue)
                pyramid = this.BuildPyramid(material: material);
            else
                pyramid = this.BuildPyramid();

            return pyramid;
        }
    }
}
