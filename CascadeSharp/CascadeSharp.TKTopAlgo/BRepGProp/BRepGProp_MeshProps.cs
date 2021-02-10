//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.GProp;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepGProp
{
    //---------------------------------------------------------------------
    //  Class  BRepGProp_MeshProps
    //---------------------------------------------------------------------
    public sealed class BRepGProp_MeshProps : GProp_GProps
    {
        public BRepGProp_MeshProps(BRepGProp_MeshObjType theType)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepGProp_MeshProps(BRepGProp_MeshProps parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public BRepGProp_MeshProps()
        {
            throw new NotImplementedException();
        }

        public void SetLocation(gp_Pnt theLocation)
        {
            throw new NotImplementedException();
        }

        public void CalculateProps(gp_Pnt p1, gp_Pnt p2, gp_Pnt p3, gp_Pnt Apex, bool _isVolume, ref double GProps,
            int NbGaussPoints, double GaussPnts)
        {
            throw new NotImplementedException();
        }

        public BRepGProp_MeshObjType GetMeshObjType()
        {
            throw new NotImplementedException();
        }


        //---------------------------------------------------------------------
        //  Enum  BRepGProp_MeshObjType
        //---------------------------------------------------------------------
        public enum BRepGProp_MeshObjType
        {
            Vinert = 0,
            Sinert = 1
        } // enum  class BRepGProp_MeshObjType
    }; // class BRepGProp_MeshProps
}