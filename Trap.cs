using System;
namespace RpgV2
{
    public class Trap : Encounter
    {
        public Trap(string name) : base(name)
        {
        }

        public override void Meet(Adventurer adventurer)
        {
           RemoveHP remove = new RemoveHP();
            remove.trigger(adventurer.characteristics) ;
            adventurer.characteristics.DisplayCharacteristics();
        }

    }
}

