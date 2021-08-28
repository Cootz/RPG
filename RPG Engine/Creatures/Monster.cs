using RPG_Engine.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine.Creatures
{
    public class Monster : Entity
    {
        /// <summary>
        /// Name of the creature
        /// </summary>
        protected string name;

        /// <summary>
        /// Health points
        /// </summary>
        protected double hp;

        /// <summary>
        /// Mana points
        /// </summary>
        protected double mp;

        protected List<Buff> currentBuffs;

        protected BaseWeapon primiryWeapon;
        protected BaseWeapon secondaryWeapon;

        public string GetName() => name;

    }
}
