using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PoopEngine.Lib.ECS
{
    public class SpriteAnimation : Component
    {
        
        private string Path;
        private int framesPerSecond;
        private float timeToNextFrame;
        

        private int currentFrameX = 0;
        private int currentFrameY = 0;

        private Sprite sprite;
        private Rectangle spriteRectangle;

        private int Width, Height;

        private bool isPressed = false;

        public SpriteAnimation()
        {
            
        }

        public SpriteAnimation(string path, int width, int height, int fps)
        {
            sprite = new Sprite(Graphics.Content.Load<Texture2D>(path));
            Path = path;
            Width = width;
            Height = height;
            framesPerSecond = fps;

            spriteRectangle = new Rectangle();
            
            spriteRectangle.Width = width;
            spriteRectangle.Height = height;
            
            currentFrameX = 0;
            currentFrameY = 0;
            
        }

        public static SpriteAnimation MakeAnimation(string path, int width, int height, int fps)
        {
            SpriteAnimation animation = new SpriteAnimation(path, width, height, fps);

            return animation;
        }
        
        public Rectangle NextFrame()
        {
            Rectangle rectangle = new Rectangle();

            MoreXYFrames();

            rectangle.Width = Width;
            rectangle.Height = Height;
            
            rectangle.X = Width * currentFrameX;
            rectangle.Y = Height * currentFrameY;
            
            Console.WriteLine(rectangle.X + "|" + rectangle.Y);
            
            spriteRectangle = rectangle;

            return rectangle;
        }

        private void MoreXYFrames()
        {
            if (Width * currentFrameX >= sprite.Width - Width)
            {
                currentFrameX = 0;
                
                if (Height * currentFrameY >= sprite.Height - Height)
                {
                    currentFrameY = 0;
                }
                else
                {
                    currentFrameY++;
                }
            }
            else
            {
                currentFrameX++;
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            
            if (timeToNextFrame >= framesPerSecond)
            {
                timeToNextFrame = 0;
                //NextFrame();
            }
            
            if (Keyboard.GetState().IsKeyDown(Keys.A) && !isPressed)
            {
                isPressed = true;
                NextFrame();
            }
            else if (Keyboard.GetState().IsKeyUp(Keys.A) && isPressed)
            {
                isPressed = false;
            }


            timeToNextFrame += (float)gameTime.ElapsedGameTime.TotalMilliseconds / framesPerSecond;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            Graphics.Batcher.Draw(sprite.Texture(), Entity.Transform.Position, spriteRectangle, Color.White);
            
        }
    }
}