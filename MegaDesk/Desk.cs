using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        public float Width;
        public float Height;
        public int NumberOfDrawers;
        public string SurfaceMaterial;

        public enum DeskMaterial
        {
            oak = 1,
            wood = 2
        }

        public Desk(float width = 0.0f, float height = 0.0f, int numberOfDrawers = 0, string surfaceMateral = "laminate")
        {
            this.Width = width;
            this.Height = height;
            this.NumberOfDrawers = numberOfDrawers;
            this.SurfaceMaterial = surfaceMateral;
        }

        public float getArea()
        {
            return this.Width * this.Height;
        }


    }
}
