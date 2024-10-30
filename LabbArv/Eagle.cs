namespace LabbArv
{
    public class Eagle : Animal
    {
        public string FeatherColor { get; set; }

        public Eagle(string name, string species, int age, double weight, string habitat, string featherColor) : base(name, species, age, weight, habitat)
        {
            FeatherColor = featherColor;
        }

        public override void MakeSound()
        {
            
        }

        public void Fly()
        {

        }
    }
}
