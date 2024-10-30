namespace LabbArv
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }

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
            
        }
        public void Eat()
        {
            
        }

        public void Sleep()
        {
            
        }

    }
}
