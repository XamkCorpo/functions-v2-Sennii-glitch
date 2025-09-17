namespace FunctionAssigmentV1
{
    internal class Program
    {
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
        static void Tulostanimijaika(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        static bool TarkistaTaysiIkainen(int age)
        {

            return age >= 18;
        }
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
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");
            VertaaNimea(name, "Matti");



        }
    }
}