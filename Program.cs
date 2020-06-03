using System;

namespace Human
{
    class Program
    {
        class Human
        {
            // Fields for Human
            public string Name { get; set; }
            public int Strength { get; set; } = 3;
            public int Intelligence { get; set; } = 3;
            public int Dexterity { get; set; } = 3;
            private int health { get; set; } = 100;
            
            // add a public "getter" property to access health
            public int _health
            {
                get { return health; }
            }
            // Add a constructor that takes a value to set Name, and set the remaining fields to default values
            public Human(string val)
            {
                Name = val;
            }
            // Add a constructor to assign custom values to all fields
            public Human(string val, int str, int intel, int dex, int hp)
            {
                Name = val;
                Strength = str;
                Intelligence = intel;
                Dexterity = dex;
                health = hp;
            }

            // Build Attack method
            public void Attack(Human target)
            {
                target.health -= 5 * Strength;
            }
        }
        static void Main(string[] args)
        {
            Human person1 = new Human("Kevin", 5, 4, 4, 100);
            Human person2 = new Human("Enemy");
            Console.WriteLine(person1.Dexterity);
            Console.WriteLine(person2.Dexterity);
            person1.Attack(person2);
            person2.Attack(person1);
            Console.WriteLine(person1._health);
            Console.WriteLine(person2._health);
        }
    }
}
