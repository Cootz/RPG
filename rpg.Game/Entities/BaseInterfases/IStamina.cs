using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities.BaseInterfases
{
    public interface IStamina
    {
        public double GetStamina();
        public void LoseStamina(double amount);
    }
}
