using System;
namespace RpgV2
{
	public class AddSpeed : Itriggerable
	{
        public int NumberOfSpeedPointsPoints { get; set; }

        public AddSpeed()
        {
            NumberOfSpeedPointsPoints = 5;
        }

        public void trigger(Characteristics characteristicsAdventurer)
        {
            characteristicsAdventurer.Speed += NumberOfSpeedPointsPoints;
        }

        public void trigger(Characteristics characteristicsAdventurer, Characteristics characteristicsEncounter)
        {
            characteristicsAdventurer.Speed += characteristicsEncounter.Speed;
        }
    }
}

