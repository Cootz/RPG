using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using rpg.Game.Effects;
using rpg.Game.Entities;

namespace rpg.Game.UI
{
    public abstract class Scene : IDrawable, ISetUp
    {
        protected List<Entity> Entities { get; set; } = new List<Entity>();

        public int DrawOrder { get; }
        public bool Visible { get; }
        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        public abstract void SetUp();
        
        public void Draw(GameTime gameTime)
        {
            
        }
    }
}
