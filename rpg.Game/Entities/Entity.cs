using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg.Game.Entities
{
    public abstract class Entity: IUpdateable, IDrawable
    {
        protected Model model;
        
        public Vector3 Position { get; set; }
        public Vector3 Velocity { get; set; }

        public Vector3 Size 
        {
            get
            {
                return Vector3.Zero;
            }
        }

        public abstract bool Enabled { get; set; }
        public abstract int UpdateOrder { get; set; }

        public int DrawOrder { get; set; }
        public bool Visible { get; set; }

        public event EventHandler<EventArgs> EnabledChanged;
        public event EventHandler<EventArgs> UpdateOrderChanged;
        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        public void Draw(GameTime gameTime)
        { 
            model.Draw(new Matrix(), new Matrix(), new Matrix());
        }

        public abstract void Update(GameTime gameTime);

    }
}
