using System;

namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
            Wizard wizard1 = new Wizard("Jason");
            Console.WriteLine(wizard1.Strength);
            Console.WriteLine(wizard1.Health);
            wizard1.Heal();
            Wizard wizard2 = new Wizard("Nick");
            wizard1.Fireball(wizard2);
            Ninja ninja1 = new Ninja("Mike");
            Ninja ninja2 = new Ninja("Jonny");
            ninja1.Steal(ninja2);
            ninja2.Steal(ninja1);
            ninja2.Steal(ninja1);
            ninja2.Steal(ninja1);
            ninja2.Steal(ninja1);
            ninja2.Steal(ninja1);
            ninja2.Steal(ninja1);
            ninja2.Steal(ninja1);
            ninja1.Get_Away();
            Samurai samurai1 = new Samurai("Oz");
            Samurai samurai2 = new Samurai("Anne");
            Samurai samurai3 = new Samurai("Anthony");
            ninja1.Steal(samurai1);
            samurai1.Death_Blow(ninja1);
            samurai1.Meditate();
            Samurai.How_Many();

        }
    }
}
