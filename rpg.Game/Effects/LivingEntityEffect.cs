namespace rpg.Game.Effects
{
    public abstract class LivingEntityEffect
    {
        /// <summary>
        /// Effect duration
        /// </summary>
        protected int Duration;

        /// <summary>
        /// Stuff that buff do every tick
        /// </summary>
        public virtual void OnTick() { }
    }
}
