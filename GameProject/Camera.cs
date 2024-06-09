using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class Camera
    {
        public float Zoom { get; set; }
        public Vector2 Position { get; set; }
        public Matrix Transform { get; protected set; }

        public Camera(int screenWidth)
        {
            Zoom = (float)screenWidth / 1200;
            Position = Vector2.Zero;
        }

        public void UpdateMatrix(Viewport viewport)
        {
            Transform = Matrix.CreateTranslation(new Vector3(-Position.X, -Position.Y, 0)) *
            Matrix.CreateScale(Zoom) *
            Matrix.CreateTranslation(new Vector3(viewport.Width * 0.5f, viewport.Height * 0.5f, 0));
        }
    }
}
