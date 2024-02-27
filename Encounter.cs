using System;
namespace RpgV2
{
	public abstract class Encounter
	{
		public string  Name { get; set; }

        public Encounter(string name)
        {
            Name = name;
        }

        public abstract void Meet(Adventurer adventurer);
    }
}

