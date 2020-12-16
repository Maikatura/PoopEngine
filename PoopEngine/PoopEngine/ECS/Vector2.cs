namespace PoopEngine.ECS
{
    public class Vector2
    {
        
        private float X;
        private float Y;


        public Vector2(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
        }

        public float SetX(float x)
        {
            X = x;
            return X;
        }
        
        public float SetY(float y)
        {
            Y = y;
            return Y;
        }

        public Vector2 SetXY(float x, float y)
        {
            X = y;
            Y = y;
            return new Vector2(X, Y);
        }

    }
}