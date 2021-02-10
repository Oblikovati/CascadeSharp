//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKMath.gp
{
    //---------------------------------------------------------------------
    //  Class  gp_Trsf2d
    //---------------------------------------------------------------------
    public sealed class gp_Trsf2d
    {
        public gp_Trsf2d()
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Trsf2d(gp_Trsf T)
            : base()
        {
            throw new NotImplementedException();
        }

        public gp_Trsf2d(gp_Trsf2d parameter1)
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

        public void SetTranslationPart(gp_Vec2d V)
        {
            throw new NotImplementedException();
        }

        public void SetScaleFactor(double S)
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

        public gp_XY TranslationPart()
        {
            throw new NotImplementedException();
        }

        public gp_Mat2d VectorialPart()
        {
            throw new NotImplementedException();
        }

        public gp_Mat2d HVectorialPart()
        {
            throw new NotImplementedException();
        }

        public double RotationPart()
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

        public gp_Trsf2d Inverted()
        {
            throw new NotImplementedException();
        }

        public gp_Trsf2d Multiplied(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public void Multiply(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public void PreMultiply(gp_Trsf2d T)
        {
            throw new NotImplementedException();
        }

        public void Power(int N)
        {
            throw new NotImplementedException();
        }

        public gp_Trsf2d Powered(int N)
        {
            throw new NotImplementedException();
        }

        public void Transforms(ref double X, ref double Y)
        {
            throw new NotImplementedException();
        }

        public void Transforms(gp_XY Coord)
        {
            throw new NotImplementedException();
        }

        public void SetValues(double a11, double a12, double a13, double a21, double a22, double a23)
        {
            throw new NotImplementedException();
        }

        public void Orthogonalize()
        {
            throw new NotImplementedException();
        }
    }; // class gp_Trsf2d
}