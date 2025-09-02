
namespace GuessTheNumber
{
    class Program()
    {
        static void Main(string[] args) 
        {
            int nPlayers, guess = 0;
            const int MINN = 1;
            const int MAXN = 101;
            const int MAXP = 3;
            const int MINP = 1;
            List<Player> list = new List<Player>();
            Random number = new Random();
            int randomNumber = number.Next(MINN, MAXN);

            //Console.WriteLine(randomNumber);

            do
            {
                Console.WriteLine($"WELCOME TO GUESS THE NUMBER FROM {MINN} TO {MAXN-1} ! Choose the number of players ({MINP}-{MAXP}): ");
                nPlayers = Convert.ToInt16(Console.ReadLine());
            } while(nPlayers > MAXP || nPlayers < MINP);

            for (int i = 1; i <= nPlayers; i++) 
            {
                Console.WriteLine($"Enter the name of player {i}"); 
                string name = Console.ReadLine();
                Player p = new Player(name);
                list.Add(p);
            }

            Console.Clear();

            do
            {
                for (int i = 0; i < nPlayers; i++)
                {
                    Console.WriteLine($"{list[i].Name}'s turn. Enter a number:");
                    guess = Convert.ToInt16(Console.ReadLine());
                    if ( guess == randomNumber)
                    {
                        Console.WriteLine($"Congratulations {list[i].Name}! You guessed number: {randomNumber} ");
                        list[i].Winner = true;
                        break;
                    }
                    else
                    {
                        if ( guess <= randomNumber + 10 && guess >= randomNumber - 10) //Si el número que se introduce está del número a adivinar (con un márgen de 10 por arriba y por abajo) se avisa al jugador
                        {
                            Console.WriteLine("You're getting closer...");
                        }
                        else
                        {
                            Console.WriteLine("Wrong number...");
                        }
                        list[i].Attempts++;
                    }
                }

                Thread.Sleep(2000);
                Console.Clear();

            } while (guess != randomNumber);

            foreach (Player p in list)
            {
                p.ShowStats();
            }
            
            /*foreach (Player p in list) 
            {
                Console.WriteLine(p.Name);
            }*/


        }
    }
}