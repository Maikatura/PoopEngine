namespace PoopEngine.Lib
{
    public class Time
    {
        public static float deltaTime;
        
        public static void Update(float dt)
        {
            deltaTime = dt;
        }

    }
}