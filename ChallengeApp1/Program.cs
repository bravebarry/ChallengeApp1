namespace ChallengeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj płeć (Kobieta/Mężczyzna):");
            string gender = Console.ReadLine();
            Console.WriteLine("Podaj wiek:");
            int age = int.Parse(Console.ReadLine());

            if (gender == "Kobieta" && age < 30)
            {
                Console.WriteLine("Kobieta poniżej 30 lat");
            }
            else if (name == "Ewa" && age == 33)
            {
                Console.WriteLine("Ewa, lat 33");
            }
            else if (gender == "Mężczyzna" && age < 18)
            {
                Console.WriteLine("Niepełnoletni Mężczyzna");
            }
        }
    }
}