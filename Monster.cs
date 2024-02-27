using System;
namespace RpgV2
{
    public class Monster : Encounter
    {
        public Characteristics MonsterCharacteristics;

        public Monster(string name) : base(name)
        {
            MonsterCharacteristics = new Characteristics();
            Random random = new Random();
            MonsterCharacteristics.HP = random.Next(70);
            MonsterCharacteristics.Speed = random.Next(45);
        }

        public override void Meet(Adventurer adventurer)
        {
            Console.WriteLine("You fight with the monster");

            while(MonsterCharacteristics.HP > 0 && adventurer.characteristics.HP > 0)
            {
                Random rand = new Random();
                int start = rand.Next(6);
                if (start < 3)
                {
                    Console.WriteLine(Name + " attacks first");


                    int dice = rand.Next(6);
                    if (dice <=1)
                    {
                        Console.WriteLine(Name + " Missed");
                        MissHit miss = new MissHit();
                        miss.trigger(MonsterCharacteristics, adventurer.characteristics);
                        
                    }
                    else if (dice >1 && dice <= 5)  
                    {
                        Console.WriteLine(Name + " Hit you removing health Points");
                        RemoveHP removeHp = new RemoveHP();
                        removeHp.trigger(MonsterCharacteristics, adventurer.characteristics);
                    }
                    else
                    {
                        Console.WriteLine(Name + " Hit you removing attack points");
                        RemoveAttack removeAttack = new RemoveAttack();
                        removeAttack.trigger(MonsterCharacteristics, adventurer.characteristics);
                    }
                }
                else
                {
                    Console.WriteLine(adventurer.Name + " attacks first");
                    Random random = new Random();
                    int dice = random.Next(6);
                    if (dice <= 1)
                    {
                        Console.WriteLine(adventurer.Name + " Missed");
                        MissHit miss = new MissHit();
                        miss.trigger(adventurer.characteristics, MonsterCharacteristics);
                    }
                    else if (dice > 1 && dice <= 5)
                    {
                        Console.WriteLine(adventurer.Name + " Hit the monster removing his health Points");
                        RemoveHP removeHp = new RemoveHP();
                        removeHp.trigger(adventurer.characteristics, MonsterCharacteristics);
                    }
                    else
                    {
                        Console.WriteLine(adventurer.Name + " Hit the monster removing his attack Points");
                        RemoveAttack removeAttack = new RemoveAttack();
                        removeAttack.trigger(adventurer.characteristics, MonsterCharacteristics);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine(adventurer.Name);
                    adventurer.characteristics.DisplayCharacteristics();
                    Console.WriteLine("\n");
                    Console.WriteLine(Name);
                    MonsterCharacteristics.DisplayCharacteristics();
                }
            }
        }
    }
}

