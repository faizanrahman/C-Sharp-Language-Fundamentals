namespace WizNinSam
{
    public class Ninja : Human
    {
        public Ninja(string name):base(name)
        {
            Name = name;
            Dexterity = 175;
        }
        public void Steal(Human human)
        {
            human.Health-= 3 * Strength;
            this.Health+= 10;
        }
        public void Get_Away()
        {
            this.Health-=15;
        }
    }
}