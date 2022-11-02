namespace BossFight
{
    internal class Game
    {
      
        private int PlayerHp = 100;
        private int EnemyHp = 400;

        private int PlayerAttack = 20;
        
        private int PlayerStamina = 40;
        private int EnemyStamina = 20;

        private int StaminaRegen = 10;
        private int DepleteStamina = 10;
        
        public void StartBattle()
        {
            while (PlayerHp > 0 && EnemyHp > 0)
            {
                Console.WriteLine("--Player Turn--");
                Console.WriteLine($"You have {PlayerHp} Hp, Enemy has {EnemyHp} Hp!");
                Console.WriteLine("Press 'a' for attack, press 's' for stamina");
                string Choise = Console.ReadLine();

                if (Choise == "a")
                {
                    EnemyHp -= PlayerAttack;
                }
                if (Choise == "s")
                {
                    PlayerStamina += StaminaRegen;
                }

                if (EnemyStamina == 0)
                {
                    EnemyStamina += StaminaRegen;
                }
                else if (EnemyStamina > 0)
                {                    
                    Console.WriteLine("--Enemy Turn--");
                    Random random = new Random();
                    int EnemyAttack = random.Next(1, 30);
                    PlayerHp -= EnemyAttack;
                                           
                }
            };

            if (PlayerHp > 0) { Console.WriteLine("Congratulations you have won!"); }
            else { Console.WriteLine("You Lose!"); }
        }

    }
}
