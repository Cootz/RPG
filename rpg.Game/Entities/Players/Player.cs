using rpg.Game.Buffs;
using rpg.Game.Entities.BaseInterfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities.Players
{
    public class Player : LivingEntity
    {
       public Player(double maxHp = Double.NaN) : base(maxHp) { }
    }
}
