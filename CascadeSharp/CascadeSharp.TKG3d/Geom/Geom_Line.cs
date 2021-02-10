//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG3d.Geom
{
    //---------------------------------------------------------------------
    //  Class  Geom_Line
    //---------------------------------------------------------------------
    public sealed class Geom_Line : Geom_Curve
    {
        public Geom_Line(gp_Ax1 A1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Line(gp_Lin L)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Line(gp_Pnt P, gp_Dir V)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Line(Geom_Line parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom_Line()
        {
            throw new NotImplementedException();
        }

        public void SetLin(gp_Lin L)
        {
            throw new NotImplementedException();
        }

        public void SetDirection(gp_Dir V)
        {
            throw new NotImplementedException();
        }

        public void SetLocation(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(gp_Ax1 A1)
        {
            throw new NotImplementedException();
        }

        public gp_Lin Lin()
        {
            throw new NotImplementedException();
        }

        public gp_Ax1 Position()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public double ReversedParameter(double U)
        {
            throw new NotImplementedException();
        }

        public double FirstParameter()
        {
            throw new NotImplementedException();
        }

        public double LastParameter()
        {
            throw new NotImplementedException();
        }

        public bool IsClosed()
        {
            throw new NotImplementedException();
        }

        public bool IsPeriodic()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_Shape Continuity()
        {
            throw new NotImplementedException();
        }

        public bool IsCN(int N)
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt P, gp_Vec V1)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, gp_Pnt P, gp_Vec V1, gp_Vec V2, gp_Vec V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec DN(double U, int N)
        {
            throw new NotImplementedException();
        }

        public void Transform(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public double TransformedParameter(double U, gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public double ParametricTransformation(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public Geom_Geometry Copy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom_Line
}