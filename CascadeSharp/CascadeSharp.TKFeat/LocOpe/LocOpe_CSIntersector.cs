//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.TColGeom;
using CascadeSharp.TKG3d.TopAbs;

namespace CascadeSharp.TKFeat.LocOpe
{
    //---------------------------------------------------------------------
    //  Class  LocOpe_CSIntersector
    //---------------------------------------------------------------------
    public sealed class LocOpe_CSIntersector
    {
        public LocOpe_CSIntersector()
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_CSIntersector(TopoDS_Shape S)
            : base()
        {
            throw new NotImplementedException();
        }

        public LocOpe_CSIntersector(LocOpe_CSIntersector parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Perform(LocOpe_SequenceOfLin Slin)
        {
            throw new NotImplementedException();
        }

        public void Perform(LocOpe_SequenceOfCirc Scir)
        {
            throw new NotImplementedException();
        }

        public void Perform(TColGeom_SequenceOfCurve Scur)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public int NbPoints(int I)
        {
            throw new NotImplementedException();
        }

        public LocOpe_PntFace Point(int I, int Index)
        {
            throw new NotImplementedException();
        }

        public bool LocalizeAfter(int I, double From, double Tol, ref TopAbs_Orientation Or, ref int IndFrom,
            ref int IndTo)
        {
            throw new NotImplementedException();
        }

        public bool LocalizeBefore(int I, double From, double Tol, ref TopAbs_Orientation Or, ref int IndFrom,
            ref int IndTo)
        {
            throw new NotImplementedException();
        }

        public bool LocalizeAfter(int I, int FromInd, double Tol, ref TopAbs_Orientation Or, ref int IndFrom,
            ref int IndTo)
        {
            throw new NotImplementedException();
        }

        public bool LocalizeBefore(int I, int FromInd, double Tol, ref TopAbs_Orientation Or, ref int IndFrom,
            ref int IndTo)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }; // class LocOpe_CSIntersector
}