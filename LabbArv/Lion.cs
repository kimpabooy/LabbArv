namespace LabbArv
{
    public class Lion : Animal
    {
        public bool IsKing { get; set; }
        
        public Lion(string name, string species, int age, double weight, string habitat, bool isKing) : base(name, species, age, weight, habitat)
        {
            IsKing = isKing;
        }

        public override void MakeSound()
        {
           
        }

        public void Hunt()
        {

        }
    }
}
