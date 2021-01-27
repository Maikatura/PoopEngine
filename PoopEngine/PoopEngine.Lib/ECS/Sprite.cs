using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PoopEngine.Lib.ECS
{
    public class Sprite
    {
        private Texture2D texture;
        public int Width, Height;
        public Vector2 Center;

        private Rectangle rectangle;


        public Texture2D Texture()
        {
            return texture;
        }

        
        
        
        
        
        
        public Sprite(Texture2D texture)
        {
            this.texture = texture;
            Width = texture.Width;
            Height = texture.Height;
            Center = new Vector2((float)Width / 2, (float)Height / 2);
        }
        
        // Checking if there are more x rows in sprite.
        public bool CheckX()
        {
            return true;
        }
        
        // Checking if there are more Y rows in sprite.
        public bool CheckY()
        {
            return true;
        }

        

        
    }
}