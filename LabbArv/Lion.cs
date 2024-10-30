namespace LabbArv
{
    public class Lion : Animal
    {
        public bool IsKing { get; set; } = true;
        
        public Lion(string name = "Unknown", string species = "Lion", int age = 0, double weight = 150.0, string habitat = "Savannah", bool isKing = true) : base(name, species, age, weight, habitat)
        {
            IsKing = isKing;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a RoAR!");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting somewhere in the {Habitat}.");
        }
    }
}
