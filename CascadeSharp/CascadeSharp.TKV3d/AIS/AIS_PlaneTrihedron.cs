//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_PlaneTrihedron
    //---------------------------------------------------------------------
    public sealed class AIS_PlaneTrihedron : AIS_InteractiveObject
    {
        public AIS_PlaneTrihedron(Geom_Plane aPlane)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_PlaneTrihedron(AIS_PlaneTrihedron parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_PlaneTrihedron()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public Geom_Plane Component()
        {
            throw new NotImplementedException();
        }

        public void SetComponent(Geom_Plane aPlane)
        {
            throw new NotImplementedException();
        }

        public AIS_Line XAxis()
        {
            throw new NotImplementedException();
        }

        public AIS_Line YAxis()
        {
            throw new NotImplementedException();
        }

        public AIS_Point Position()
        {
            throw new NotImplementedException();
        }

        public void SetLength(double theLength)
        {
            throw new NotImplementedException();
        }

        public double GetLength()
        {
            throw new NotImplementedException();
        }

        public bool AcceptDisplayMode(int aMode)
        {
            throw new NotImplementedException();
        }

        public int Signature()
        {
            throw new NotImplementedException();
        }

        public AIS_KindOfInteractive Type()
        {
            throw new NotImplementedException();
        }

        public void SetColor(Quantity_Color theColor)
        {
            throw new NotImplementedException();
        }

        public void SetXLabel(TCollection_AsciiString theLabel)
        {
            throw new NotImplementedException();
        }

        public void SetYLabel(TCollection_AsciiString theLabel)
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection aSelection, int aMode)
        {
            throw new NotImplementedException();
        }
    }; // class AIS_PlaneTrihedron
}