using System;

delegate double Function (double x);
delegate double Algorytm1 (Function p1, double a, double b);
delegate double Algorytm2(Function p1, Function p2, double a);

namespace lab10
{

    class Test
    {
        const double eps = 1e-3;

        // Znajdywanie minimum funkcji metod¹ bisekcji
        // Parametry:
        // p1 - pochodna badanej funkcji (typ delegacyjny)
        // a  - dolna granica przedzia³u poszukiwañ
        // b  - górna granica przedzia³u poszukiwañ
        // Wynik: wartoœæ argumentu funkcji, dla którego osi¹gane jest minimum
        static double Bisection(Function p1, double a, double b)
        {
            double m = (a + b) / 2;


            while (Math.Abs(a - b) > eps)
            {
                if (Math.Abs(p1(m)) < eps) break;

                if (p1(m) > 0)
                    b = m;
                else
                    a = m;

                m = (a + b) / 2;
            }

            return m;
        }

        // Znajdywanie minimum funkcji metod¹ Newtona
        // Parametry:
        // p1 - pochodna badanej funkcji (typ delegacyjny)
        // p2 - druga pochodna badanej funkcji (typ delegacyjny)
        // a  - dolna granica przedzia³u poszukiwañ
        // Wynik: wartoœæ argumentu funkcji, dla którego osi¹gane jest minimum
        static double Newton(Function p1, Function p2, double a)
        {
            double x0=a;

            do
            {
                 x0 = x0 - p1(x0) / p2(x0);
            } while (Math.Abs(p1(x0))>eps); 

            return x0;
        }

        public static Function Diff1(Pol p)
        {
            return x => (p.Horner(x + eps) - p.Horner(x - eps)) / (2 * eps);
        }

        public static Function Diff2(Pol p)
        {
            return x => (p.Horner(x + eps) - 2 * p.Horner(x) + p.Horner(x - eps)) / (eps * eps);
        }


        //-----------------------------------------------------------------------
        //-----------------------------------------------------------------------
        static void Main()
        {
            Console.WriteLine("----------------   ETAP 1   ------------------------");
            //postaæ: wielomianu, wielomianu pochodnej1 oraz wielomianu pochodnej2

            double[] w = { -10, 5, -5, 1 };
            Pol P = new Pol(w);
            w[0] = 4;
            w[2] = -2;
            Pol Q = new Pol(w);

            // wypisac wielomian P i jego pochodne
            Console.WriteLine(" P(x) = " + P);
            Console.WriteLine("P1(x) = " + P.Diff1());
            Console.WriteLine("P2(x) = " + P.Diff2());

            Console.WriteLine();
            // wypisac wielomian Q i jego pochodne
            Console.WriteLine(" Q(x) = " + Q);
            Console.WriteLine("Q1(x) = " + Q.Diff1());
            Console.WriteLine("Q2(x) = " + Q.Diff2());

            Console.WriteLine();
            Console.WriteLine("----------------   ETAP 2   ------------------------");
            //wartoœci dla: 
            //. wielomian,
            //. pochodna1 (dok³adna i przybli¿ona)
            //. pochodna2 (dok³adna i przybli¿ona)

            double x = 2;
            Console.WriteLine("  P(2) = " + P.Horner(2));
            Console.WriteLine(" P1(2) = " + P.Diff1().Horner(2));
            Console.WriteLine("~P1(2) = " + Diff1(P)(2));
            Console.WriteLine(" P2(2) = " + P.Diff2().Horner(2));
            Console.WriteLine("~P2(2) = " + Diff2(P)(2));

            // wypisac wartosci wielomianu P i jego pochodnych
            // (dokladnych i przyblizonych) dla x=2

            Console.WriteLine();
            Console.WriteLine("----------------   ETAP 3   ------------------------");
            //zastosowania algorytmów: Bisekcja oraz Newton do znalezienia minimum funkcji
            //(przedzia³y i funkcje s¹ tak ustalone, ¿eby nie by³o problemów numerycznych)

            //double a = 2, b = 4;
            //double m_Bisection, m_Newton;
            //Function p1, p2;

            // wypisac znalezione minima wielomianu P wykorzystuj¹c metody bisekcji i Newtona
            // (oraz dokladne i przyblizone pochodne)

            Console.WriteLine();
            Console.WriteLine("----------------   ETAP 4   ------------------------");
            //sumy wielomianów 

            //Function f;
            //Pol wiel;

            //double[] w1 = { 0, 0, 0, 1 };
            //Pol wiel1 = new Pol(w1);
            //double[] w2 = { 0, 0, -5 };
            //Pol wiel2 = new Pol(w2);
            //double[] w3 = { -10, 5 };
            //Pol wiel3 = new Pol(w3);

            Console.WriteLine();
            Console.WriteLine("----------------   ETAP 5   ------------------------");
            //funkcje anonimowe oraz wyr. lambda

        }
   
    }
}

