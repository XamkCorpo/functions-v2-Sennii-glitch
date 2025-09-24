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
        static double KysyLuku()
        {
            double num1;

            while (true)
            {
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




        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
        static double CalculateOperation(int operation, double num1, double num2)
        {
            double result = 0;

            if (operation == 1)
            {
                result = Add(num1, num2);
            }
            else if (operation == 2)
            {
                result = Subtract(num1, num2);

            }
            else if (operation == 3)
            {
                result = Multiply(num1, num2);
            }
            else if (operation == 4)
            {
                result = Divide(num1, num2);
            }

            return result;
        }
        private static string GetOperationSymbol(int valinta)
        {
            string symbol = "";
            if (valinta == 1)
            {
                symbol = "+";
            }
            else if (valinta == 2)
            {
                symbol = "-";
            }
            else if (valinta == 3)
            {
                symbol = "*";
            }
            else if (valinta == 4)
            {
                symbol = "/";
            }
            return symbol;
        }
        static string TulostaTulos()
        {
            Console.WriteLine($"Tulos: {num1} {GetOperationSymbol} {num2} = {result} ");
            return "";
        }


        static void Main(string[] args)
        {
            int valinta = ValitseLaskutoimitus();

            Console.WriteLine("Anna ensimmäinen luku");
            double num1 = KysyLuku();

            Console.WriteLine("Anna toinen luku");
            double num2 = KysyLuku();


            //tee funktio joka kysyy numeron 1, muista validoita että syöte on numero. Palauta doulbe tyyppinen numero
            //double num1 = AksNumber();

            //double num2 = AskNumber();

            //Tee funktio joka suorittaa operaation
            //Funktio ottaa syötteenä operaatio sekä numerot joille operaatio tehdään

            double result = CalculateOperation(valinta, num1, num2);

            //Muuta valinta numero symbooliksi, tee tälle oma funktio
            //Eli jos numero on 1 niin silloin tiedät, että symboli on +

            string symbol = GetOperationSymbol(valinta);

            //Tulosta tulos
        }








    }
}
