namespace WizNinSam
{
    public class Samurai : Human
    {
        public static int count = 0;
        public Samurai(string name):base(name)
        {
            count++;
            Name = name;
            Health = 200;
        }
        public void Death_Blow(Human human)
        {
            if(human.Health < 50)
            {
                human.Health = 0;
            }
        }
        public void Meditate()
        {
            this.Health = 200;
        }
        public static string How_Many()
        {
            System.Console.WriteLine($"The total number of Samurai instances created : {count}");
            return $"{count}";
        }
    }
}