namespace LabbArv
{
    public class AfricanLion : Lion
    {
        public bool IsAlpha { get; set; }

        public AfricanLion(string name, string species, int age, double weight, string habitat, bool isKing, bool isAlpha) : base(name, species, age, weight, habitat, isKing)
        {
            IsAlpha = isAlpha;
        }

        public override void MakeSound()
        {
            
        }

        public void Showoff()
        {

        }
    }
}
