using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Effects
{
    public class XPBoost : Effect
    {
        public XPBoost(int duration)
        {
            this.Duration = duration;
        }

        public override void OnTick()
        {
            base.OnTick();
        }
    }
}
