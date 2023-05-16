namespace Snake_and_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Snake and Ladder Problem ");

            // player's start position:

            int Player1_position = 0;
            int Player1_numberOfRolls = 0;

            Console.WriteLine("Press anything to start");

            Random random = new Random();

            while (Player1_position < 100)
            {

                int Player1_diceRoll = random.Next(1, 7);
                Player1_numberOfRolls++;

                Console.WriteLine(" Player 1 Rolled: " + Player1_diceRoll);

                int Player1_option = random.Next(0, 3);
                switch (Player1_option)
                {
                    case 0: // There is No Play
                        Console.WriteLine(" There is No Play");
                        break;

                    case 1: // Ladder
                        Player1_position += Player1_diceRoll;
                        Console.WriteLine("Ladder!");
                        break;

                    case 2: // Snake
                        Player1_position -= Player1_diceRoll;
                        Console.WriteLine("Snake!!");
                        break;
                }

                if (Player1_position < 0)
                   { Player1_position = 0; }

                    Console.WriteLine("The position for Player 1 is : " + Player1_position);
                    Console.ReadLine();
            }
        }
    }
}