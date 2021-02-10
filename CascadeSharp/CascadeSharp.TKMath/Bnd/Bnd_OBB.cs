//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKMath.Bnd
{
    //---------------------------------------------------------------------
    //  Class  Bnd_OBB
    //---------------------------------------------------------------------
    public sealed class Bnd_OBB
    {
        public Bnd_OBB()
            : base()
        {
            throw new NotImplementedException();
        }

        public Bnd_OBB(gp_Pnt theCenter, gp_Dir theXDirection, gp_Dir theYDirection, gp_Dir theZDirection,
            double theHXSize, double theHYSize, double theHZSize)
            : base()
        {
            throw new NotImplementedException();
        }

        public Bnd_OBB(Bnd_Box theBox)
            : base()
        {
            throw new NotImplementedException();
        }

        public Bnd_OBB(Bnd_OBB parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void ReBuild(TColgp_Array1OfPnt theL_istOfPoints, TColStd_Array1OfReal theL_istOfTolerances,
            bool theIsOptimal)
        {
            throw new NotImplementedException();
        }

        public void ReBuild(TColgp_Array1OfPnt theL_istOfPoints, TColStd_Array1OfReal theL_istOfTolerances)
        {
            throw new NotImplementedException();
        }

        public void ReBuild(TColgp_Array1OfPnt theL_istOfPoints)
        {
            throw new NotImplementedException();
        }

        public void SetCenter(gp_Pnt theCenter)
        {
            throw new NotImplementedException();
        }

        public void SetXComponent(gp_Dir theXDirection, double theHXSize)
        {
            throw new NotImplementedException();
        }

        public void SetYComponent(gp_Dir theYDirection, double theHYSize)
        {
            throw new NotImplementedException();
        }

        public void SetZComponent(gp_Dir theZDirection, double theHZSize)
        {
            throw new NotImplementedException();
        }

        public gp_Ax3 Position()
        {
            throw new NotImplementedException();
        }

        public gp_XYZ Center()
        {
            throw new NotImplementedException();
        }

        public gp_XYZ XDirection()
        {
            throw new NotImplementedException();
        }

        public gp_XYZ YDirection()
        {
            throw new NotImplementedException();
        }

        public gp_XYZ ZDirection()
        {
            throw new NotImplementedException();
        }

        public double XHSize()
        {
            throw new NotImplementedException();
        }

        public double YHSize()
        {
            throw new NotImplementedException();
        }

        public double ZHSize()
        {
            throw new NotImplementedException();
        }

        public bool IsVoid()
        {
            throw new NotImplementedException();
        }

        public void SetVoid()
        {
            throw new NotImplementedException();
        }

        public void SetAABox(bool theFlag)
        {
            throw new NotImplementedException();
        }

        public bool IsAABox()
        {
            throw new NotImplementedException();
        }

        public void Enlarge(double theGapAdd)
        {
            throw new NotImplementedException();
        }

        public bool GetVertex(gp_Pnt theP)
        {
            throw new NotImplementedException();
        }

        public double SquareExtent()
        {
            throw new NotImplementedException();
        }

        public bool IsOut(Bnd_OBB theOther)
        {
            throw new NotImplementedException();
        }

        public bool IsOut(gp_Pnt theP)
        {
            throw new NotImplementedException();
        }

        public bool IsCompletelyInside(Bnd_OBB theOther)
        {
            throw new NotImplementedException();
        }

        public void Add(Bnd_OBB theOther)
        {
            throw new NotImplementedException();
        }

        public void Add(gp_Pnt theP)
        {
            throw new NotImplementedException();
        }

        public void ProcessOnePoint(gp_Pnt theP)
        {
            throw new NotImplementedException();
        }
    }; // class Bnd_OBB
}