using System;

class Program
{
    public static void Main(string[] args)
    {
        int room = 1; //This keeps track of what room the player is in. 
        string response = ""; //This keeps track of what the player wants to do
        bool gameFinished = false;
        bool hasKey = false;

        //While they are still playing let them type in new responses
        while (gameFinished == false)
        {
            Console.WriteLine("You go to the local gas station, do you get coke or pepsi?");
            response = Console.ReadLine();

            if (response.Equals("coke"))
            {
                Console.WriteLine("You walk up to the restiture and the cashier says 2 dollars please. Do You give him your moeney?");
                response = Console.ReadLine();
                {
                    if (response.Equals("yes"))
                    {
                        Console.WriteLine("You made it out of the gas station and back home.");
                        {
                            gameFinished = true;
                        }
                        
                    }
                    if (response.Equals("no"))
                    {
                        Console.WriteLine("You end up in the back of a police car.");
                        {
                            gameFinished = true;
                        }

                    }
                }
            }
            if (response.Equals("pepsi"))
            {
                Console.WriteLine("You walk up to the restiture and the cashier gives you a discusted look and says 2 dollars please. Do You give him your moeney?");
            }
            {
                if (response.Equals("yes"))
                {
                    Console.WriteLine("You made it out of the gas station and back home.");
                    response = Console.ReadLine();
                    {
                        gameFinished = true;
                    }

                }
                if (response.Equals("no"))
                {
                    Console.WriteLine("You end up in the back of a police car.");
                    {
                        gameFinished = true;
                    }

                }
            }

        }
    }
}

