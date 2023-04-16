using rpg.Game.Entities.BaseInterfases;
using rpg.Game.Entities.Players;
using rpg.Game.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities
{
    public class Troll : Monster
    {
        public Troll(BaseWeapon weapon) : base(500)
        {
            primiryWeapon = weapon;
            name = "Troll of the forest";
        }
    }
}
