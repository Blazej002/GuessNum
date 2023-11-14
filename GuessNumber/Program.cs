namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool win = false;
            int ranNumber = genNum();
            Console.WriteLine("Hi!! Welcome!");
            Console.WriteLine("Guess the number");
            Console.WriteLine(ranNumber);
            while (!win)
            {
                Console.WriteLine("_________");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                
                win = checkIf(ranNumber, userGuess);
                
                if (win == false)
                {
                    Console.WriteLine("Wrong");
                    continue;
                }

                Console.WriteLine("_______________________");
                Console.WriteLine("_______________________");
                Console.WriteLine("You're correct, congrats.");
                Console.WriteLine($"The number was {ranNumber}");
            }
        }

        static public int genNum()
        {
            Random ran = new Random();

            int ranNum = ran.Next(1, 100);
            return ranNum;
        }

        static public bool checkIf(int x, int y)
        {
            if (x == y)
            {
                return true;
            }

            return false;
        }
    }
}