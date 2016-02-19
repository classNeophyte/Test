using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsQuest
{


    enum Exit { North = 1, East =2, South = 3,  West =4 };
    enum Rooms { Castle = 1};

    class Room
    {
        private string name;
        private string description;
        private string exit;
        private string item;
        private int roomid;

        public Room(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public Room(string name, string description, string exit, string item, int roomid)
        {
            this.name = name;
            this.description = description;
            this.exit = exit;
            this.item = item;
            this.roomid = roomid;
        }


               public string GetRoom()
            {
            return name;
            }



        private void PlayerMove()
        {
        while (true)
        {
         var ch = Console.ReadKey(false).Key;
            switch(ch)
                {
                    case ConsoleKey.Escape:
                        Console.WriteLine("You pressed the ESCAPE key!");
                        return;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("You pressed the UP key!");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("You pressed the DOWN key!");
                        break;
                }

            }

        }

    }



    class Program
    {
        static void Main(string[] args)
        {



            string[,] mapGrid = new string[3, 3]
            {
                {"Tavern", "Castle", "Store" },
                {"Wishing Well", "Forest", "Bridge" },
                {"Graveyard", "Tower", "Dragons Den" }

            };

            //Console.Write(mapGrid[2, 1]);
            //Console.ReadKey();


            Rooms castle = Rooms.Castle;
            if (castle == Rooms.Castle)
            {
                Console.WriteLine(mapGrid[2, 1]);
            }

            string userInput = Console.ReadLine();
            if (userInput == "Castle")
            {
                Console.WriteLine(mapGrid[0, 1]);
                // This is where I need to get the code to jump to the Castle.
            }
            Console.ReadLine();

            Console.ReadKey();

            /*
            name[0, 0] = "tavern";
            name[0, 1] = castle;
            name[0, 2] = 
            name[1, 0] = 
            name[1, 1] = 
            name[1, 2] = 
            name[2, 0] = 
            name[2, 1] = 
            name[2, 2] = 
            */


        }




    }
}
