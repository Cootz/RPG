using System;
using RPG_Engine;
using RPG_Engine.Creatures;
using RPG_Engine.Creatures.BaseInterfases;
using RPG_Engine.Weapons;

namespace RPG_console_ver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading");

            Warrior playerWarrior = new Warrior(new Enma());
            Troll troll = new Troll(new Enma());

            troll.Attack(playerWarrior);
            playerWarrior.Attack(troll);
            troll.Attack(playerWarrior);
            playerWarrior.Attack(troll);
            GetHealth(playerWarrior);

        }

        private static void GetHealth(IHealth creature)
        {
            Console.WriteLine("{0} health is {1}", (creature as IName).GetName(), creature.GetHealth());
        }
            
    }
}
