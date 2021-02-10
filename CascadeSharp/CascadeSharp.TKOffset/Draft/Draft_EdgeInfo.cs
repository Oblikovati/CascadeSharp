//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKOffset.Draft
{
    //---------------------------------------------------------------------
    //  Class  Draft_EdgeInfo
    //---------------------------------------------------------------------
    public sealed class Draft_EdgeInfo
    {
        public Draft_EdgeInfo()
            : base()
        {
            throw new NotImplementedException();
        }

        public Draft_EdgeInfo(bool HasNewGeometry)
            : base()
        {
            throw new NotImplementedException();
        }

        public Draft_EdgeInfo(Draft_EdgeInfo parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Add(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void RootFace(TopoDS_Face F)
        {
            throw new NotImplementedException();
        }

        public void Tangent(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public bool IsTangent(gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public bool NewGeometry()
        {
            throw new NotImplementedException();
        }

        public void SetNewGeometry(bool NewGeom)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve Geometry()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face FirstFace()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face SecondFace()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve FirstPC()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve SecondPC()
        {
            throw new NotImplementedException();
        }

        public Geom_Curve ChangeGeometry()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve ChangeFirstPC()
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve ChangeSecondPC()
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face RootFace()
        {
            throw new NotImplementedException();
        }

        public void Tolerance(double tol)
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }
    }; // class Draft_EdgeInfo
}