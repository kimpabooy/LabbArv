namespace LabbArv
{
    public class Eagle : Animal
    {
        public string FeatherColor { get; set; } = "Brown";

        public Eagle(string name = "Unknown",
                     string species = "Eagle",
                     int age = 0,
                     double weight = 3.5,
                     string habitat = "Open landscapes",
                     string featherColor = "Brown") : base(name, species, age, weight, habitat)
        {
            FeatherColor = featherColor;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a Screech!");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is flying!");
        }
    }
}
