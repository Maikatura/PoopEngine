using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace PoopEngine.Lib.ECS
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
            Transform = new Transform();
        }

        public T AddComp<T>(T compToAdd) where T : Component
        {
            components.Add(compToAdd);
            CompHandler.Instance.Add(compToAdd);
            compToAdd.Initilize(this);
            return compToAdd;
        }

        public void RemoveComp<T>(T compToRemove) where T : Component
        {
            if (components.Contains(compToRemove))
            {
                components.Remove(compToRemove);
                CompHandler.Instance.Remove(compToRemove);
            }
        }

        public Component GetComp<T>(T compToGet) where T : Component
        {
            if (components.Contains(compToGet))
                return components.Find(x => x == compToGet);

            return null;
        }

        public bool HasComp<T>(T compToCheck) where T : Component
        {
            if (components.Contains(compToCheck))
                return true;
            
            return false;
        }
        


        public static Entity CreateEntity(string name)
        {
            var newEntity = new Entity(name);
            return newEntity;
        }
        
    }
}