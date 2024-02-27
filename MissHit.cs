using System;
using System.Reflection.PortableExecutable;

namespace RpgV2
{
    public class MissHit : Itriggerable
    {
        public int  NumberOfHealthPoint { get; set; }

        public MissHit()
        {
            NumberOfHealthPoint = 1;
        }

        public void trigger(Characteristics characteristicsEncounter)
        {
            characteristicsEncounter.HP -= NumberOfHealthPoint;
        }

        public void trigger(Characteristics characteristicsAdventurer, Characteristics characteristicsEncounter)
        {
            characteristicsEncounter.HP -= NumberOfHealthPoint;
        }
    }
}

