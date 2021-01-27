using System.Dynamic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace PoopEngine.Lib
{
    public class Core : Game
    {


        private static ContentManager content;

        public static ContentManager Content
        {
            get
            {
                return content;
            }
            private set
            {
                return;
            }
        }
        
        
        


    }
}