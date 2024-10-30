namespace LabbArv
{
    public class AfricanLion : Lion
    {
        public bool IsAlpha { get; set; } = true;

        public AfricanLion(string name = "Unknown", string species = "Lion", int age = 0, double weight = 200.0, string habitat = "Savannah", bool isKing = true, bool isAlpha = true) : base(name, species, age, weight, habitat, isKing)
        {
            IsAlpha = isAlpha;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} is making a RoARR!");
        }

        public void Showoff()
        {
            if (IsAlpha == true)
            {
                Console.WriteLine($"{Name} shows how much Alpha he is ");
            }
            else
            {
                Console.WriteLine($"{Name} trying to convince everyone that {Name} is an Alpha!");
            }
        }
    }
}
