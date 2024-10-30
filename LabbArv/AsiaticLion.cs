namespace LabbArv
{
    public class AsiaticLion : Lion
    {
        public bool IsEndangered { get; set; } = true;

        public AsiaticLion(string name = "Unknown",
                           string species = "Lion",
                           int age = 0,
                           double weight = 180.0,
                           string habitat = "Forest",
                           bool isKing = true,
                           bool isEndangerd = true) : base(name, species, age, weight, habitat, isKing)
        {
            IsEndangered = isEndangerd;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a RoAARRR!");
        }

        public void EndangerStatus()
        {
            if (IsEndangered == true)
            {
                Console.WriteLine($"{Name} is sadly one of the endangered {Species}!");
            }
            else
            {
                Console.WriteLine($"{Name} is not one of the endangered {Species}!");
            }
        }
    }
}
