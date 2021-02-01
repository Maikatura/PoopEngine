using Microsoft.Xna.Framework;

namespace PoopEngine.Lib.ECS.TileMap
{
    public class TileMap
    {
        

        public void Update(GameTime gameTime)
        {
            
        }
        
        public void Draw(GameTime gameTime)
        {
            
        }

        public TileMap(string path, bool headless = false)
        {
            LoadTileMap(path, headless);
        }

        public TileMap LoadTileMap(string path, bool headless = false)
        {
            // TODO load Tilemap From File: Json and Tmx.
            
            
            
            return new TileMap(path, headless);
        }
        
    }
}