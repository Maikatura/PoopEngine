using Microsoft.Xna.Framework.Graphics;

namespace PoopEngine.ECS
{
    public class Sprite
    {
        private Texture2D Texture;
        private int Width, Height;

        
        
        public Vector2 Center;
        

        public Sprite(Texture2D texture)
        {
            Texture = texture;
            Width = texture.Width;
            Height = texture.Height;
            Center = new Vector2((float)Width / 2, (float)Height / 2);
        }
        
        

    }
}