namespace LabbArv
{
    public class Animal
    {
        public string Name { get; set; } = "Unknown";
        public string Species { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public double Weight { get; set; } = 0.0;
        public string Habitat { get; set; } = "Unknown";

        public Animal(string name, string species, int age, double weight, string habitat)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            Habitat = habitat;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }

        public void Spacing()
        {
          Console.WriteLine("\n////////////////////////////////////////////////////////////");
        }
    }
}
