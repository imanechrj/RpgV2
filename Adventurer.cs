using System;
namespace RpgV2
{
	public class Adventurer
	{
        public Characteristics characteristics;
        public List<Itriggerable> itriggerables;
        public string Name { get; set; }

        public Adventurer(string name)
        {
            Name = name;
            characteristics = new Characteristics();
            itriggerables = new List<Itriggerable>();
            characteristics.HP = 200;
            characteristics.Attack = 30;
        }

        public void Initialize()
        {
            itriggerables.Add(new RemoveHP());
            itriggerables.Add(new RemoveAttack());
        }



        public void StartAdventure()
        {
            Dungeon dungeon = new Dungeon();
            foreach (Room room in dungeon.Adventure)
            {
                room.DisplayRoom();
                room.InTheRoom.Meet(this);
                if (characteristics.HP <= 0)
                {
                    break;
                }
            }
        }

        public void EndOfAdventure()
        {
            if(characteristics.HP <= 0)
            {
                Console.WriteLine(Name + " is Dead");
                Console.WriteLine("This is the end of the adventure");
            }
        }
    }
}

