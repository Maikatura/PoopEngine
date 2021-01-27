using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace PoopEngine.Lib.ECS
{
    public class Component
    {

        public Entity Entity;

        public void Initilize(Entity entity)
        {
            Entity = entity;
        }

        public virtual void Update(GameTime gameTime)
        {
            
        }
        
        public virtual void Draw(GameTime gameTime)
        {
            
        }
        
    }
}