//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.TColGeom2d;

namespace CascadeSharp.TKShHealing.ShapeUpgrade
{
    //---------------------------------------------------------------------
    //  Class  ShapeUpgrade_ConvertCurve2dToBezier
    //---------------------------------------------------------------------
    public sealed class ShapeUpgrade_ConvertCurve2dToBezier : ShapeUpgrade_SplitCurve2d
    {
        public ShapeUpgrade_ConvertCurve2dToBezier()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeUpgrade_ConvertCurve2dToBezier(ShapeUpgrade_ConvertCurve2dToBezier parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Compute()
        {
            throw new NotImplementedException();
        }

        public void Build(bool Segment)
        {
            throw new NotImplementedException();
        }

        public TColStd_HSequenceOfReal SplitParams()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public TColGeom2d_HSequenceOfCurve Segments()
        {
            throw new NotImplementedException();
        }
    }; // class ShapeUpgrade_ConvertCurve2dToBezier
}