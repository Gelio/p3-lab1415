using System;

namespace Lab6
{
    public class Piramida
    {
        /// <summary>
        /// Metoda buduję nową piramidę.
        /// </summary>
        /// <param name="wysokosc">Wysokość piramidy (liczba poziomów). Parametr ma wartość domyślną 6 i nazwę wysokosc.</param>
        /// <param name="material">Znak z jakiego ma być zbudowana piramida. Parametr ma wartość domyślną 'w' i nazwę material.</param>
        /// <returns>Nowa piramida</returns>
        /// <remarks>
        /// 1. Jeśli podana wysokość jest nie dodatnia, metoda używa parametru domyślnego.
        /// 2. Nie zapamiętujemy w tablicach pustych miejsc.
        /// </remarks>
        //public ... BudujNowaPiramide(...)
        //{
            // Odkomentowujemy i uzupełniamy odpowiednio metodę.
            // ... zastępujemy zwracanym typem i odpowiednią deklaracją parametrów
        //}

        /// <summary>
        /// Metoda wypisuje piramidę
        /// </summary>
        /// <param name="piramida">Piramida do wypisania</param>
        //public void WypiszPiramide(...)
        //{
            // Odkomentowujemy i uzupełniamy odpowiednio metodę.
            // ... zastępujemy odpowiednią deklaracją parametrów
        //}

        /// <summary>
        /// Metoda odejmuje piramidy podane jako parametr lub parametry. Wynikowa piramida ma wysokość równą wysokości pierwszej piramidy
        /// pomniejszonej o wysokości pozostałych i zbudowana jest ze znaku będącego minimalnym ze znaków piramid składowych.
        /// </summary>
        /// <param name="material">Parametr wyjściowy o nazwie material do zwrócenia wartości nowego materiału. </param>
        /// <param name="piramidy">Piramidy do dodania. Mogą być w postaci tablicy, lub pojedynczych piramid.</param>
        /// <returns>Nowa piramida.</returns>
        //public ... OdejmijPiramidy(...)
        //{
            // Odkomentowujemy i uzupełniamy odpowiednio metodę.
            // ... zastępujemy zwracanym typem i odpowiednią deklaracją parametrów
        //}

        /// <summary>
        /// Metoda buduje piramidę w oparciu o podaną tablicę obiektów. 
        /// Wysokość piramidy jest wyznaczana następująco:
        /// 1. Dla każdego obiektu sprawdzamy czy jest typu int.
        /// 2. Jako wysokość przyjmujemy minimalny z wyników udanych konwersji.
        /// 3. Jeśli żadna z konwersji się nie powiodła budujemy piramidę o domyślnym rozmiarze.
        /// 
        /// Znak z jakiego zbudowana jest nowa piramida wyznaczamy następująco:
        /// 1. Dla każdego z obiektów sprawdzamy czy jest typu char.
        /// 2. Jako materiał na nową piramidę przyjmujemy maksymalny z wyników udanych konwersji.
        /// 3. Jeśli żadna z konwersji się nie powiodła budujemy piramidę z domyślnego materiału.
        /// </summary>
        /// <param name="obiekty">Obiekty dostępne do budowy piramidy. Mogą być w postaci tablicy lub osobnych obiektów.</param>
        /// <returns>Nowa piramida</returns>
        /// <remarks>
        /// UWAGA 1: Nie można używać konstrukcji try ... catch ...
        /// UWAGA 2: W tym miejscu nie wiemy jaka jest domyśna wysokość i domyślny materiał do budowy piramidy.
        ///          Należy odpowiednio wywołać metodę BudujNowaPiramide, bo tylko ona ma te informacje)
        /// </remarks>
        //public ... BudujPiramideZObiektow(...)
        //{
            // Odkomentowujemy i uzupełniamy odpowiednio metodę.
            // ... zastępujemy zwracanym typem i odpowiednią deklaracją parametrów
        //}
    }
}
