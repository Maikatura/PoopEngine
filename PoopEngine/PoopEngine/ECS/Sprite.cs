using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PoopEngine.ECS
{
    public class Sprite
    {
        private Texture2D texture;
        private int Width, Height;


        public Texture2D Texture()
        {
            return texture;
        }
        
        
        
        public Vector2 Center;
        

        public Sprite(Texture2D texture)
        {
            this.texture = texture;
            Width = texture.Width;
            Height = texture.Height;
            Center = new Vector2((float)Width / 2, (float)Height / 2);
        }
        
        

    }
}