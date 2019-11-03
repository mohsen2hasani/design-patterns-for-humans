using System;
using System.Collections.Generic;
using System.Text;

namespace MH.SimpleFactory
{
    public class WoodenDoor : IDoor
    {
        protected float _width;
        protected float _height;

        public WoodenDoor(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public float GetWidth()
        {
            return _width;
        }

        public float GetHeight()
        {
            return _height;
        }
    }
}