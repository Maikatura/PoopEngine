using Microsoft.Xna.Framework;

namespace PoopEngine.Lib.ECS
{
    public class Transform
    {

        // Rotation and Position
        public float Scale;
        public Vector2 Position;
        public float Rotation;


        public Transform(int x = 0, int y = 0, int scale = 1)
        {
            Position = new Vector2(x, y);
            Scale = scale;
        }


        public float SetRotation(float rotation)
        {
            Rotation = rotation;
            return rotation;
        }
        

    }
}