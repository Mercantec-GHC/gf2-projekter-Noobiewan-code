namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            {

                {

                    Console.WriteLine("Gæt et tal mellem 1 og 100.");

                    Random num = new Random();

                    int answer = num.Next(1, 100);

                    Console.ReadLine();

                    Console.Write(answer);

                    Console.ReadKey();

                }

            }
 

            {

                static void Main(string[] args)

                {

                    Console.WriteLine("Gæt et tal mellem 1 og 100.");

                    Random num = new Random();

                    int answer = num.Next(1, 100);

                    int guess = 0;

                    int attempts = 0;

                    while (guess != answer)

                    {

                        Console.Write("Indtast dit gæt: ");

                        string input = Console.ReadLine();

                        if (int.TryParse(input, out guess))

                        {

                            attempts++;

                            if (guess < answer)

                            {

                                Console.WriteLine("For lavt! Prøv igen.");

                            }

                            else if (guess > answer)

                            {

                                Console.WriteLine("For højt! Prøv igen.");

                            }

                            else

                            {

                                Console.WriteLine($"Tillykke! Du gættede rigtigt på {attempts} forsøg.");

                            }

                        }

                        else

                        {

                            Console.WriteLine("Ugyldigt input. Indtast venligst et tal mellem 1 og 100.");

                        }

                    }

                }

            }
        }
    } 
}
