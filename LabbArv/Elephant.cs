namespace LabbArv
{
    public class Elephant : Animal
    {
        public double EarSize { get; set; } = 1.8;

        public Elephant(string name = "Unknown", string species = "Elephant", int age = 0, double weight = 80, string habitat = "Grasslands", double earSize = 1.8) : base(name, species, age, weight, habitat)
        {
            EarSize = earSize;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a Trumpet!");
        }

        public void FlapEar()
        {
            Console.WriteLine($"{Name} is flapping the {EarSize}m big ears!");
        }
    }
}
