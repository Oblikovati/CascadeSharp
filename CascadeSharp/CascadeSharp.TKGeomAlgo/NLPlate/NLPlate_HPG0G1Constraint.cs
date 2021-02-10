//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKGeomAlgo.Plate;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.NLPlate
{
    //---------------------------------------------------------------------
    //  Class  NLPlate_HPG0G1Constraint
    //---------------------------------------------------------------------
    public class NLPlate_HPG0G1Constraint : NLPlate_HPG0Constraint
    {
        public NLPlate_HPG0G1Constraint(gp_XY UV, gp_XYZ Value, Plate_D1 D1T)
            : base()
        {
            throw new NotImplementedException();
        }

        public NLPlate_HPG0G1Constraint(NLPlate_HPG0G1Constraint parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public NLPlate_HPG0G1Constraint()
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

        public int ActiveOrder()
        {
            throw new NotImplementedException();
        }

        public int Orientation()
        {
            throw new NotImplementedException();
        }

        public Plate_D1 G1Target()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class NLPlate_HPG0G1Constraint
}