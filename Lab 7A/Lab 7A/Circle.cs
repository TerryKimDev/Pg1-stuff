using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    public class Circle
    {
        //field
        float mX, mY, mRadius;

        //constructor
        #region The Constructor
        public Circle(float X, float Y, float radius)
        {
            mX = X;
            mY = Y;
            mRadius = radius;
        }
        #endregion

        //Accessors
        #region The Accessors

        public float GetX()
        {
            return mX;
        }

        public float GetY()
        {
            return mY;
        }
        public float GetRadius()
        {
            return mRadius;
        }
        #endregion


        //method of class
        #region Aregion
        //area
        public float GetArea()
        {
            return ((float)(Math.PI * Math.Pow(mRadius, 2)));
        }

        //check if point is within bounds
        public bool Contains(float px, float py)
        {
            return(mRadius >= Math.Sqrt(Math.Pow(px - mX, 2) + Math.Pow(py - mY, 2)));
        }

        //The circumference
        public float GetCircumference()
        {
            return (float)(2*mRadius*Math.PI);
        }
        #endregion
    }
}
