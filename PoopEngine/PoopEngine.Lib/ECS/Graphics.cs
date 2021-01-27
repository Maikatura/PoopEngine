using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PoopEngine.Lib.ECS
{
    public class Graphics
    {
        
        public static Graphics Instance = new Graphics();
        

        public static SpriteBatch Batcher;

        private static ContentManager content;

        public static ContentManager Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

    }
}