using System.Collections.Generic;
using System.Net.Sockets;
using Microsoft.Xna.Framework;

namespace PoopEngine.Lib.ECS
{
    public class CompHandler
    {
        
        public static CompHandler Instance = new CompHandler();
        
        
        private List<Component> comps = new List<Component>();


        public void Update(GameTime gameTime)
        {
            foreach (var comp in comps)
            {
                comp.Update(gameTime);
            }
        }
        
        public void Draw(GameTime gameTime)
        {
            foreach (var comp in comps)
            {
                comp.Draw(gameTime);
            }
        }
        
        public void Add(Component type)
        {
            comps.Add(type);
        }

        public void Remove(Component type)
        {
            if (comps.Contains(type))
                comps.Remove(type);
        }
    }
}