//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepGProp
{
    //---------------------------------------------------------------------
    //  Class  BRepGProp_EdgeTool
    //---------------------------------------------------------------------
    public sealed class BRepGProp_EdgeTool
    {
        public BRepGProp_EdgeTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepGProp_EdgeTool(BRepGProp_EdgeTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public double FirstParameter(BRepAdaptor_Curve C)
        {
            throw new NotImplementedException();
        }

        public double LastParameter(BRepAdaptor_Curve C)
        {
            throw new NotImplementedException();
        }

        public int IntegrationOrder(BRepAdaptor_Curve C)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value(BRepAdaptor_Curve C, double U)
        {
            throw new NotImplementedException();
        }

        public void D1(BRepAdaptor_Curve C, double U, gp_Pnt P, gp_Vec V1)
        {
            throw new NotImplementedException();
        }

        public int NbIntervals(BRepAdaptor_Curve C, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }

        public void Intervals(BRepAdaptor_Curve C, TColStd_Array1OfReal T, GeomAbs_Shape S)
        {
            throw new NotImplementedException();
        }
    }; // class BRepGProp_EdgeTool
}