//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
    //---------------------------------------------------------------------
    //  Class  IntPatch_TheIWalking
    //---------------------------------------------------------------------
    public sealed class IntPatch_TheIWalking
    {
        public IntPatch_TheIWalking(double Epsilon, double Deflection, double Step, bool theToFillHoles)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_TheIWalking(double Epsilon, double Deflection, double Step)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_TheIWalking(IntPatch_TheIWalking parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_TheIWalking()
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Epsilon, double Deflection, double Step)
        {
            throw new NotImplementedException();
        }

        public void Perform(IntSurf_SequenceOfPathPoint Pnts1, IntSurf_SequenceOfInteriorPoint Pnts2,
            IntPatch_TheSurfFunction Func, Adaptor3d_HSurface S, bool Reversed)
        {
            throw new NotImplementedException();
        }

        public void Perform(IntSurf_SequenceOfPathPoint Pnts1, IntSurf_SequenceOfInteriorPoint Pnts2,
            IntPatch_TheSurfFunction Func, Adaptor3d_HSurface S)
        {
            throw new NotImplementedException();
        }

        public void Perform(IntSurf_SequenceOfPathPoint Pnts1, IntPatch_TheSurfFunction Func, Adaptor3d_HSurface S,
            bool Reversed)
        {
            throw new NotImplementedException();
        }

        public void Perform(IntSurf_SequenceOfPathPoint Pnts1, IntPatch_TheSurfFunction Func, Adaptor3d_HSurface S)
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public int NbLines()
        {
            throw new NotImplementedException();
        }

        public IntPatch_TheIWLineOfTheIWalking Value(int Index)
        {
            throw new NotImplementedException();
        }

        public int NbSinglePnts()
        {
            throw new NotImplementedException();
        }

        public IntSurf_PathPoint SinglePnt(int Index)
        {
            throw new NotImplementedException();
        }

        public bool Cadrage(Vector BornInf, Vector BornSup, Vector UVap, ref double Step, int StepSign)
        {
            throw new NotImplementedException();
        }

        public bool TestArretPassage(TColStd_SequenceOfReal Umult, TColStd_SequenceOfReal Vmult,
            IntPatch_TheSurfFunction Section, Vector UV, ref int Irang)
        {
            throw new NotImplementedException();
        }

        public bool TestArretPassage(TColStd_SequenceOfReal Umult, TColStd_SequenceOfReal Vmult, Vector UV,
            int Index, ref int Irang)
        {
            throw new NotImplementedException();
        }

        public bool TestArretAjout(IntPatch_TheSurfFunction Section, Vector UV, ref int Irang,
            IntSurf_PntOn2S PSol)
        {
            throw new NotImplementedException();
        }

        public void FillPntsInHoles(IntPatch_TheSurfFunction Section, TColStd_SequenceOfInteger CopySeqAlone,
            IntSurf_SequenceOfInteriorPoint PntsInHoles)
        {
            throw new NotImplementedException();
        }

        public void TestArretCadre(TColStd_SequenceOfReal Umult, TColStd_SequenceOfReal Vmult,
            IntPatch_TheIWLineOfTheIWalking Line, IntPatch_TheSurfFunction Section, Vector UV, ref int Irang)
        {
            throw new NotImplementedException();
        }

        public void ComputeOpenLine(TColStd_SequenceOfReal Umult, TColStd_SequenceOfReal Vmult,
            IntSurf_SequenceOfPathPoint Pnts1, IntPatch_TheSurfFunction Section, ref bool Rajout)
        {
            throw new NotImplementedException();
        }

        public void OpenLine(int N, IntSurf_PntOn2S Psol, IntSurf_SequenceOfPathPoint Pnts1,
            IntPatch_TheSurfFunction Section, IntPatch_TheIWLineOfTheIWalking Line)
        {
            throw new NotImplementedException();
        }

        public bool IsValidEndPoint(int IndOfPoint, int IndOfLine)
        {
            throw new NotImplementedException();
        }

        public void RemoveTwoEndPoints(int IndOfPoint)
        {
            throw new NotImplementedException();
        }

        public bool IsPointOnLine(gp_Pnt2d theP2d, int Irang)
        {
            throw new NotImplementedException();
        }

        public void ComputeCloseLine(TColStd_SequenceOfReal Umult, TColStd_SequenceOfReal Vmult,
            IntSurf_SequenceOfPathPoint Pnts1, IntSurf_SequenceOfInteriorPoint Pnts2, IntPatch_TheSurfFunction Section,
            ref bool Rajout)
        {
            throw new NotImplementedException();
        }

        public void AddPointInCurrentLine(int N, IntSurf_PathPoint PathPnt, IntPatch_TheIWLineOfTheIWalking CurrentLine)
        {
            throw new NotImplementedException();
        }

        public void MakeWalkingPoint(int Case, double U, double V, IntPatch_TheSurfFunction Section,
            IntSurf_PntOn2S Psol)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool IsPointOnLine(IntSurf_PntOn2S thePOn2S, Vector theInfBounds, Vector theSupBounds,
            math_FunctionSetRoot theSolver, IntPatch_TheSurfFunction theFunc)
        {
            throw new NotImplementedException();
        }
    }; // class IntPatch_TheIWalking
}