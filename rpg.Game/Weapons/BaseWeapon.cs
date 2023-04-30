using System;

namespace rpg.Game.Entities.Weapons
{
    public abstract class BaseWeapon : Entity
    {
        protected WeaponStats stats;

        public virtual double GetCurrentDamage() => Double.NaN;

        public virtual WeaponStats GetStats() => stats;
    }
}
