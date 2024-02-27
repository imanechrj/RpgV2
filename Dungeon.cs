using System;
namespace RpgV2
{
	public class Dungeon
	{
		public List<Room> Adventure;

        public Dungeon()
        {
            Adventure = new List<Room>();
            Random random = new Random();
            int rand = random.Next(5, 21);

            for (int i = 0; i < rand; i++)
            {
                Adventure.Add(new Room());
            }
        }
    }
}

