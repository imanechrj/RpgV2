using System;
using System.Reflection.PortableExecutable;

namespace RpgV2
{
    public class Item : Encounter
    {
        Characteristics ItemCharacteristics;
        public Item(string name) : base(name)
        {
            ItemCharacteristics = new Characteristics();
            ItemCharacteristics.HP = 0;
            ItemCharacteristics.Speed = 0;
            ItemCharacteristics.Attack = 0;
            Name = "item";
            Random random = new Random();
            int hp = random.Next(10);
            int speed = random.Next(6);
            int attack = random.Next(5);

            int rand = random.Next(3);

            switch (rand)
            {
                case 0:
                    ItemCharacteristics.HP = hp;
                    Name = "potion";
                    break;
                case 1:
                    ItemCharacteristics.Speed = speed;
                    Name = "magical boots";
                    break;
                case 2:
                    ItemCharacteristics.Attack = attack;
                    Name = "Axe";
                    break;
                default:
                    break;
            }
        }

        public override void Meet(Adventurer adventurer)
        {
            AddHP addHP = new AddHP();
            AddAttack addAttack = new AddAttack();
            AddSpeed addSpeed = new AddSpeed();

            switch (Name)
            {
                case "potion":
                    addHP.trigger(adventurer.characteristics, ItemCharacteristics);
                    if (adventurer.characteristics.HP >= 200)
                    {
                        adventurer.itriggerables.Add(new AddHP());
                    }
                    break;
                case "magical boot":
                    addSpeed.trigger(adventurer.characteristics, ItemCharacteristics);
                    if (adventurer.characteristics.Speed >= 60)
                    {
                        adventurer.itriggerables.Add(new AddSpeed());
                    }
                    break;
                case "Axe":
                    addAttack.trigger(adventurer.characteristics, ItemCharacteristics);
                    if (adventurer.characteristics.Attack >= 40)
                    {
                        adventurer.itriggerables.Add(new AddAttack());
                    }
                    break;
                default:
                    break;
            }
            adventurer.characteristics.DisplayCharacteristics();

        }
    }
}

