using System;
using System.Reflection.PortableExecutable;

namespace RpgV2
{
	public class AddHP : Itriggerable
	{
        public int NumberOfHealthPoints { get; set; }

        public AddHP()
        {
            NumberOfHealthPoints = 5;
        }

        public void trigger(Characteristics characteristicsAdventurer)
        {
            characteristicsAdventurer.HP += NumberOfHealthPoints;
        }

        public void trigger(Characteristics characteristicsAdventurer, Characteristics characteristicsEncounter)
        {
            characteristicsAdventurer.HP += characteristicsEncounter.HP;
        }
    }
}

