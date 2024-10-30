namespace LabbArv
{
    public class Elephant : Animal
    {
        public double EarSize { get; set; }

        public Elephant(string name, string species, int age, double weight, string habitat, double earSize) : base(name, species, age, weight, habitat)
        {
            EarSize = earSize;
        }

        public override void MakeSound()
        {
           
        }

        public void FlapEar()
        {

        }
    }
}
