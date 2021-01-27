using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PoopEngine.Lib.ECS
{
    public class SpriteRenderer : Component
    {

        private Sprite sprite;


        public SpriteRenderer(Sprite sprite)
        {
            
            this.sprite = sprite;
        }
        
        public Sprite SetSprite(Sprite sprite)
        {
            this.sprite = sprite;
            return sprite;
        }


        public override void Draw(GameTime gameTime)
        {
            Graphics.Batcher.Draw(sprite.Texture(), Entity.Transform.Position, Color.White);
   
        }


        public override void Update(GameTime gameTime)
        {
            
        }

    }
}