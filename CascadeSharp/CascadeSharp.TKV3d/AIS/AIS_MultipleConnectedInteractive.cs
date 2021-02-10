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
    //  Class  AIS_MultipleConnectedInteractive
    //---------------------------------------------------------------------
    public sealed class AIS_MultipleConnectedInteractive : AIS_InteractiveObject
    {
        public AIS_MultipleConnectedInteractive()
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_MultipleConnectedInteractive(AIS_MultipleConnectedInteractive parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public AIS_InteractiveObject Connect(AIS_InteractiveObject theAnotherObj, TopLoc_Datum3D theLocation,
            Graphic3d_TransformPers theTrsfPers)
        {
            throw new NotImplementedException();
        }

        public AIS_KindOfInteractive Type()
        {
            throw new NotImplementedException();
        }

        public int Signature()
        {
            throw new NotImplementedException();
        }

        public bool HasConnection()
        {
            throw new NotImplementedException();
        }

        public void Disconnect(AIS_InteractiveObject theInteractive)
        {
            throw new NotImplementedException();
        }

        public void DisconnectAll()
        {
            throw new NotImplementedException();
        }

        public bool AcceptShapeDecomposition()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner GetAssemblyOwner()
        {
            throw new NotImplementedException();
        }

        public SelectMgr_EntityOwner GlobalSelOwner()
        {
            throw new NotImplementedException();
        }

        public void SetContext(AIS_InteractiveContext theCtx)
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject Connect(AIS_InteractiveObject theAnotherObj)
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject Connect(AIS_InteractiveObject theAnotherObj, gp_Trsf theLocation)
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject Connect(AIS_InteractiveObject theAnotherObj, gp_Trsf theLocation,
            Graphic3d_TransformPers theTrsfPers)
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject Connect(AIS_InteractiveObject theInteractive, gp_Trsf theLocation,
            ref Graphic3d_TransModeFlags theTrsfPersFlag, gp_Pnt theTrsfPersPoint)
        {
            throw new NotImplementedException();
        }

        public AIS_InteractiveObject connect(AIS_InteractiveObject theInteractive, TopLoc_Datum3D theLocation,
            Graphic3d_TransformPers theTrsfPers)
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection aSelection, int aMode)
        {
            throw new NotImplementedException();
        }
    }; // class AIS_MultipleConnectedInteractive
}