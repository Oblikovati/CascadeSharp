//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
    //---------------------------------------------------------------------
    //  Class  Geom2d_Hyperbola
    //---------------------------------------------------------------------
    public sealed class Geom2d_Hyperbola : Geom2d_Conic
    {
        public Geom2d_Hyperbola(gp_Hypr2d H)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Hyperbola(gp_Ax2d MajorAx_is, double MajorRadius, double MinorRadius, bool Sense)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Hyperbola(gp_Ax2d MajorAx_is, double MajorRadius, double MinorRadius)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Hyperbola(gp_Ax22d Ax_is, double MajorRadius, double MinorRadius)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Hyperbola(Geom2d_Hyperbola parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Hyperbola()
        {
            throw new NotImplementedException();
        }

        public void SetHypr2d(gp_Hypr2d H)
        {
            throw new NotImplementedException();
        }

        public void SetMajorRadius(double MajorRadius)
        {
            throw new NotImplementedException();
        }

        public void SetMinorRadius(double MinorRadius)
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d Hypr2d()
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

        public gp_Ax2d Asymptote1()
        {
            throw new NotImplementedException();
        }

        public gp_Ax2d Asymptote2()
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d ConjugateBranch1()
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d ConjugateBranch2()
        {
            throw new NotImplementedException();
        }

        public gp_Ax2d Directrix1()
        {
            throw new NotImplementedException();
        }

        public gp_Ax2d Directrix2()
        {
            throw new NotImplementedException();
        }

        public double Eccentricity()
        {
            throw new NotImplementedException();
        }

        public double Focal()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Focus1()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Focus2()
        {
            throw new NotImplementedException();
        }

        public double MajorRadius()
        {
            throw new NotImplementedException();
        }

        public double MinorRadius()
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d OtherBranch()
        {
            throw new NotImplementedException();
        }

        public double Parameter()
        {
            throw new NotImplementedException();
        }

        public void D0(double U, gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public void D1(double U, gp_Pnt2d P, gp_Vec2d V1)
        {
            throw new NotImplementedException();
        }

        public void D2(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2)
        {
            throw new NotImplementedException();
        }

        public void D3(double U, gp_Pnt2d P, gp_Vec2d V1, gp_Vec2d V2, gp_Vec2d V3)
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d DN(double U, int N)
        {
            throw new NotImplementedException();
        }

        public void Transform(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Geometry Copy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom2d_Hyperbola
}