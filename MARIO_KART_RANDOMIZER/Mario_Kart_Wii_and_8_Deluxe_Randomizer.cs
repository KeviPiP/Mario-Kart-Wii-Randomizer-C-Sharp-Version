using System;

namespace MARIO_KART_RANDOMIZER
{
    class Mario_Kart_Wii_and_8_Deluxe_Randomizer
    {
        static readonly Mario_Kart_Wii_and_8_Deluxe_Randomizer pick = new Mario_Kart_Wii_and_8_Deluxe_Randomizer();
        static readonly MKW_Randomizer MKW_pick = new MKW_Randomizer();
        static readonly MKW_8_Deluxe_Randomizer MK8_Deluxe_Pick = new MKW_8_Deluxe_Randomizer();

        public static void Main(string[] args)
        {
            // Start Main program
            pick.Start_Program();
        }

        public void Start_Program()
        {
            while (true)
            {
                Console.WriteLine("Welcome to my Mario Kart Wii/8 Deluxe Randomizers!");
                Console.WriteLine("This assumes you have everything unlocked in both games!");
                Console.WriteLine("");
                Console.WriteLine("Type 1 - for the Mario Kart Wii Randomizer!");
                Console.WriteLine("Type 2 - for the Mario Kart 8 Deluxe Randomizer!");
                Console.WriteLine("Type 3 - to exit.");
                string pick_randomizer = Console.ReadLine();

                if (pick_randomizer == "1")
                {
                    pick.Mario_Kart_Wii();
                    break;

                }

                else if (pick_randomizer == "2")
                {
                    pick.Mario_Kart_8_Deluxe();
                    break;
                }

                else if (pick_randomizer == "3")
                {
                    Console.WriteLine("Goodbye...");
                    break;
                }

                else
                {
                    Console.WriteLine("That's not a valid option!");
                    continue;
                }
            }
        }

        // this class was made to clean up the code a little so I'm not just reusing code over and over again. It just looked ugly to me.
        // this is the track num printer, track randomizer, and reset randomizer option all in one class.
        public void MKW_Track_Randomizer_and_Reset_Randomizer()
        {
            int track_num = 1;

            while (true)
            {
                // waits for user to input Y or N to generate new track.
                Console.WriteLine("===========");
                Console.Write("Randomize new track? Y/N: ");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    // uses same logic used for printing the player numbers but prints track numbers instead
                    Console.WriteLine("===========");
                    Console.WriteLine($"Track {track_num}");
                    MKW_pick.MKW_Original_Track_Randomizer();
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
            Console.WriteLine("");
            Console.Write("Would you like to run the MKW randomizer again? Y/N: ");
            string restart = Console.ReadLine();
            restart = restart.ToUpper();

            if (restart == "Y")
            {
                Console.WriteLine("Restarting MKW Randomizer...");
                pick.Mario_Kart_Wii();
            }
            else
            {
                Console.WriteLine("Restarting Program...");
                Console.WriteLine("");
                pick.Start_Program();
            }
        }

        public void Mario_Kart_Wii()
        {
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

            else { } // - Note to self: this is the equivalent to a pass statement in Python.

            int player_num = 1;

            // calls default randomizer
            if (ans == "1")
            {
                // prints player number, calls character randomizer, then loops
                // until num equals 5
                while (player_num < 5)
                {
                    Console.WriteLine("===========");
                    Console.WriteLine($"Player {player_num}");
                    MKW_pick.MKW_Default_Randomizer();
                    player_num += 1;

                    // once player_num equals 5, run the track randomizer
                    if (player_num == 5)
                    {
                        pick.MKW_Track_Randomizer_and_Reset_Randomizer();
                    }
                }
            }

            // calls karts only randomizer.
            else if (ans == "2")
            {
                while (player_num < 5)
                {
                    Console.WriteLine("===========");
                    Console.WriteLine($"Player {player_num}");
                    MKW_pick.MKW_Random_Karts_Only();
                    player_num += 1;

                    if (player_num == 5)
                    {
                        pick.MKW_Track_Randomizer_and_Reset_Randomizer();
                    }
                }
            }

            // calls bikes only randomizer.
            else if (ans == "3")
            {
                while (player_num < 5)
                {
                    Console.WriteLine("===========");
                    Console.WriteLine($"Player {player_num}");
                    MKW_pick.MKW_Random_Bikes_Only();
                    player_num += 1;

                    if (player_num == 5)
                    {
                        pick.MKW_Track_Randomizer_and_Reset_Randomizer();
                    }

                }
            }
        }

        public void MK8_Deluxe_Track_Randomizer_and_Reset_Randomizer()
        {
            int track_num = 1;

            while (true)
            {
                // waits for user to input Y or N to generate new track.
                Console.WriteLine("============");
                Console.Write("Randomize new track? Y/N: ");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    // uses same logic used for printing the player numbers but prints track numbers instead
                    Console.WriteLine("============");
                    Console.WriteLine($"Track {track_num}");
                    MK8_Deluxe_Pick.Mario_Kart_8_Deluxe_Random_Track_Picker();
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
            Console.WriteLine("");
            Console.Write("Would you like to run the MK8_Deluxe randomizer again? Y/N: ");
            string restart = Console.ReadLine();
            restart = restart.ToUpper();

            if (restart == "Y")
            {
                Console.WriteLine("Restarting MK8 Deluxe Randomizer...");
                pick.Mario_Kart_8_Deluxe();
            }
            else
            {
                Console.WriteLine("Restarting Program...");
                Console.WriteLine("");
                pick.Start_Program();
            }
        }

        public void Mario_Kart_8_Deluxe()
        {
            //
            Console.WriteLine("Type: 1 - To randomize all");
            Console.WriteLine("Type: 2 - To randomize only gliders");
            Console.WriteLine("Type: 3 - To randomize only wheels");
            Console.WriteLine("Type: 4 - To randomize only bodies");
            var ans = Console.ReadLine();

            if (ans != "1" && ans != "2" && ans != "3" && ans != "4")
            {
                Console.WriteLine("That's not a valid option! Try again!");
                Console.WriteLine("============");
                pick.Mario_Kart_8_Deluxe();
            }

            else { }

            int player_num = 1;

            if (ans == "1")
            {
                Console.WriteLine("============");
                while (player_num < 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Player {player_num}");
                    Console.WriteLine("");
                    MK8_Deluxe_Pick.Mario_Kart_8_Deluxe_Default_Randomizer();
                    player_num += 1;

                    // once player_num equals 5, run the track randomizer
                    if (player_num == 5)
                    {
                        MK8_Deluxe_Track_Randomizer_and_Reset_Randomizer();
                    }
                }
            }

            if (ans == "2")
            {
                while (player_num < 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Player {player_num}");
                    Console.WriteLine("");
                    MK8_Deluxe_Pick.Mario_Kart_8_Deluxe_Gliders_Only();
                    player_num += 1;

                    // once player_num equals 5, run the track randomizer
                    if (player_num == 5)
                    {
                        MK8_Deluxe_Track_Randomizer_and_Reset_Randomizer();
                    }
                }
            }

            if (ans == "3")
            {
                while (player_num < 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Player {player_num}");
                    Console.WriteLine("");
                    MK8_Deluxe_Pick.Mario_Kart_8_Deluxe_Wheels_Only();
                    player_num += 1;

                    // once player_num equals 5, run the track randomizer
                    if (player_num == 5)
                    {
                        MK8_Deluxe_Track_Randomizer_and_Reset_Randomizer();
                    }
                }
            }

            if (ans == "4")
            {
                while (player_num < 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Player {player_num}");
                    Console.WriteLine("");
                    MK8_Deluxe_Pick.Mario_Kart_8_Deluxe_Bodies_Only();
                    player_num += 1;

                    // once player_num equals 5, run the track randomizer
                    if (player_num == 5)
                    {
                        MK8_Deluxe_Track_Randomizer_and_Reset_Randomizer();
                    }
                }
            }
        }
    }
}
