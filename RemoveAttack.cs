using System;
using System.Reflection.PortableExecutable;

namespace RpgV2
{
	public class RemoveAttack : Itriggerable
	{
		public int NumberOfAttack { get; set; }

        public RemoveAttack()
        {
            NumberOfAttack = 10;
        }

        public void trigger(Characteristics characteristicsAdventurer)
        {
            characteristicsAdventurer.Attack -= NumberOfAttack;
        }

        public void trigger(Characteristics characteristicsAdventurer, Characteristics characteristicsEncounter)
        {
            characteristicsAdventurer.Attack -= characteristicsEncounter.Attack;
        }
    }
}

