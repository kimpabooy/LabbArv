namespace LabbArv
{
    internal class AsiaticLion : Lion
    {
        public bool IsEndangered { get; set; }

        public AsiaticLion(string name, string species, int age, double weight, string habitat, bool isKing, bool isEndangerd) : base(name, species, age, weight, habitat, isKing)
        {
            IsEndangered = isEndangerd;
        }

        public override void MakeSound()
        {
            
        }

        public void EndangerStatus()
        {

        }
    }
}
