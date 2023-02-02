using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities.Weapons.BaseWeaponIntefases
{
    interface ILevelUp
    {
        public int GetLevel();
        public void LevelUp(int LevelAmount);
    }
}
