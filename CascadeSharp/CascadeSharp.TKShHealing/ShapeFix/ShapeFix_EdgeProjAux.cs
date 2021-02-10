//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKG2d.Geom2d;

namespace CascadeSharp.TKShHealing.ShapeFix
{
    //---------------------------------------------------------------------
    //  Class  ShapeFix_EdgeProjAux
    //---------------------------------------------------------------------
    public sealed class ShapeFix_EdgeProjAux : Standard_Transient
    {
        public ShapeFix_EdgeProjAux()
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_EdgeProjAux(TopoDS_Face F, TopoDS_Edge E)
            : base()
        {
            throw new NotImplementedException();
        }

        public ShapeFix_EdgeProjAux(ShapeFix_EdgeProjAux parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(TopoDS_Face F, TopoDS_Edge E)
        {
            throw new NotImplementedException();
        }

        public void Compute(double preci)
        {
            throw new NotImplementedException();
        }

        public bool IsFirstDone()
        {
            throw new NotImplementedException();
        }

        public bool IsLastDone()
        {
            throw new NotImplementedException();
        }

        public double FirstParam()
        {
            throw new NotImplementedException();
        }

        public double LastParam()
        {
            throw new NotImplementedException();
        }

        public bool IsIso(Geom2d_Curve C)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void Init2d(double preci)
        {
            throw new NotImplementedException();
        }

        public void Init3d(double preci)
        {
            throw new NotImplementedException();
        }

        public void UpdateParam2d(Geom2d_Curve C)
        {
            throw new NotImplementedException();
        }
    }; // class ShapeFix_EdgeProjAux
}