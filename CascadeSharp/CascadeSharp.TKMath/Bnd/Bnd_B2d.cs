//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKMath.Bnd
{
    //---------------------------------------------------------------------
    //  Class  Bnd_B2d
    //---------------------------------------------------------------------
    public sealed class Bnd_B2d
    {
        public Bnd_B2d()
            : base()
        {
            throw new NotImplementedException();
        }

        public Bnd_B2d(gp_XY theCenter, gp_XY theHSize)
            : base()
        {
            throw new NotImplementedException();
        }

        public Bnd_B2d(Bnd_B2d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool IsVoid()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Add(gp_XY thePnt)
        {
            throw new NotImplementedException();
        }

        public void Add(gp_Pnt2d thePnt)
        {
            throw new NotImplementedException();
        }

        public void Add(Bnd_B2d theBox)
        {
            throw new NotImplementedException();
        }

        public gp_XY CornerMin()
        {
            throw new NotImplementedException();
        }

        public gp_XY CornerMax()
        {
            throw new NotImplementedException();
        }

        public double SquareExtent()
        {
            throw new NotImplementedException();
        }

        public void Enlarge(double theDiff)
        {
            throw new NotImplementedException();
        }

        public bool Limit(Bnd_B2d theOtherBox)
        {
            throw new NotImplementedException();
        }

        public Bnd_B2d Transformed(gp_Trsf2d theTrsf)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_XY thePnt)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_XY theCenter, double theRadius, bool _isCircleHollow)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_XY theCenter, double theRadius)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(Bnd_B2d theOtherBox)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(Bnd_B2d theOtherBox, gp_Trsf2d theTrsf)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_Ax2d theLine)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_XY theP0, gp_XY theP1)
        {
            throw new NotImplementedException();
        }

        public bool IsIn(Bnd_B2d theBox)
        {
            throw new NotImplementedException();
        }

        public bool IsIn(Bnd_B2d theBox, gp_Trsf2d theTrsf)
        {
            throw new NotImplementedException();
        }

        public void SetCenter(gp_XY theCenter)
        {
            throw new NotImplementedException();
        }

        public void SetHSize(gp_XY theHSize)
        {
            throw new NotImplementedException();
        }
    }; // class Bnd_B2d
}