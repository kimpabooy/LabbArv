namespace LabbArv
{
    public class Program
    {
        static void Main(string[] args)
        {       
            Lion lion = new("Simba", "Lion", 8, 80, "Savannah", false);
            Eagle eagle = new("Börje", "Eagle", 5, 2, "Forest", "Black"); 
            Elephant elephant = new("Dumbo", "Elepahnt", 10, 95, "Circus", 2.0);
            AfricanLion afrikanLion = new("Scar", "Afrikan Lion", 31, 130.5, "Savannah", false, true);
            AfricanLion afrikanLionNotAlpha = new("Scarlet", "Afrikan Lion", 31, 130.5, "Savannah", false, false);
            AsiaticLion asiaticLion = new("Mufasa", "Asiatic Lion", 33, 150.4, "Forest", true, true);
            AsiaticLion asiaticLionNotEndanger = new("Mufasia", "Asiatic Lion", 33, 150.4, "Forest", true, false);

            // Empty object to show default values.
            Eagle emptyEagle = new Eagle();
            Elephant emptyElephant = new Elephant();
            Lion emptyLion = new Lion();
            AfricanLion emptyAfrikanLion = new AfricanLion();
            AsiaticLion emptyAsiaticLion = new AsiaticLion();

            Console.WriteLine("\nSOUNDS\n");
            eagle.MakeSound();
            elephant.MakeSound();
            lion.MakeSound();
            afrikanLion.MakeSound();
            asiaticLion.MakeSound();
            Console.WriteLine("\n////////////////////////////////////////////////////////////");

            Console.WriteLine("\nUniqe Method\n");
            eagle.Fly();
            elephant.FlapEar();
            lion.Hunt();
            afrikanLion.Showoff();
            afrikanLionNotAlpha.Showoff();
            asiaticLion.EndangerStatus();
            asiaticLionNotEndanger.EndangerStatus();
            Console.WriteLine("\n////////////////////////////////////////////////////////////");

            Console.WriteLine("\nEMPTY OBJECTS\n");
            emptyEagle.DisplayInfo();
            emptyElephant.DisplayInfo();
            emptyLion.DisplayInfo();
            emptyAfrikanLion.DisplayInfo();
            emptyAsiaticLion.DisplayInfo();

            Console.ReadKey();
        }
    }
}
