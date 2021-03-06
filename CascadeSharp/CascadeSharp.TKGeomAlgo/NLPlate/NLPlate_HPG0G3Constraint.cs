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
    //  Class  NLPlate_HPG0G3Constraint
    //---------------------------------------------------------------------
    public sealed class NLPlate_HPG0G3Constraint : NLPlate_HPG0G2Constraint
    {
        public NLPlate_HPG0G3Constraint(gp_XY UV, gp_XYZ Value, Plate_D1 D1T, Plate_D2 D2T, Plate_D3 D3T)
            : base()
        {
            throw new NotImplementedException();
        }

        public NLPlate_HPG0G3Constraint(NLPlate_HPG0G3Constraint parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public NLPlate_HPG0G3Constraint()
        {
            throw new NotImplementedException();
        }

        public int ActiveOrder()
        {
            throw new NotImplementedException();
        }

        public Plate_D3 G3Target()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class NLPlate_HPG0G3Constraint
}