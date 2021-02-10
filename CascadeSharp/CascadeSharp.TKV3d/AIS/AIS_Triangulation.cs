//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_Triangulation
    //---------------------------------------------------------------------
    public sealed class AIS_Triangulation : AIS_InteractiveObject
    {
        public AIS_Triangulation(AIS_Triangulation parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_Triangulation()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void SetColors(TColStd_HArray1OfInteger aColor)
        {
            throw new NotImplementedException();
        }

        public TColStd_HArray1OfInteger GetColors()
        {
            throw new NotImplementedException();
        }

        public bool HasVertexColors()
        {
            throw new NotImplementedException();
        }

        public void SetTransparency(double aValue)
        {
            throw new NotImplementedException();
        }

        public void SetTransparency()
        {
            throw new NotImplementedException();
        }

        public void UnsetTransparency()
        {
            throw new NotImplementedException();
        }

        public void updatePresentation()
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection aSelection, int aMode)
        {
            throw new NotImplementedException();
        }
    }; // class AIS_Triangulation
}