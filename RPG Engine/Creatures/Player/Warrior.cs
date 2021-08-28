using RPG_Engine.Creatures;
using RPG_Engine.Creatures.BaseInterfases;
using RPG_Engine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine
{
    public class Warrior : Player, IHealth, IMana, IStamina, IAttack
    {
        private Sword mainWeapon;
        private const string DEATHMESSAGE = "You're dead";

        public Warrior(Sword weapon)
        {
            mainWeapon = weapon;
            hp = 10000;
            mp = 0;
            sp = 1000;
            name = "Sword man";
        }

        public void Damage(double amount)
        {
            if (hp > amount)
            {
                hp -= amount;
            }
            else 
            {
                hp = 0;
                Console.WriteLine(DEATHMESSAGE);
            }            
        }

        public void DrainMana(double amount)
        {
            if (mp > amount)
            {
                mp -= amount;
            }
            else
            {
                mp = 0;
                Console.WriteLine(DEATHMESSAGE);
            }
        }

        public double GetHealth() => hp;

        public double GetMana() => mp;

        public double GetStamina() => sp;

        public void LoseStamina(double amount)
        {
            if (sp > amount)
            {
                sp -= amount;
            }
            else
            {
                sp = 0;
                Console.WriteLine(DEATHMESSAGE);
            }
        }

        public void Attack(IHealth targetHealth)
        {
            targetHealth.Damage(mainWeapon.GetCurrentDamage() * 10);
            Console.WriteLine("Dealing {0} damage to {1}", mainWeapon.GetCurrentDamage() * 10, (targetHealth as Monster).GetName());
        }
    }
}
