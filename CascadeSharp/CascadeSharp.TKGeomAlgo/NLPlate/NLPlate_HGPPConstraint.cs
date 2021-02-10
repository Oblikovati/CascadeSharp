//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKGeomAlgo.Plate;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.NLPlate
{
    //---------------------------------------------------------------------
    //  Class  NLPlate_HGPPConstraint
    //---------------------------------------------------------------------
    public abstract class NLPlate_HGPPConstraint : Standard_Transient
    {
        public NLPlate_HGPPConstraint()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public NLPlate_HGPPConstraint(NLPlate_HGPPConstraint parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public void SetUVFreeSliding(bool UVFree)
        {
            throw new NotImplementedException();
        }

        public void SetIncrementalLoadAllowed(bool ILA)
        {
            throw new NotImplementedException();
        }

        public void SetActiveOrder(int ActiveOrder)
        {
            throw new NotImplementedException();
        }

        public void SetUV(gp_XY UV)
        {
            throw new NotImplementedException();
        }

        public void SetOrientation(int Orient)
        {
            throw new NotImplementedException();
        }

        public void SetOrientation()
        {
            throw new NotImplementedException();
        }

        public void SetG0Criterion(double TolD_ist)
        {
            throw new NotImplementedException();
        }

        public void SetG1Criterion(double TolAng)
        {
            throw new NotImplementedException();
        }

        public void SetG2Criterion(double TolCurv)
        {
            throw new NotImplementedException();
        }

        public void SetG3Criterion(double TolG3)
        {
            throw new NotImplementedException();
        }

        public bool UVFreeSliding()
        {
            throw new NotImplementedException();
        }

        public bool IncrementalLoadAllowed()
        {
            throw new NotImplementedException();
        }

        public int ActiveOrder()
        {
            throw new NotImplementedException();
        }

        public gp_XY UV()
        {
            throw new NotImplementedException();
        }

        public int Orientation()
        {
            throw new NotImplementedException();
        }

        public bool IsG0()
        {
            throw new NotImplementedException();
        }

        public gp_XYZ G0Target()
        {
            throw new NotImplementedException();
        }

        public Plate_D1 G1Target()
        {
            throw new NotImplementedException();
        }

        public Plate_D2 G2Target()
        {
            throw new NotImplementedException();
        }

        public Plate_D3 G3Target()
        {
            throw new NotImplementedException();
        }

        public double G0Criterion()
        {
            throw new NotImplementedException();
        }

        public double G1Criterion()
        {
            throw new NotImplementedException();
        }

        public double G2Criterion()
        {
            throw new NotImplementedException();
        }

        public double G3Criterion()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class NLPlate_HGPPConstraint
}