using rpg.Game.Effects;
using rpg.Game.Entities.BaseInterfases;
using rpg.Game.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities
{
    public class Monster : LivingEntity
    {
        protected BaseWeapon primiryWeapon;
        protected BaseWeapon secondaryWeapon;

        public Monster(Double maxHp): base(maxHp) { }
    }
}
