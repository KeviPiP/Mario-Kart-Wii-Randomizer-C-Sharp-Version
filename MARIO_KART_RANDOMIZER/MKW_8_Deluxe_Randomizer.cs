using System;
using System.Collections.Generic;
using System.Text;

namespace MARIO_KART_RANDOMIZER
{
    class MKW_8_Deluxe_Randomizer
    {
        static readonly MKW_8_Deluxe_Randomizer picker = new MKW_8_Deluxe_Randomizer();

        public string[] Mario_Kart_8_Deluxe_All_Characters()
        {
            string[] all_characters = {
                                        "Mario", "Luigi", "Peach", "Daisy", "Rosalina", "Tanooki Mario", "Cat Peach",
                                        "Yoshi", "Toad", "Koopa Troopa", "Shy Guy", "Lakitu", "Toadette", "King Boo",
                                        "Baby Mario", "Baby Luigi", "Baby Peach", "Baby Daisy", "Baby Rosalina", "Metal Mario",
                                        "Pink Gold Peach", "Wario", "Waluigi", "Donkey Kong", "Bowser", "Dry Bones", "Bowser Jr.", 
                                        "Dry Bowser", "Lemmy", "Larry", "Wendy", "Ludwig", "Iggy", "Roy", "Morton", "Inkling Girl", 
                                        "Inkling Boy", "Link", "Villager", "Villager (Girl)", "Isabelle", "Mii"
                                       };
            return all_characters;
        }

        public void Mario_Kart_8_Deluxe_Default_Randomizer()
        {
            // initializing random
            Random rand = new Random();
            
            // grabbing character list
            string[] characters = picker.Mario_Kart_8_Deluxe_All_Characters();

            int character_pick = rand.Next(0, 41);

            Console.WriteLine(characters[character_pick]);
        }

        public void Mario_Kart_8_Deluxe_Gliders_Only()
        {
            // initializing random
            Random rand = new Random();

            // grabbing character list
            string[] characters = picker.Mario_Kart_8_Deluxe_All_Characters();

            int character_pick = rand.Next(0, 41);

            Console.WriteLine(characters[character_pick]);
        }

        public void Mario_Kart_8_Deluxe_Wheels_Only()
        {
            // initializing random
            Random rand = new Random();

            // grabbing character list
            string[] characters = picker.Mario_Kart_8_Deluxe_All_Characters();

            int character_pick = rand.Next(0, 41);

            Console.WriteLine(characters[character_pick]);
        }

        public void Mario_Kart_8_Deluxe_Bodies_Only()
        {
            // initializing random
            Random rand = new Random();

            // grabbing character list
            string[] characters = picker.Mario_Kart_8_Deluxe_All_Characters();

            int character_pick = rand.Next(0, 41);

            Console.WriteLine(characters[character_pick]);
        }
    }
}
