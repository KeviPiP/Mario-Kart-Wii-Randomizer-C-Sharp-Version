using System;
using System.Collections.Generic;
using System.Text;

namespace MARIO_KART_RANDOMIZER
{
    public class MKW_Randomizer
    {
        public void MKW_Default_Randomizer()
        {
            Random rnd = new Random();

            // weight classes
            string[] classy = { "Light_Weight", "Medium_Weight", "Heavy Weight" };
            
            // choosing a random weight class from list
            int pick_num = rnd.Next(0, 2);
            string class_pick = classy[pick_num];

            // initilizing the random character and vehicle picker
            int character_pick = rnd.Next(0, 7);
            int vehicle_pick = rnd.Next(0, 11);

            // Characters and Vehicle lists for randomizer to choose from

            // Lightweight Characters and Vehicles
            string[] light_weight_characters = { 
                                                "Baby Mario", "Baby Luigi", "Baby Peach", "Baby Daisy", 
                                                "Toad", "Toadette", "Koopa Troopa", "Dry Bones"
                                               };
            
            string[] light_weight_vehicles = {
                                              "Standard Bike S (Small Bike)", "Magikruiser (Small Bike)", "Quacker (Small Bike)",
                                              "Jet Bubble (Small Bike)", "Bit Bike (Small Bike)", "Bullet Bike (Small Bike)",
                                              "Standard Kart S (Small Kart)", "Mini Beast (Small Kart)", "Tiny Titan (Small Kart)",
                                              "Blue Falcon (Small Kart)", "Cheep Charger (Small Kart)", "Booster Seat (Small Kart)"
                                              };

            // Medium Weight Characters and Vehicles 
            string[] medium_weight_characters = {
                                                 "Mario", "Luigi", "Peach", "Daisy", 
                                                 "Yoshi", "Birdo", "Diddy Kong", "Bowser Jr."
                                                };
            
            string[] medium_weight_vehicles = {
                                               "Standard Bike M (Medium Bike)", "Sugarscoot (Medium Bike)", "Sneakster (Medium Bike)",
                                               "Dolphin Dasher (Medium Bike)", "Zip Zip (Medium Bike)", "Mach Bike (Medium Bike)",
                                               "Standard Kart M (Medium Kart)", "Sprinter (Medium Kart)", "Daytripper (Medium Kart)",
                                               "Wild Wing (Medium Kart)", "Super Blooper (Medium Kart)", "Classic Dragster (Medium Kart)"
                                               };

            // Heavy Weight Character and Vehicles
            string[] heavy_weight_characters = {
                                                "Wario", "Waluigi", "Donkey Kong", "Bowser",
                                                "King Boo", "Rosalina", "Donkey Kong", "Dry Bowser"
                                                };
            string[] heavy_weight_vehicles = {
                                              "Standard Bike L (Heavy Bike)", "Wario Bike (Heavy Bike)", "Shooting Star (Heavy Bike)",
                                              "Flame Runner (Heavy Bike)", "Spear (Heavy Bike)", "Phantom (Heavy Bike)",
                                              "Standard Kart L (Heavy Kart)", "Offroader (Heavy Kart)", "Flame Flyer (Heavy Kart)",
                                              "Jetsetter (Heavy Kart)", "Honeycoupe (Heavy Kart)", "Piranha Prowler (Heavy Kart)"
                                             };

            // choosing a random character and vehicle based on what class was chosen
            switch (class_pick)
            {
                case "Light_Weight":
                    string light_character_chosen = light_weight_characters[character_pick];
                    string light_vehicle_chosen = light_weight_vehicles[vehicle_pick];
                    Console.WriteLine(light_character_chosen);
                    Console.WriteLine(light_vehicle_chosen);
                    break;

                case "Medium_Weight":
                    string med_character_chosen = medium_weight_characters[character_pick];
                    string med_vehicle_chosen = medium_weight_vehicles[vehicle_pick];
                    Console.WriteLine(med_character_chosen);
                    Console.WriteLine(med_vehicle_chosen);
                    break;

                case "Heavy_Weight":
                    string heavy_character_chosen = heavy_weight_characters[character_pick];
                    string heavy_vehicle_chosen = heavy_weight_vehicles[vehicle_pick];
                    Console.WriteLine(heavy_character_chosen);
                    Console.WriteLine(heavy_vehicle_chosen);
                    break;
                
                default:
                    Console.WriteLine("ERROR: Could not choose class!");
                    Console.WriteLine("Restart program!");
                    break;
            }

        }

        public void MKW_Random_Karts_Only()
        {
            Random rnd = new Random();

            // weight classes
            string[] weight_classes = { "Light_Weight", "Medium_Weight", "Heavy Weight" };

            // choosing a random weight class from list
            int pick_num = rnd.Next(0, 2);
            string class_pick = weight_classes[pick_num];

            // initilizing the random character and vehicle picker
            int character_pick = rnd.Next(0, 7);
            int vehicle_pick = rnd.Next(0, 5);

            // Characters and Vehicle lists for randomizer to choose from

            // Lightweight Characters and Karts
            string[] light_weight_characters = {
                                                "Baby Mario", "Baby Luigi", "Baby Peach", "Baby Daisy",
                                                "Toad", "Toadette", "Koopa Troopa", "Dry Bones"
                                               };

            string[] light_weight_karts = {
                                           "Standard Kart S (Small Kart)", "Mini Beast (Small Kart)", "Tiny Titan (Small Kart)",
                                            "Blue Falcon (Small Kart)", "Cheep Charger (Small Kart)", "Booster Seat (Small Kart)"
                                           };

            // Medium Weight Characters and Karts
            string[] medium_weight_characters = {
                                                 "Mario", "Luigi", "Peach", "Daisy",
                                                 "Yoshi", "Birdo", "Diddy Kong", "Bowser Jr."
                                                };

            string[] medium_weight_karts = {
                                            "Standard Kart M (Medium Kart)", "Sprinter (Medium Kart)", "Daytripper (Medium Kart)",
                                            "Wild Wing (Medium Kart)", "Super Blooper (Medium Kart)", "Classic Dragster (Medium Kart)"
                                            };

            // Heavy Weight Character and Vehicles
            string[] heavy_weight_characters = {
                                                "Wario", "Waluigi", "Donkey Kong", "Bowser",
                                                "King Boo", "Rosalina", "Donkey Kong", "Dry Bowser"
                                                };

            string[] heavy_weight_karts = {
                                         "Standard Kart L (Heavy Kart)", "Offroader (Heavy Kart)", "Flame Flyer (Heavy Kart)",
                                         "Jetsetter (Heavy Kart)", "Honeycoupe (Heavy Kart)", "Piranha Prowler (Heavy Kart)"
                                          };

            // choosing a random character and vehicle based on what class was chosen

            switch (class_pick)
            {
                case "Light_Weight":
                    string light_character_chosen = light_weight_characters[character_pick];
                    string light_vehicle_chosen = light_weight_karts[vehicle_pick];
                    Console.WriteLine(light_character_chosen);
                    Console.WriteLine(light_vehicle_chosen);
                    break;


                case "Medium_Weight":
                    string medium_character_chosen = medium_weight_characters[character_pick];
                    string medium_vehicle_chosen = medium_weight_karts[vehicle_pick];
                    Console.WriteLine(medium_character_chosen);
                    Console.WriteLine(medium_vehicle_chosen);
                    break;


                case "Heavy_Weight":
                    string heavy_character_chosen = heavy_weight_characters[character_pick];
                    string heavy_vehicle_chosen = heavy_weight_karts[vehicle_pick];
                    Console.WriteLine(heavy_character_chosen);
                    Console.WriteLine(heavy_vehicle_chosen);
                    break;

                default:
                    Console.WriteLine("ERROR: Could not pick character!");
                    Console.WriteLine("Please try again!");
                    break;
            }

        }

        public void MKW_Random_Bikes_Only()
        {
            Random rnd = new Random();

            // weight classes
            string[] classy = { "Light_Weight", "Medium_Weight", "Heavy Weight" };

            // choosing a random weight class from list
            int pick_num = rnd.Next(0, 2);
            string class_pick = classy[pick_num];

            // initilizing the random character and vehicle picker
            int character_pick = rnd.Next(0, 7);
            int vehicle_pick = rnd.Next(0, 5);

            // Characters and Vehicle lists for randomizer to choose from

            // Lightweight Characters and Bikes
            string[] light_weight_characters = {
                                                "Baby Mario", "Baby Luigi", "Baby Peach", "Baby Daisy",
                                                "Toad", "Toadette", "Koopa Troopa", "Dry Bones"
                                               };

            string[] light_weight_bikes = {
                                              "Standard Bike S (Small Bike)", "Magikruiser (Small Bike)", "Quacker (Small Bike)",
                                              "Jet Bubble (Small Bike)", "Bit Bike (Small Bike)", "Bullet Bike (Small Bike)"
                                             };

            // Medium Weight Characters and Bikes
            string[] medium_weight_characters = {
                                                 "Mario", "Luigi", "Peach", "Daisy",
                                                 "Yoshi", "Birdo", "Diddy Kong", "Bowser Jr."
                                                };

            string[] medium_weight_bikes = {
                                               "Standard Bike M (Medium Bike)", "Sugarscoot (Medium Bike)", "Sneakster (Medium Bike)",
                                               "Dolphin Dasher (Medium Bike)", "Zip Zip (Medium Bike)", "Mach Bike (Medium Bike)"
                                               };

            // Heavy Weight Character and Vehicles
            string[] heavy_weight_characters = {
                                                "Wario", "Waluigi", "Donkey Kong", "Bowser",
                                                "King Boo", "Rosalina", "Donkey Kong", "Dry Bowser"
                                                };

            string[] heavy_weight_bikes = {
                                           "Standard Bike L (Heavy Bike)", "Wario Bike (Heavy Bike)", "Shooting Star (Heavy Bike)",
                                           "Flame Runner (Heavy Bike)", "Spear (Heavy Bike)", "Phantom (Heavy Bike)"
                                          };

            // choosing a random character and vehicle based on what class was chosen
            if (class_pick == "Light_Weight")
            {
                string character_chosen = light_weight_characters[character_pick];
                string vehicle_chosen = light_weight_bikes[vehicle_pick];
                Console.WriteLine(character_chosen);
                Console.WriteLine(vehicle_chosen);
            }

            else if (class_pick == "Medium_Weight")
            {
                string character_chosen = medium_weight_characters[character_pick];
                string vehicle_chosen = medium_weight_bikes[vehicle_pick];
                Console.WriteLine(character_chosen);
                Console.WriteLine(vehicle_chosen);
            }

            else if (class_pick == "Heavy_Weight")
            {
                string character_chosen = heavy_weight_characters[character_pick];
                string vehicle_chosen = heavy_weight_bikes[vehicle_pick];
                Console.WriteLine(character_chosen);
                Console.WriteLine(vehicle_chosen);
            }
        }

        public void MKW_Original_Track_Randomizer()
        {
            // initializing random
            Random rnd = new Random();

            string[] cups = {"Mushroom Cup", "Flower Cup", "Star Cup", "Special Cup",
                             "Shell Cup", "Banana Cup", "Leaf Cup", "Lightning Cup"};
            
            // picking random cup
            int pick_num = rnd.Next(0, 7);
            string cup_pick = cups[pick_num];

            // All 32 tracks split up into their individual cups
            string[] Mushroom_Cup = {"Luigi Circuit", "Moo Moo Meadows", "Mushroom Gorge", "Toad's Factory"};
            
            string[] Flower_Cup = {"Mario Circuit", "Coconut Mall", "DK Summit", "Wario's Gold Mine"};
            
            string[] Star_Cup = {"Daisy Circuit", "Koopa Cape", "Maple Treeway", "Grumble Volcano"};
            
            string[] Special_Cup = {"Dry Dry Ruins", "Moonview Highway", "Bowser's Castle", "Rainbow Road"};
            
            string[] Shell_Cup = {"GCN Peach Beach", "DS Yoshi Falls", "SNES Ghost Valley 2", "N64 Mario Raceway"};
            
            string[] Banana_Cup = {"N64 Sherbet Land", "GBA Shy Guy Beach", "DS Delfino Square", "GCN Waluigi Stadium"};
            
            string[] Leaf_Cup = {"DS Desert Hills", "GBA Bowser Castle 3", "N64 DK's Jungle Parkway", "GCN Mario Circuit"};

            string[] Lightning_Cup = {"SNES Mario Circuit 3", "DS Peach Gardens", "GCN DK Mountain", "N64 Bowser's Castle"};

            // initializing track picker to be used in switch statements down below
            int track_picker = rnd.Next(0, 3);

            // choosing a random track based on cup chosen
            switch (cup_pick)
            {
                case "Mushroom Cup":
                    string mushroom_track_chosen = Mushroom_Cup[track_picker];
                    Console.WriteLine(cup_pick);
                    Console.WriteLine(mushroom_track_chosen);
                    break;

                case "Flower Cup":
                    string flower_track_chosen = Flower_Cup[track_picker];
                    Console.WriteLine(cup_pick);
                    Console.WriteLine(flower_track_chosen);
                    break;

                case "Star Cup":
                    string star_track_chosen = Star_Cup[track_picker];
                    Console.WriteLine(cup_pick);
                    Console.WriteLine(star_track_chosen);
                    break;

                case "Special Cup":
                    string special_track_chosen = Special_Cup[track_picker];
                    Console.WriteLine(cup_pick);
                    Console.WriteLine(special_track_chosen);
                    break;

                case "Shell Cup":
                    string shell_track_chosen = Shell_Cup[track_picker];
                    Console.WriteLine(cup_pick);
                    Console.WriteLine(shell_track_chosen);
                    break;

                case "Banana Cup":
                    string banana_track_chosen = Banana_Cup[track_picker];
                    Console.WriteLine(cup_pick);
                    Console.WriteLine(banana_track_chosen);
                    break;

                case "Leaf Cup":
                    string leaf_track_chosen = Leaf_Cup[track_picker];
                    Console.WriteLine(cup_pick);
                    Console.WriteLine(leaf_track_chosen);
                    break;

                case "Lightning Cup":
                    string lightning_track_chosen = Lightning_Cup[track_picker];
                    Console.WriteLine(cup_pick);
                    Console.WriteLine(lightning_track_chosen);
                    break;

                default:
                    Console.WriteLine("ERROR: Couldn't pick track!");
                    Console.WriteLine("Please try again!");
                    break;
            }
        }
    }
}
