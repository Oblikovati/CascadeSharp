//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKG3d.TColGeom;

namespace CascadeSharp.TKShHealing.ShapeUpgrade
{
    //---------------------------------------------------------------------
    //  Class  ShapeUpgrade_SplitCurve3d
    //---------------------------------------------------------------------
    public class ShapeUpgrade_SplitCurve3d : ShapeUpgrade_SplitCurve
    {
        public ShapeUpgrade_SplitCurve3d()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeUpgrade_SplitCurve3d(ShapeUpgrade_SplitCurve3d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(Geom_Curve C)
        {
            throw new NotImplementedException();
        }

        public void Init(Geom_Curve C, double First, double Last)
        {
            throw new NotImplementedException();
        }

        public void Build(bool Segment)
        {
            throw new NotImplementedException();
        }

        public TColGeom_HArray1OfCurve GetCurves()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class ShapeUpgrade_SplitCurve3d
}