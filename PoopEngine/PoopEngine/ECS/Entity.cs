using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace PoopEngine.ECS
{
    public class Entity
    {

        public string entityName = "";
        public Transform Transform;
        private List<Component> components = new List<Component>();
        


        public void Update(GameTime gameTime)
        {
            foreach (var component in components)
            {
                component.Update(gameTime);
            }
        }

        public void Draw(GameTime gameTime)
        {
            foreach (var component in components)
            {
                component.Draw(gameTime);
            }
        }

        public Entity(string name)
        {
            entityName = name;
        }

        public Component AddComponent(Component compToAdd)
        {
            components.Add(compToAdd);
            CompHandler.Instance.Add(compToAdd);
            return compToAdd;
        }

        public void RemoveComponent(Component compToRemove)
        {
            if (components.Contains(compToRemove))
            {
                components.Remove(compToRemove);
                CompHandler.Instance.Remove(compToRemove);
            }
                
        }


        public static Entity CreateEntity(string name)
        {
            var newEntity = new Entity(name);
            return newEntity;
        }
        
    }
}