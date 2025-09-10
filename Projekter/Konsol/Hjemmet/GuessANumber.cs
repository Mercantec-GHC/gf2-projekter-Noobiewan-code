namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
            {
                Console.WriteLine("Gæt et tal mellem 1 og 100.");
                Random num = new Random();
                int answer = num.Next(1, 101);
                Console.ReadLine();
                Console.Write(answer);
                Console.ReadKey();
            }
        }
    }
}
