using System;
namespace Human
{
    class Program
    {
        public class Human
        {   
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            public int Health;

            public Human(string name)
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                Health = 100;
            }

            public Human(string name, int strength, int intelligence, int dexterity, int health)
            {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                Health = health;
            }

            public void Attack(Human human)
            {
                human.Health -= this.Strength * 5; 
            }
        }
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            Human faizan = new Human("Faizan");
            Human binh = new Human("Binh", 5,4,4,110);
            System.Console.WriteLine(binh.Health);
            //System.Console.WriteLine(faizan.Health);
            binh.Attack(faizan);
            binh.Attack(faizan);
            faizan.Attack(binh);
            faizan.Attack(binh);
            faizan.Attack(binh);
            Console.WriteLine(binh.Health);
        }
    }
}
