namespace BossFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Boss Fight!");

            GameCharacter Hero = new GameCharacter(" Eragon ", 1000, 40, 30);
            GameCharacter Boss = new GameCharacter(" Rykard ", 200, 20, 40);

            Console.WriteLine(Boss.Strength);
            while (true)
            {
                Hero.Fight(Boss);
            }
            
        }

    }
}