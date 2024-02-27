using System;
namespace RpgV2
{
	public class Characteristics
	{
        public int HP { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Speed { get; set; } = 40;

        public void DisplayCharacteristics()
        {
            Console.WriteLine("HP : "+ HP);
            Console.WriteLine("Attack : " + Attack);
            Console.WriteLine("Speed : " + Speed);
        }
    }
}

