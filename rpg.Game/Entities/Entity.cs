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
        protected Matrix projectionMatrix;
        protected Matrix viewMatrix;
        protected Matrix worldMatrix;

        public Vector3 Position { get; set; }
        public Vector3 Velocity { get; set; }

        public Vector3 Size 
        {
            get => Vector3.Zero;
        }

        public void SetModel(Model model)
        {
            this.model = model;
        }

        public void SetMatrix(Matrix projectionMatrix, Matrix viewMatrix, Matrix worldMatrix)
        {
            this.projectionMatrix = projectionMatrix;
            this.viewMatrix = viewMatrix;
            this.worldMatrix = worldMatrix;
        }

        public abstract bool Enabled { get; set; }
        public abstract int UpdateOrder { get; set; }

        public int DrawOrder { get; set; }
        public bool Visible { get; set; }

        public event EventHandler<EventArgs> EnabledChanged;
        public event EventHandler<EventArgs> UpdateOrderChanged;
        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        public abstract void SetUp();

        public void Draw(GameTime gameTime)
        { 
            model.Draw(worldMatrix, viewMatrix, projectionMatrix);
        }

        public abstract void Update(GameTime gameTime);
    }
}
