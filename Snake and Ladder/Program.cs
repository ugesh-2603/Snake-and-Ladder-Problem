namespace Snake_and_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Snake and Ladder Problem ");

            Console.WriteLine("Press anything to start");

            int Player1_position = 0; // player 1's starting position
            int Player1_numberOfRolls = 0; // number of times the dice was rolled
            int Player2_position = 0; // player 1's starting position
            int Player2_numberOfRolls = 0; // number of times the dice was rolled
            int Turn = 1; // 0 means Stop, 1 means player 1, 2 means player 2

            Random random = new Random();

            //Pl1_position < 100

            while (Turn == 1 || Turn == 2)
            {
                Console.WriteLine("==================");
                int Player1_diceRoll = random.Next(1, 7);
                int Player2_diceRoll = random.Next(1, 7);

                if (Turn == 1)
                {
                    Player1_numberOfRolls++;
                    Console.WriteLine(" Player 1 Rolled the dice : " + Player1_diceRoll);

                    int Player1_option = random.Next(0, 3);
                    switch (Player1_option)
                    {
                        case 0: // There is no Play
                            Console.WriteLine("There is no Play");
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

                    if (Player1_position > 100)
                    {
                        //Player1_position = 100;
                        int diff = Player1_position - 100;
                        Player1_position = -diff;
                    }


                    Console.WriteLine("The position for Player 1 is : " + Player1_position);
                    if (Player1_position == 100)
                    {
                        Console.WriteLine("The Player 1 Has Won, after total " + Player1_numberOfRolls + " rolls");
                        Turn = 0;
                    }
                    else
                    {
                        if (Player1_option != 1)
                        {
                            Turn = 2;
                        }
                    }

                }
                else if (Turn == 2)
                {
                    Player2_numberOfRolls++;
                    Console.WriteLine("Player 2 Rolled the dice : " + Player2_diceRoll);

                    int Player2_option = random.Next(0, 3);
                    switch (Player2_option)
                    {
                        case 0: // There is no Play
                            Console.WriteLine("There is no Play");
                            break;
                        case 1: // Ladder
                            Player2_position += Player2_diceRoll;
                            Console.WriteLine("Ladder!");
                            break;
                        case 2: // Snake
                            Player2_position -= Player2_diceRoll;
                            Console.WriteLine("Snake!!");
                            break;
                    }

                    if (Player2_position < 0)
                    { Player2_position = 0; }

                    if (Player2_position > 100)
                    {
                        //Player2_position = 100; 
                        int diff = Player2_position - 100;
                        Player2_position = -diff;

                    }


                    Console.WriteLine("The position for Player 2 is : " + Player2_position);
                    if (Player2_position == 100)
                    {
                        Console.WriteLine("The Player 2 Has Won, after total " + Player2_numberOfRolls + " rolls");
                        Turn = 0;
                    }
                    else
                    {
                        if (Player2_option != 1)
                        {
                            Turn = 1;
                        }
                    }
                }
                Console.WriteLine("----------------");
            }
            Console.WriteLine(" \\\\\\ THE GAME IS SUCCESSFULLY COMPLETED ////// ");
        }
    }
}