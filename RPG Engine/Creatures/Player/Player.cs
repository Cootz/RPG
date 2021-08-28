using RPG_Engine.Creatures.BaseInterfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine
{
    public class Player : Entity
    {
        /// <summary>
        /// Name of the class
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
        /// <summary>
        /// Stamina points
        /// </summary>
        protected double sp;
        /// <summary>
        /// Expiriance points
        /// </summary>
        protected double xp;

        /// <summary>
        /// Buffs that currently affected on player
        /// </summary>
        protected List<Buff> currentBuffs;

        public string GetName() => name;
    }
}
