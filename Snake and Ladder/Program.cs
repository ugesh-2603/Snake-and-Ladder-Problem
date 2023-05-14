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

            int Player1_diceRoll = random.Next(1, 7);
            Player1_numberOfRolls++;

            Console.WriteLine(" Player 1 Rolled: " + Player1_diceRoll);

            int Player1_option = random.Next(0, 3);
            switch (Player1_option)
            {
                case 0: // No Play
                    Console.WriteLine("No Play");
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

            Console.WriteLine("The position for Player 1 is : " + Player1_position);
            Console.ReadLine();
        }
    }
}