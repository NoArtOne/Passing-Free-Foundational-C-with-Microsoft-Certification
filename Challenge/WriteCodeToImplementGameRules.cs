using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Challenge
{
    internal class WriteCodeToImplementGameRules
    {
        public void Run()
        {
            int HeroHealth = 10;
            int MonsterHealth = 10;
            Random random = new();

            while ((HeroHealth > 0) && (MonsterHealth > 0))
            {
                int attacksValue = random.Next(1, 10);
                MonsterHealth -= attacksValue;
                Console.WriteLine($"Monster was damaged and lost {attacksValue} and now has {MonsterHealth} health.");
                if (MonsterHealth <= 0) {
                    Console.WriteLine("Hero wins!");
                }
                attacksValue = random.Next(1, 10);
                HeroHealth -= attacksValue;
                Console.WriteLine($"Hero  was damaged and lost {attacksValue} and now has {HeroHealth} health.");
                if (HeroHealth <= 0)
                {
                    Console.WriteLine("Monster wins!");
                    break;
                }   

            }

        }
    }
}
