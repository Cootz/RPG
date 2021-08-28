using RPG_Engine.Creatures.BaseInterfases;
using RPG_Engine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine.Creatures
{
    public class Troll : Monster, IHealth, IAttack
    {
        private const string DEATHMESSAGE = "Troll has been killed";

        public Troll(BaseWeapon weapon)
        {
            primiryWeapon = weapon;
            hp = 500;
            name = "Troll of the forest";
        }

        public void Attack(IHealth targetHealth)
        {
            targetHealth.Damage(primiryWeapon.GetCurrentDamage());
            Console.WriteLine("Troll dealing {1} damage to {0}", (targetHealth as Player).GetName(), primiryWeapon.GetCurrentDamage());
            Console.WriteLine("{0} HP: {1}", (targetHealth as Player).GetName(), targetHealth.GetHealth());
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

        public double GetHealth() => hp;
    }
}
