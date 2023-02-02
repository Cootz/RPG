using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities.BaseInterfases
{
    public interface IHealth
    {
        public double GetHealth();
        public double GetMaxHealth();
        public void Damage(double amount);
        public void Heal(double amount);
    }
}
