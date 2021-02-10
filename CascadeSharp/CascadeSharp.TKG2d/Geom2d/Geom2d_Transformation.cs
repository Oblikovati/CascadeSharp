//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKG2d.Geom2d
{
    //---------------------------------------------------------------------
    //  Class  Geom2d_Transformation
    //---------------------------------------------------------------------
    public sealed class Geom2d_Transformation : Standard_Transient
    {
        public Geom2d_Transformation()
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Transformation(gp_Trsf2d T)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Transformation(Geom2d_Transformation parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetMirror(gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public void SetMirror(gp_Ax2d A)
        {
            throw new NotImplementedException();
        }

        public void SetRotation(gp_Pnt2d P, double Ang)
        {
            throw new NotImplementedException();
        }

        public void SetScale(gp_Pnt2d P, double S)
        {
            throw new NotImplementedException();
        }

        public void SetTransformation(gp_Ax2d FromSystem1, gp_Ax2d ToSystem2)
        {
            throw new NotImplementedException();
        }

        public void SetTransformation(gp_Ax2d ToSystem)
        {
            throw new NotImplementedException();
        }

        public void SetTranslation(gp_Vec2d V)
        {
            throw new NotImplementedException();
        }

        public void SetTranslation(gp_Pnt2d P1, gp_Pnt2d P2)
        {
            throw new NotImplementedException();
        }

        public void SetTrsf2d(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public bool IsNegative()
        {
            throw new NotImplementedException();
        }

        public gp_TrsfForm Form()
        {
            throw new NotImplementedException();
        }

        public double ScaleFactor()
        {
            throw new NotImplementedException();
        }

        public gp_Trsf2d Trsf2d()
        {
            throw new NotImplementedException();
        }

        public double Value(int Row, int Col)
        {
            throw new NotImplementedException();
        }

        public void Invert()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Transformation Inverted()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Transformation Multiplied(Geom2d_Transformation Other)
        {
            throw new NotImplementedException();
        }

        public void Multiply(Geom2d_Transformation Other)
        {
            throw new NotImplementedException();
        }

        public void Power(int N)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Transformation Powered(int N)
        {
            throw new NotImplementedException();
        }

        public void PreMultiply(Geom2d_Transformation Other)
        {
            throw new NotImplementedException();
        }

        public void Transforms(ref double X, ref double Y)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Transformation Copy()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom2d_Transformation
}