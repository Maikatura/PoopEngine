using PoopEngine.Lib.ECS.Colliders;

namespace PoopEngine.Lib.ECS.Physics
{
    public class ColliderHelper
    {

        // Local is the Object, other is object that is colliding with local
        public virtual void OnTriggerEnter(Collider local, Collider other)
        {
            
        }
        
        // Local is the Object, other is object that is colliding with local
        public virtual void OnTriggerStay(Collider local, Collider other)
        {
            
        }
        
        // Local is the Object, other is object that is colliding with local
        public virtual void OnTriggerExit(Collider local, Collider other)
        {
            
        }
        
    }
}