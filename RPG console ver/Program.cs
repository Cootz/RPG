using System;
using RPG_Engine;
using RPG_Engine.Creatures;
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
           

        }
    }
}
