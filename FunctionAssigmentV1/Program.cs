namespace FunctionAssigmentV1
{
    internal class Program
    {
        /// <summary>
        /// Ask the user for their name and validate the input
        /// </summary>
        /// <returns>Returns valid input</returns>
        static string KysyNimi()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Name cannot be empty.");
            }

        }
        /// <summary>
        /// Ask user for their age and validate the input
        /// </summary>
        /// <returns>Returns valid input</returns>
        static int KysyIka()
        {
            int age = 0;
            while (true)
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    return age;
                Console.WriteLine("Please enter a positive integer.");
            }

        }
        /// <summary>
        /// Print users name and age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void Tulostanimijaika(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        /// <summary>
        /// Check if user is an adult
        /// </summary>
        /// <param name="age"></param>
        /// <returns>true/false</returns>
        static bool TarkistaTaysiIkainen(int age)
        {
            return age >= 18;
        }
        /// <summary>
        /// Compares users name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareTo"></param>
        static void VertaaNimea(string name, string compareTo)
        {
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensitive).");
            if (name.Equals(compareTo))
                Console.WriteLine($"Your name is exactly '{compareTo}' (case-sensitive).");
        }
        static void Main(string[] args)
        {
            string name = KysyNimi();
            int age = KysyIka();

            Tulostanimijaika(name, age);


            bool isFullAge = TarkistaTaysiIkainen(age);
            if (isFullAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }

            VertaaNimea(name, "Matti");


        }
    }
}