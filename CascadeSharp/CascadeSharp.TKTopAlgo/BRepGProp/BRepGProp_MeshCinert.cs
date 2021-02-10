//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.GProp;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKTopAlgo.BRepGProp
{
    //---------------------------------------------------------------------
    //  Class  BRepGProp_MeshCinert
    //---------------------------------------------------------------------
    public sealed class BRepGProp_MeshCinert : GProp_GProps
    {
        public BRepGProp_MeshCinert()
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepGProp_MeshCinert(BRepGProp_MeshCinert parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetLocation(gp_Pnt CLocation)
        {
            throw new NotImplementedException();
        }

        public void Perform(TColgp_Array1OfPnt theNodes)
        {
            throw new NotImplementedException();
        }

        public void PreparePolygon(TopoDS_Edge theE, TColgp_HArray1OfPnt thePolyg)
        {
            throw new NotImplementedException();
        }
    }; // class BRepGProp_MeshCinert
}