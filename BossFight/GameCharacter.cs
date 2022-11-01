using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }

        public GameCharacter()
        {
                
        }

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        public void Fight(GameCharacter Enemy)
        {
            int originalStrength = Enemy.Strength;
            initBossStrength(Enemy.Strength);
            int originalStamina = 0;

            if ((this.Health >= 0 && this.Stamina >= 0) && (Enemy.Health >= 0))
            {
                Enemy.Health -= this.Strength;
                this.Stamina -= 10;
                Enemy.Strength = originalStrength + 10;
                Console.WriteLine("Original stamina: " + originalStamina);
                Console.WriteLine(Enemy.Name + " has " + Enemy.Health + "health");
            }
            else if (!(this.Stamina >= 0))
            {
                while(this.Stamina <= originalStamina)
                {
                    Recharge();
                }
            }

            Enemy.Strength = originalStrength;
        }

        public void Recharge()
        {
            this.Stamina = this.Stamina + 10;
            Console.WriteLine(this.Name + " now has " + this.Stamina);
            Thread.Sleep(2000);

        }

        public void initBossStrength(int ogStrength)
        {
            Random n = new Random();
            int strength = n.Next(0, ogStrength + 1);
            ogStrength = strength;
        }
    }
}
