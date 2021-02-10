//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomAlgo.Geom2dInt;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepClass
{
    //---------------------------------------------------------------------
    //  Class  BRepClass_Intersector
    //---------------------------------------------------------------------
    public sealed class BRepClass_Intersector : Geom2dInt_IntConicCurveOfGInter
    {
        public BRepClass_Intersector()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepClass_Intersector(BRepClass_Intersector parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Perform(gp_Lin2d L, double P, double Tol, BRepClass_Edge E)
        {
            throw new NotImplementedException();
        }

        public void LocalGeometry(BRepClass_Edge E, double U, gp_Dir2d T, gp_Dir2d N, ref double C)
        {
            throw new NotImplementedException();
        }
    }; // class BRepClass_Intersector
}