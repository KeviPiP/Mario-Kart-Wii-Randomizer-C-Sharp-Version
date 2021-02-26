using System;
using System.Collections.Generic;
using System.Text;

namespace MARIO_KART_RANDOMIZER
{
    class MKW_8_Deluxe_Randomizer
    {
        static readonly MKW_8_Deluxe_Randomizer picker = new MKW_8_Deluxe_Randomizer();
        
        // initialising random as field so it can be used everywhere
        static readonly Random rand = new Random();

        public void Mario_Kart_8_Deluxe_All_Characters()
        {
            string[] all_characters = {
                                        "Mario", "Luigi", "Peach", "Daisy", "Rosalina", "Tanooki Mario", "Cat Peach",
                                        "Yoshi", "Toad", "Koopa Troopa", "Shy Guy", "Lakitu", "Toadette", "King Boo",
                                        "Baby Mario", "Baby Luigi", "Baby Peach", "Baby Daisy", "Baby Rosalina", "Metal Mario",
                                        "Pink Gold Peach", "Wario", "Waluigi", "Donkey Kong", "Bowser", "Dry Bones", "Bowser Jr.", 
                                        "Dry Bowser", "Lemmy", "Larry", "Wendy", "Ludwig", "Iggy", "Roy", "Morton", "Inkling Girl", 
                                        "Inkling Boy", "Link", "Villager", "Villager (Girl)", "Isabelle", "Mii"
                                      };

            // generating random number to be able to pick from character list
            int character_pick = rand.Next(0, 41);

            // picking random character based on random number generated
            Console.WriteLine("============");
            Console.WriteLine("Character");
            Console.WriteLine(all_characters[character_pick]);
            Console.WriteLine("============");
        }

        public void Mario_Kart_8_Deluxe_Default_Randomizer()
        {
            string[] all_gliders = {"Super Glider", "Peach Parasol", "Parafoil", "Flower Glider", "Gold Glider",
                                    "Cloud Glider", "Wario Wing", "Waddle Wing", "Parachute", "Bowser Kite",
                                    "Plane Glider", "MKTV Parafoil", "Hylian Kite", "Paper Glider", "Paraglider"};

            string[] all_wheels = {"Standard", "Monster", "Roller", "Slim", "Slick", "Metal",
                                   "Button", "Off-Road", "Sponge", "Wood", "Cushion", "Blue Standard",
                                   "Hot Monster", "Azure Roller", "Crimson Slim", "Cyber Slick", "Retro Off-Road",
                                   "Gold Tires", "GLA Tires", "Triforce Tires", "Leaf Tires", "Ancient Tires"};

            string[] all_bodies = {"Standard Kart", "Pipe Frame", "Mach 8", "Steel Driver", "Cat Cruiser", "Circuit Special",
                                   "Tri-Speeder", "Badwagon", "Prancer", "Biddybuggy", "Landship", "Sneeker",
                                   "Sports Coupe", "Gold Standard", "GLA", "W 25 Silver Arrow", "300 SL Roadster", "Blue Falcon",
                                   "Tanooki Kart", "B Dasher", "Streetle", "P-Wing", "Koopa Clown", "Standard Bike",
                                   "The Duke", "Flame Rider", " Varmint", "Mr. Scooty", "City Tripper", "Master Cycle Zero"};

            // generating random number to be able to pick from all lists
            int glider_pick = rand.Next(0, 14);
            int wheel_pick = rand.Next(0, 21);
            int body_pick = rand.Next(0, 21);

            // picking random character based on random number generated
            picker.Mario_Kart_8_Deluxe_All_Characters();
            Console.WriteLine("Glider");
            Console.WriteLine(all_gliders[glider_pick]);
            Console.WriteLine("============");
            Console.WriteLine("Vehicle Body");
            Console.WriteLine(all_bodies[body_pick]);
            Console.WriteLine("============");
            Console.WriteLine("Wheels");
            Console.WriteLine(all_wheels[wheel_pick]);
            Console.WriteLine("============");
        }

        public void Mario_Kart_8_Deluxe_Gliders_Only()
        {
            string[] all_gliders = {"Super Glider", "Peach Parasol", "Parafoil", "Flower Glider", "Gold Glider",
                                    "Cloud Glider", "Wario Wing", "Waddle Wing", "Parachute", "Bowser Kite",
                                    "Plane Glider", "MKTV Parafoil", "Hylian Kite", "Paper Glider", "Paraglider"};

            // generating random number to be able to pick from character list
            int glider_pick = rand.Next(0, 14);

            // picking random character and glider based on random number generated
            picker.Mario_Kart_8_Deluxe_All_Characters();
            Console.WriteLine("Glider");
            Console.WriteLine(all_gliders[glider_pick]);
            Console.WriteLine("============");
        }

        public void Mario_Kart_8_Deluxe_Wheels_Only()
        {
            string[] all_wheels = {"Standard", "Monster", "Roller", "Slim", "Slick", "Metal",
                                   "Button", "Off-Road", "Sponge", "Wood", "Cushion", "Blue Standard",
                                   "Hot Monster", "Azure Roller", "Crimson Slim", "Cyber Slick", "Retro Off-Road",
                                   "Gold Tires", "GLA Tires", "Triforce Tires", "Leaf Tires", "Ancient Tires"};

            // generating random number to be able to pick from character list
            int wheel_pick = rand.Next(0, 21);

            // picking random character and wheel based on random number generated
            picker.Mario_Kart_8_Deluxe_All_Characters();
            Console.WriteLine("Tires");
            Console.WriteLine(all_wheels[wheel_pick]);
            Console.WriteLine("============");
        }

        public void Mario_Kart_8_Deluxe_Bodies_Only()
        {
            string[] all_bodies = {"Standard Kart", "Pipe Frame", "Mach 8", "Steel Driver", "Cat Cruiser", "Circuit Special",
                                   "Tri-Speeder", "Badwagon", "Prancer", "Biddybuggy", "Landship", "Sneeker",
                                   "Sports Coupe", "Gold Standard", "GLA", "W 25 Silver Arrow", "300 SL Roadster", "Blue Falcon",
                                   "Tanooki Kart", "B Dasher", "Streetle", "P-Wing", "Koopa Clown", "Standard Bike",
                                   "The Duke", "Flame Rider", " Varmint", "Mr. Scooty", "City Tripper", "Master Cycle Zero"};

            // generating random number to be able to pick from character list
            int body_pick = rand.Next(0, 21);

            // picking random character and vehicle body based on random number generated
            picker.Mario_Kart_8_Deluxe_All_Characters();
            Console.WriteLine("Vehicle Body");
            Console.WriteLine(all_bodies[body_pick]);
            Console.WriteLine("============");
        }

        public void Mario_Kart_8_Deluxe_Random_Track_Picker()
        {

            string[] cups = {
                             "Mushroom Cup", "Flower Cup", "Star Cup", "Special Cup", "Egg Cup", "Crossing Cup",
                             "Shell Cup", "Banana Cup", "Leaf Cup", "Lightning Cup", "Triforce Cup", "Bell Cup"
                            };

            int random_cup = rand.Next(0, 11);
            string pick_random_cup = cups[random_cup];

            string[] mushroom_cup = {"Mario Kart Stadium", "Water Park", "Sweet Sweet Canyon", "Thwomp Ruins"};

            string[] flower_cup = {"Mario Circuit", "Toad Harbor", "Twisted Mansion", "Shy Guy Falls"};

            string[] star_cup = {"Sunshine Airport", "Dolphin Shoals", "Electrodrome", "Mount Wario"};

            string[] special_cup = {"Cloudtop Cruise", "Bone-Dry Dunes", "Bowser's Castle", "Rainbow Road"};

            string[] egg_cup = {"GCN Yoshi Circuit", "Excitebike Arena", "Dragon Driftway", "Mute City"};

            string[] crossing_cup = {"GCN Baby Park", "GCN Cheese Land", "Wild Woods", "Animal Crossing"};

            string[] shell_cup = {"Wii Moo Moo Meadows", "GBA Mario Circuit", "DS Cheep Cheep Beach", "N64 Toad's Turnpike"};

            string[] banana_cup = {"GCN Dry Dry Desert", "SNES Donut Plains 3", "N64 Royal Raceway", "3DS DK Jungle"};

            string[] leaf_cup = {"DS Wario Stadium", "GCN Sherbet Land", "3DS Music Park/Melody Motorway", "N64 Yoshi Valley"};

            string[] lightning_cup = {"DS Tick-Tock Clock", "3DS Piranha Plant Slide/Pipeway", "Wii Grumble Volcano", "N64 Rainbow Road"};

            string[] triforce_cup = {"Wii Wario's Gold Mine", "SNES Rainbow Road", "Ice Ice Outpost", "Hyrule Circuit"};

            string[] bell_cup = {"3DS Neo Bowser City/Koopa City", "GBA Ribbon Road", "Super Bell Subway", "Big Blue"};

            int random_track = rand.Next(0, 3);

            switch (pick_random_cup)
            {
                case "Mushroom Cup":
                    string pick_random_mushroom_track = mushroom_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_mushroom_track);
                    break;


                case "Flower Cup":
                    string pick_random_flower_track = flower_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_flower_track);
                    break;


                case "Star Cup":
                    string pick_random_star_track = star_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_star_track);
                    break;

                case "Special Cup":
                    string pick_random_special_track = special_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_special_track);
                    break;


                case "Egg Cup":
                    string pick_random_egg_track = egg_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_egg_track);
                    break;


                case "Crossing Cup":
                    string pick_random_crossing_track = crossing_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_crossing_track);
                    break;


                case "Shell Cup":
                    string pick_random_shell_track = shell_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_shell_track);
                    break;


                case "Banana Cup":
                    string pick_random_banana_track = banana_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_banana_track);
                    break;


                case "Leaf Cup":
                    string pick_random_leaf_track = leaf_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_leaf_track);
                    break;


                case "Lightning Cup":
                    string pick_random_lightning_track = lightning_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_lightning_track);
                    break;


                case "Triforce Cup":
                    string pick_random_triforce_track = triforce_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_triforce_track);
                    break;


                case "Bell Cup":
                    string pick_random_bell_track = bell_cup[random_track];
                    Console.WriteLine(pick_random_cup);
                    Console.WriteLine(pick_random_bell_track);
                    break;
                
                default:
                    Console.WriteLine("Can't pick track! :(");
                    Console.WriteLine("Restart please!");
                    break;
            }
        }
    }
}
