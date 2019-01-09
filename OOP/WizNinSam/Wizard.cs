using System;

namespace WizNinSam
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Health = 50;
            Intelligence = 25;             
        }

        public void Heal()
        {
            Health+= Intelligence * 10;
            System.Console.WriteLine($"The wizard has healed himself. New Health = {Health}");
        }

        public void Fireball(Human human)
        {
            Random rand = new Random();
            int damage = rand.Next(20,51);
            human.Health-= damage;
        }
       
    }

    
}