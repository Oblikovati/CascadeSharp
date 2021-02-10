//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_ConnectedInteractive
    //---------------------------------------------------------------------
    public sealed class AIS_ConnectedInteractive : AIS_InteractiveObject
    {
        public AIS_ConnectedInteractive(AIS_ConnectedInteractive parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_ConnectedInteractive()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public AIS_KindOfInteractive Type()
        {
            throw new NotImplementedException();
        }

        public int Signature()
        {
            throw new NotImplementedException();
        }

        public void Connect(AIS_InteractiveObject theAnotherObj)
        {
            throw new NotImplementedException();
        }

        public void Connect(AIS_InteractiveObject theAnotherObj, gp_Trsf theLocation)
        {
            throw new NotImplementedException();
        }

        public void Connect(AIS_InteractiveObject theAnotherObj, TopLoc_Datum3D theLocation)
        {
            throw new NotImplementedException();
        }

        public bool HasConnection()
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject ConnectedTo()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public bool AcceptShapeDecomposition()
        {
            throw new NotImplementedException();
        }

        public bool AcceptDisplayMode(int theMode)
        {
            throw new NotImplementedException();
        }

        public void computeHLR(Graphic3d_Camera theProjector, TopLoc_Datum3D theTrsf, Graphic3d_Structure thePrs)
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
        {
            throw new NotImplementedException();
        }

        public void computeSubShapeSelection(SelectMgr_Selection theSelection, int theMode)
        {
            throw new NotImplementedException();
        }

        public void updateShape(bool WithLocation)
        {
            throw new NotImplementedException();
        }

        public void updateShape()
        {
            throw new NotImplementedException();
        }

        public void connect(AIS_InteractiveObject theAnotherObj, TopLoc_Datum3D theLocation)
        {
            throw new NotImplementedException();
        }
    }; // class AIS_ConnectedInteractive
}