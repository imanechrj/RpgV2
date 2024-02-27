using System;
namespace RpgV2
{
    public class AddAttack : Itriggerable
    {
        public int NumberOfAttackPointsPoints { get; set; }

        public AddAttack()
        {
            NumberOfAttackPointsPoints = 5;
        }

        public void trigger(Characteristics characteristicsAdventurer)
        {
            characteristicsAdventurer.Attack += NumberOfAttackPointsPoints;
        }

        public void trigger(Characteristics characteristicsAdventurer, Characteristics characteristicsEncounter)
        {
            characteristicsAdventurer.Attack += characteristicsEncounter.Attack;
        }
    }
}

