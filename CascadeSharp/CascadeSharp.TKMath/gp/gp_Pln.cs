//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.gp
{
    //---------------------------------------------------------------------
    //  Class  gp_Pln
    //---------------------------------------------------------------------
    public sealed class gp_Pln
    {
        public gp_Pln()
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Pln(gp_Ax3 A3)
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Pln(gp_Pnt P, gp_Dir V)
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Pln(double A, double B, double C, double D)
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Pln(gp_Pln parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Coefficients(ref double A, ref double B, ref double C, ref double D)
        {
            throw new NotImplementedException();
        }

        public void SetAxis(gp_Ax1 A1)
        {
            throw new NotImplementedException();
        }

        public void SetLocation(gp_Pnt Loc)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(gp_Ax3 A3)
        {
            throw new NotImplementedException();
        }

        public void UReverse()
        {
            throw new NotImplementedException();
        }

        public void VReverse()
        {
            throw new NotImplementedException();
        }

        public bool Direct()
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 Axis()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Location()
        {
            throw new NotImplementedException();
        }

        public gp_Ax3 Position()
        {
            throw new NotImplementedException();
        }

        public double Distance(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public double Distance(gp_Lin L)
        {
            throw new NotImplementedException();
        }

        public double Distance(gp_Pln Other)
        {
            throw new NotImplementedException();
        }

        public double SquareDistance(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public double SquareDistance(gp_Lin L)
        {
            throw new NotImplementedException();
        }

        public double SquareDistance(gp_Pln Other)
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 XAxis()
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 YAxis()
        {
            throw new NotImplementedException();
        }

        public bool Contains(gp_Pnt P, double LinearTolerance)
        {
            throw new NotImplementedException();
        }

        public bool Contains(gp_Lin L, double LinearTolerance, double AngularTolerance)
        {
            throw new NotImplementedException();
        }

        public void Mirror(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Mirrored(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void Mirror(gp_Ax1 A1)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Mirrored(gp_Ax1 A1)
        {
            throw new NotImplementedException();
        }

        public void Mirror(gp_Ax2 A2)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Mirrored(gp_Ax2 A2)
        {
            throw new NotImplementedException();
        }

        public void Rotate(gp_Ax1 A1, double Ang)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Rotated(gp_Ax1 A1, double Ang)
        {
            throw new NotImplementedException();
        }

        public void Scale(gp_Pnt P, double S)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Scaled(gp_Pnt P, double S)
        {
            throw new NotImplementedException();
        }

        public void Transform(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Transformed(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public void Translate(gp_Vec V)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Translated(gp_Vec V)
        {
            throw new NotImplementedException();
        }

        public void Translate(gp_Pnt P1, gp_Pnt P2)
        {
            throw new NotImplementedException();
        }

        public gp_Pln Translated(gp_Pnt P1, gp_Pnt P2)
        {
            throw new NotImplementedException();
        }
    }; // class gp_Pln
}