using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities.BaseInterfases
{
    public interface IMana
    {
        public double GetMana();
        public void DrainMana(double amount);
    }
}
