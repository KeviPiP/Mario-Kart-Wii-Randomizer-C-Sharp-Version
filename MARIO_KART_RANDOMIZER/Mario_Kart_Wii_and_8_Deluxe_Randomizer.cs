using System;
using System.Threading.Tasks;

namespace MARIO_KART_RANDOMIZER
{
    class Mario_Kart_Wii_and_8_Deluxe_Randomizer
    {
        public static void Main(string[] args)
        {
            Mario_Kart_Wii_and_8_Deluxe_Randomizer pick = new Mario_Kart_Wii_and_8_Deluxe_Randomizer();

            while (true)
            {
                Console.WriteLine("Welcome to my Mario Kart Wii/8 Deluxe Randomizers!");
                Console.WriteLine("Type 1 - for Mario Kart Wii Randomizer!");
                Console.WriteLine("Mario Kart 8 Deluxe Randomizer coming soon!");
                // Console.WriteLine("Type 2 - for the Mario Kart 8 Randomizer!");
                string ans = Console.ReadLine();

                if (ans == "1")
                {
                    pick.Mario_Kart_Wii();
                    break;

                }
                else if (ans == "2")
                {
                    // pick.Mario_Kart_8_Deluxe(); // Note: Not yet finished.
                    Console.WriteLine("If you typed 2, you found where the MK8 Randomizer will be ");
                    Console.WriteLine("Sadly it is not yet completed so you have to restart.");
                    continue;
                }
                else
                {
                    Console.WriteLine("That's not a valid option!");
                    continue;
                }
            }




        }

        public void Mario_Kart_Wii()
        {
            MKW_Randomizer picker = new MKW_Randomizer();
            Mario_Kart_Wii_and_8_Deluxe_Randomizer pick = new Mario_Kart_Wii_and_8_Deluxe_Randomizer();

            Console.WriteLine("Type: 1 - To randomize Karts and Bikes");
            Console.WriteLine("Type: 2 - To randomize Karts Only");
            Console.WriteLine("Type: 3 - To randomize Bikes Only");
            var ans = Console.ReadLine();

            if (ans != "1" && ans != "2" && ans != "3")
            {
                Console.WriteLine("That's not a valid option! Try again!");
                Console.WriteLine("=========");
                pick.Mario_Kart_Wii();
            }

            else {} // - Note to self: this is the equivalent to a pass statement in Python.

            int player_num = 1;
            int track_num = 1;

            // calls default randomizer
            if (ans == "1")
            {
                // prints player number, calls character randomizer, then loops
                // until num equals 5
                while (player_num < 5)
                {
                    Console.WriteLine("===========");
                    Console.WriteLine($"Player {player_num}");
                    picker.MKW_Default_Randomizer();
                    player_num += 1;

                    // once player_num equals 5, run the track randomizer
                    if (player_num == 5)
                    {
                        // waits for user to input Y or N to generate new track.
                        while (true)
                        {
                            Console.WriteLine("===========");
                            Console.Write("Randomize new track? Y/N: ");
                            string answer = Console.ReadLine();
                            answer = answer.ToUpper();

                            // uses same logic used to print the player numbers but prints track numbers instead
                            if (answer == "Y")
                            {
                                Console.WriteLine("===========");
                                Console.WriteLine($"Track {track_num}");
                                picker.MKW_Original_Track_Randomizer();
                                track_num += 1;
                            }

                            else if (answer == "N")
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("That wasn't a yes or no answer >:(");
                                continue;
                            }
                        }

                        // if user types N in track randomizer, ask user this
                        Console.WriteLine("===========");
                        Console.Write("Would you like to run the MKW randomizer again? Y/N: ");
                        string restart = Console.ReadLine();
                        restart = restart.ToUpper();

                        // if Y, restart randomizer from beginning
                        if (restart == "Y")
                        {
                            Console.WriteLine("Restarting...");
                            pick.Mario_Kart_Wii();
                        }

                        else
                        {
                            Console.WriteLine("Goodbye...");
                            break;
                        }
                    }
                }
            }

            // calls karts only randomizer. Code is exactly the same as code for the default randomizer.
            // Refer to that if you want to know how these work.
            else if (ans == "2")
            {
                while (player_num < 5)
                {
                    Console.WriteLine("===========");
                    Console.WriteLine($"Player {player_num}");
                    picker.MKW_Random_Karts_Only();
                    player_num += 1;

                    if (player_num == 5)
                    {
                        while (true)
                        {
                            Console.WriteLine("===========");
                            Console.Write("Randomize new track? Y/N: ");
                            string answer = Console.ReadLine();
                            answer = answer.ToUpper();

                            if (answer == "Y")
                            {
                                Console.WriteLine("");
                                Console.WriteLine("===========");
                                Console.WriteLine($"Track {track_num}");
                                picker.MKW_Original_Track_Randomizer();
                                track_num += 1;
                            }

                            else if (answer == "N")
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("That wasn't a yes or no answer >:(");
                                continue;
                            }
                        }

                        Console.WriteLine("===========");
                        Console.Write("Would you like to run the MKW randomizer again? Y/N: ");
                        string restart = Console.ReadLine();
                        restart = restart.ToUpper();

                        if (restart == "Y")
                        {
                            Console.WriteLine("Restarting...");
                            pick.Mario_Kart_Wii();
                        }
                        else
                        {
                            Console.WriteLine("Goodbye...");
                            break;
                        }
                    }
                }
            }

            // calls bikes only randomizer. 
            // Code is exactly the same as code for the default randomizer. Refer to that if you want to know how these work.
            else if (ans == "3")
            {
                while (player_num < 5)
                {
                    Console.WriteLine("===========");
                    Console.WriteLine($"Player {player_num}");
                    picker.MKW_Random_Bikes_Only();
                    player_num += 1;

                    if (player_num == 5)
                    {
                        while (true)
                        {
                            Console.WriteLine("===========");
                            Console.Write("Randomize new track? Y/N: ");
                            string answer = Console.ReadLine();
                            answer = answer.ToUpper();

                            if (answer == "Y")
                            {
                                Console.WriteLine("===========");
                                Console.WriteLine($"Track {track_num}");
                                picker.MKW_Original_Track_Randomizer();
                                track_num += 1;
                            }

                            else if (answer == "N")
                            {
                                break;
                            }

                            else
                            {
                                Console.WriteLine("That wasn't a yes or no answer >:(");
                                continue;
                            }
                        }

                        Console.WriteLine("===========");
                        Console.Write("Would you like to run the MKW randomizer again? Y/N: ");
                        string restart = Console.ReadLine();
                        restart = restart.ToUpper();

                        if (restart == "Y")
                        {
                            Console.WriteLine("Restarting...");
                            pick.Mario_Kart_Wii();
                        }
                        else
                        {
                            Console.WriteLine("Goodbye...");
                            break;
                        }
                    }
                }
            }
        }
    }
}
