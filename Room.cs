using System;
namespace RpgV2
{
	public class Room
	{
        List<Encounter> Encounters = new List<Encounter>();
        public Encounter InTheRoom { get; set; }

        public void Initialize()
        {
            Encounters.Add(new Trap("trap"));
            Encounters.Add(new Monster("Monster"));
            Encounters.Add(new Item("Item"));
        }

        public Room()
        {
            Initialize();
            Random random = new Random();
            int rand = random.Next(3);
            InTheRoom = Encounters[rand];
        }

        public void DisplayRoom()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Welcome in the room");
            Console.WriteLine("You see " + InTheRoom.Name);
        }

    }
}

