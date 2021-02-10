//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.Plate
{
    //---------------------------------------------------------------------
    //  Class  Plate_LinearScalarConstraint
    //---------------------------------------------------------------------
    public sealed class Plate_LinearScalarConstraint
    {
        public Plate_LinearScalarConstraint()
            : base()
        {
            throw new NotImplementedException();
        }

        public Plate_LinearScalarConstraint(Plate_PinpointConstraint thePPC1, gp_XYZ theCoeff)
            : base()
        {
            throw new NotImplementedException();
        }

        public Plate_LinearScalarConstraint(Plate_Array1OfPinpointConstraint thePPC, TColgp_Array1OfXYZ theCoeff)
            : base()
        {
            throw new NotImplementedException();
        }

        public Plate_LinearScalarConstraint(Plate_Array1OfPinpointConstraint thePPC, TColgp_Array2OfXYZ theCoeff)
            : base()
        {
            throw new NotImplementedException();
        }

        public Plate_LinearScalarConstraint(int ColLen, int RowLen)
            : base()
        {
            throw new NotImplementedException();
        }

        public Plate_LinearScalarConstraint(Plate_LinearScalarConstraint parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Plate_Array1OfPinpointConstraint GetPPC()
        {
            throw new NotImplementedException();
        }

        public TColgp_Array2OfXYZ Coeff()
        {
            throw new NotImplementedException();
        }

        public void SetPPC(int Index, Plate_PinpointConstraint Value)
        {
            throw new NotImplementedException();
        }

        public void SetCoeff(int Row, int Col, gp_XYZ Value)
        {
            throw new NotImplementedException();
        }
    }; // class Plate_LinearScalarConstraint
}