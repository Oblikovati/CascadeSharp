//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.Prs3d
{
    //---------------------------------------------------------------------
    //  Class  Prs3d
    //---------------------------------------------------------------------
    public sealed class Prs3d
    {
        public Prs3d()
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d(Prs3d parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool MatchSegment(double X, double Y, double Z, double aD_istance, gp_Pnt p1, gp_Pnt p2,
            ref double d_ist)
        {
            throw new NotImplementedException();
        }

        public double GetDeflection(Bnd_Box theBndBox, double theDeviationCoefficient,
            double theMaximalChordialDeviation)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ArrayOfPrimitives PrimitivesFromPolylines(Prs3d_NListOfSequenceOfPnt thePoints)
        {
            throw new NotImplementedException();
        }

        public void AddPrimitivesGroup(Graphic3d_Structure thePrs, Prs3d_LineAspect theAspect,
            Prs3d_NListOfSequenceOfPnt thePolylines)
        {
            throw new NotImplementedException();
        }
    }; // class Prs3d
}