using System;
namespace RpgV2
{
	public interface Itriggerable
	{
        public void trigger(Characteristics characteristicsAdventurer);
        public void trigger(Characteristics characteristicsAdventurer, Characteristics characteristicsEncounter);
	}
}

