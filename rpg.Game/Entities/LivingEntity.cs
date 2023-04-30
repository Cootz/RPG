using Microsoft.Xna.Framework;
using rpg.Game.Effects;
using rpg.Game.Entities.BaseInterfases;
using rpg.Game.Entities.Weapons;
using System;
using System.Collections.Generic;

namespace rpg.Game.Entities
{
    public class LivingEntity : Entity, IName, IAttack, IHealth, IMana, IStamina
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
        /// Max amount of hp
        /// </summary>
        protected double maxHp;

        /// <summary>
        /// Mana points
        /// </summary>
        protected double mp;
        /// <summary>
        /// Stamina points
        /// </summary>
        protected double sp;
        /// <summary>
        /// Experience points
        /// </summary>
        protected double xp;

        /// <summary>
        /// Buffs that currently affected on player
        /// </summary>
        protected List<Effect> currentBuffs;

        //TODO: rework damage system
        protected BaseWeapon weapon;

        public override bool Enabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int UpdateOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public LivingEntity(double maxHp = Double.NaN)
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }

        public virtual string GetName() => name;

        public virtual double GetHealth() => hp;

        public virtual double GetMaxHealth() => maxHp;

        public virtual double GetMana() => mp;

        public virtual double GetStamina() => sp;

        /// <summary>
        /// Applies received damage
        /// </summary>
        /// <param name="amount">Amount of damage received</param>
        public virtual void Damage(double amount)
        {
            if (hp > amount)
            {
                hp -= amount;
            }
            else
            {
                hp = 0;
                //TODO: Entity death
            }
        }

        /// <summary>
        /// Applies received mana drain
        /// </summary>
        /// <param name="amount"></param>
        public virtual void DrainMana(double amount)
        {
            if (mp > amount)
            {
                mp -= amount;
            }
            else
            {
                mp = 0;
                //TODO: Entity death
            }
        }

        /// <summary>
        /// Applies received stamina drain
        /// </summary>
        /// <param name="amount"></param>
        public virtual void LoseStamina(double amount)
        {
            if (sp > amount)
            {
                sp -= amount;
            }
            else
            {
                sp = 0;
            }
        }

        //TODO: Rework damage system
        /// <summary>
        /// Provides attack logic
        /// </summary>
        /// <param name="targetHealth">Targets health</param>
        public virtual void Attack(IHealth targetHealth)
        {
            if (weapon is not null)
            {
                targetHealth.Damage(weapon.GetCurrentDamage());
            }
        }

        /// <summary>
        /// Applies heal to hp
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Heal(double amount)
        {
            if (hp + amount < maxHp)
            {
                hp += amount;
            }
            else
            {
                hp = maxHp;
            }
        }

        public override void SetUp()
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
