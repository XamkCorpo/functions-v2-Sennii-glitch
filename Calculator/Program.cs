namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Kysyy käyttäjältä laskutoimitustyypin
        /// </summary>
        /// <returns>laskutoimitustyyppi</returns>
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
        /// <summary>
        /// Kysyy käyttäjältä numeron
        /// </summary>
        /// <returns>number</returns>
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



        /// <summary>
        /// Plussalasku
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        static double Add(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// miinuslasku
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a-b</returns>
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// kertolasku
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a*b</returns>
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// jakolasku
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a/b</returns>
        static double Divide(double a, double b)
        {
            return a / b;
        }
        /// <summary>
        /// Laskee laskutoimituksen
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>tulos</returns>
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
        /// <summary>
        /// Muuttaa symboliksi
        /// </summary>
        /// <param name="valinta"></param>
        /// <returns>symboli</returns>
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
        /// <summary>
        /// Tulostaa tuloksen
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="symbol"></param>
        /// <param name="result"></param>
        static void TulostaTulos(double num1, double num2, string symbol, double result)
        {
            Console.WriteLine($"Tulos: {num1} {symbol} {num2} = {result} ");
        }


        static void Main(string[] args)
        {
            int valinta = ValitseLaskutoimitus();

            Console.WriteLine("Anna ensimmäinen luku");
            double num1 = KysyLuku();

            Console.WriteLine("Anna toinen luku");
            double num2 = KysyLuku();


            

            double result = CalculateOperation(valinta, num1, num2);

            

            string symbol = GetOperationSymbol(valinta);

            
            TulostaTulos(num1, num2, symbol, result);
        }








    }
}
