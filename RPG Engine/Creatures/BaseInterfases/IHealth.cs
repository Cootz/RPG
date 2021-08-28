using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine.Creatures.BaseInterfases
{
    public interface IHealth
    {
        public double GetHealth();
        public void Damage(double amount);
    }
}
