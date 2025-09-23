namespace Calculator
{
    internal class Program
    {
        static int ValitseLaskutoimitus()
        {
            int valinta;
            int LaskutoimitusTyyppi = 0;
            while (true)
            {
                Console.WriteLine("Valitse Laskutoimitus:");
                Console.WriteLine("1: Yhteenlasku");
                Console.WriteLine("2: Vähennyslasku");
                Console.WriteLine("3: Kertolasku");
                Console.WriteLine("4: Jakolasku");
                Console.Write("Valintasi:");

                if (!int.TryParse(Console.ReadLine(), out valinta))
                {
                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                    continue;
                }
                bool oikeaValinta = false;

                switch (valinta)
                {
                    case 1:
                        if (valinta == 1)
                        {
                            LaskutoimitusTyyppi = 1;
                            oikeaValinta = true;
                        }
                        break;

                    case 2:
                        if (valinta == 2)
                        {
                            LaskutoimitusTyyppi = 2;
                            oikeaValinta = true;
                        }
                        break;

                    case 3:
                        if (valinta == 3)
                        {
                            LaskutoimitusTyyppi = 3;
                            oikeaValinta = true;
                        }
                        break;
                    case 4:
                        if (valinta == 4)
                        {
                            LaskutoimitusTyyppi = 4;
                            oikeaValinta = true;
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                            break;
                        }

                }
                if (oikeaValinta) break;

            }

            return LaskutoimitusTyyppi;


        }
        static double KysyEnsimmainenLuku()
        {
            double num1;

            while (true)
            {
                Console.Write("Syötä ensimmäinen luku: ");
                string lukuSyote = Console.ReadLine();
                if (double.TryParse(lukuSyote, out num1))
                {
                    break;

                }
                else
                    Console.WriteLine("Anna oikeanlainen luku.");

            }
            return num1;


        }

        static double KysyToinenLuku()
        {
            double num2;

            while (true)
            {
                Console.Write("Syötä toinen luku: ");
                string lukuSyote = Console.ReadLine();
                if (double.TryParse(lukuSyote, out num2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Anna oikeanlainen luku.");
                }

            }
            return num2;
        }




        static void Main(string[] args)
        {
            int valinta = ValitseLaskutoimitus();
            double num1 = KysyEnsimmainenLuku();
            double num2 = KysyToinenLuku();


            //tee funktio joka kysyy numeron 1, muista validoita että syöte on numero. Palauta doulbe tyyppinen numero
            //double num1 = AksNumber();

            //double num2 = AskNumber();

            //Tee funktio joka suorittaa operaation
            //Funktio ottaa syötteenä operaatio sekä numerot joille operaatio tehdään

            //double result = CalculateOperation(valinta, num1, num2)
        }

        static double Add(double a, double b)
        {
            return a + b;
        }


    }
}
