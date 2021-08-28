using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Engine
{
    public abstract class Buff
    {
        /// <summary>
        /// Buff duration
        /// </summary>
        protected int Duration;

        /// <summary>
        /// Stuff that buff do every tick
        /// </summary>
        public virtual void OnTick() { }  

        

    }
}
