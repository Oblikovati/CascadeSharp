//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKMath.Bnd
{
    //---------------------------------------------------------------------
    //  Class  Bnd_Box
    //---------------------------------------------------------------------
    public sealed class Bnd_Box
    {
        public Bnd_Box()
            : base()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box(gp_Pnt theMin, gp_Pnt theMax)
            : base()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box(Bnd_Box parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetWhole()
        {
            throw new NotImplementedException();
        }

        public void SetVoid()
        {
            throw new NotImplementedException();
        }

        public void Set(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void Set(gp_Pnt P, gp_Dir D)
        {
            throw new NotImplementedException();
        }

        public void Update(double aXmin, double aYmin, double aZmin, double aXmax, double aYmax, double aZmax)
        {
            throw new NotImplementedException();
        }

        public void Update(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public double GetGap()
        {
            throw new NotImplementedException();
        }

        public void SetGap(double Tol)
        {
            throw new NotImplementedException();
        }

        public void Enlarge(double Tol)
        {
            throw new NotImplementedException();
        }

        public void Get(ref double theXmin, ref double theYmin, ref double theZmin, ref double theXmax,
            ref double theYmax, ref double theZmax)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt CornerMin()
        {
            throw new NotImplementedException();
        }

        public gp_Pnt CornerMax()
        {
            throw new NotImplementedException();
        }

        public void OpenXmin()
        {
            throw new NotImplementedException();
        }

        public void OpenXmax()
        {
            throw new NotImplementedException();
        }

        public void OpenYmin()
        {
            throw new NotImplementedException();
        }

        public void OpenYmax()
        {
            throw new NotImplementedException();
        }

        public void OpenZmin()
        {
            throw new NotImplementedException();
        }

        public void OpenZmax()
        {
            throw new NotImplementedException();
        }

        public bool IsOpen()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenXmin()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenXmax()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenYmin()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenYmax()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenZmin()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenZmax()
        {
            throw new NotImplementedException();
        }

        public bool IsWhole()
        {
            throw new NotImplementedException();
        }

        public bool IsVoid()
        {
            throw new NotImplementedException();
        }

        public bool IsXThin(double tol)
        {
            throw new NotImplementedException();
        }

        public bool IsYThin(double tol)
        {
            throw new NotImplementedException();
        }

        public bool IsZThin(double tol)
        {
            throw new NotImplementedException();
        }

        public bool IsThin(double tol)
        {
            throw new NotImplementedException();
        }

        public Bnd_Box Transformed(gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public void Add(Bnd_Box Other)
        {
            throw new NotImplementedException();
        }

        public void Add(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public void Add(gp_Pnt P, gp_Dir D)
        {
            throw new NotImplementedException();
        }

        public void Add(gp_Dir D)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_Lin L)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_Pln P)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(Bnd_Box Other)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(Bnd_Box Other, gp_Trsf T)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_Trsf T1, Bnd_Box Other, gp_Trsf T2)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_Pnt P1, gp_Pnt P2, gp_Dir D)
        {
            throw new NotImplementedException();
        }

        public double Distance(Bnd_Box Other)
        {
            throw new NotImplementedException();
        }

        public void Dump()
        {
            throw new NotImplementedException();
        }

        public double SquareExtent()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box FinitePart()
        {
            throw new NotImplementedException();
        }

        public bool HasFinitePart()
        {
            throw new NotImplementedException();
        }


        //---------------------------------------------------------------------
        //  Enum  MaskFlags
        //---------------------------------------------------------------------
        public enum MaskFlags
        {
            VoidMask = 1,
            XminMask = 2,
            XmaxMask = 4,
            YminMask = 8,
            YmaxMask = 16,
            ZminMask = 32,
            ZmaxMask = 64,
            WholeMask = 126
        } // enum  class MaskFlags
    }; // class Bnd_Box
}