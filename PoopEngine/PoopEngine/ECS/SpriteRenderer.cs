using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PoopEngine.ECS
{
    class SpriteRenderer : Component
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
            Graphics.Instance.Batcher.Draw(sprite.Texture(), new Vector2(0,0), Color.White);
        }


        public override void Update(GameTime gameTime)
        {
            Console.WriteLine(0);
        }

    }
}