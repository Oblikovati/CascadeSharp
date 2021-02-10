//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2dAdaptor;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.Geom2dHatch
{
    //---------------------------------------------------------------------
    //  Class  Geom2dHatch_Elements
    //---------------------------------------------------------------------
    public sealed class Geom2dHatch_Elements
    {
        public Geom2dHatch_Elements()
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dHatch_Elements(Geom2dHatch_Elements Other)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Bind(int K, Geom2dHatch_Element I)
        {
            throw new NotImplementedException();
        }

        public bool IsBound(int K)
        {
            throw new NotImplementedException();
        }

        public bool UnBind(int K)
        {
            throw new NotImplementedException();
        }

        public Geom2dHatch_Element Find(int K)
        {
            throw new NotImplementedException();
        }

        public Geom2dHatch_Element ChangeFind(int K)
        {
            throw new NotImplementedException();
        }

        public bool CheckPoint(gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public bool Reject(gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public bool Segment(gp_Pnt2d P, gp_Lin2d L, ref double Par)
        {
            throw new NotImplementedException();
        }

        public bool OtherSegment(gp_Pnt2d P, gp_Lin2d L, ref double Par)
        {
            throw new NotImplementedException();
        }

        public void InitWires()
        {
            throw new NotImplementedException();
        }

        public bool MoreWires()
        {
            throw new NotImplementedException();
        }

        public void NextWire()
        {
            throw new NotImplementedException();
        }

        public bool RejectWire(gp_Lin2d L, double Par)
        {
            throw new NotImplementedException();
        }

        public void InitEdges()
        {
            throw new NotImplementedException();
        }

        public bool MoreEdges()
        {
            throw new NotImplementedException();
        }

        public void NextEdge()
        {
            throw new NotImplementedException();
        }

        public bool RejectEdge(gp_Lin2d L, double Par)
        {
            throw new NotImplementedException();
        }

        public void CurrentEdge(Geom2dAdaptor_Curve E, ref TopAbs_Orientation Or)
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dHatch_Elements
}