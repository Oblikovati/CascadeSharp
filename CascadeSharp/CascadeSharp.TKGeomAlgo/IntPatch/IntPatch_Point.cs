//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKGeomAlgo.IntSurf;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntPatch
{
    //---------------------------------------------------------------------
    //  Class  IntPatch_Point
    //---------------------------------------------------------------------
    public sealed class IntPatch_Point
    {
        public IntPatch_Point()
            : base()
        {
            throw new NotImplementedException();
        }

        public IntPatch_Point(IntPatch_Point parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetValue(gp_Pnt Pt, double Tol, bool Tangent)
        {
            throw new NotImplementedException();
        }

        public void SetValue(gp_Pnt Pt)
        {
            throw new NotImplementedException();
        }

        public void SetValue(IntSurf_PntOn2S thePOn2S)
        {
            throw new NotImplementedException();
        }

        public void SetTolerance(double Tol)
        {
            throw new NotImplementedException();
        }

        public void SetParameters(double U1, double V1, double U2, double V2)
        {
            throw new NotImplementedException();
        }

        public void SetParameter(double Para)
        {
            throw new NotImplementedException();
        }

        public void SetVertex(bool OnFirst, Adaptor3d_HVertex V)
        {
            throw new NotImplementedException();
        }

        public void SetArc(bool OnFirst, Adaptor2d_HCurve2d A, double Param, IntSurf_Transition TLine,
            IntSurf_Transition TArc)
        {
            throw new NotImplementedException();
        }

        public void SetMultiple(bool IsMult)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Value()
        {
            throw new NotImplementedException();
        }

        public double ParameterOnLine()
        {
            throw new NotImplementedException();
        }

        public double Tolerance()
        {
            throw new NotImplementedException();
        }

        public bool IsTangencyPoint()
        {
            throw new NotImplementedException();
        }

        public void ParametersOnS1(ref double U1, ref double V1)
        {
            throw new NotImplementedException();
        }

        public void ParametersOnS2(ref double U2, ref double V2)
        {
            throw new NotImplementedException();
        }

        public bool IsMultiple()
        {
            throw new NotImplementedException();
        }

        public bool IsOnDomS1()
        {
            throw new NotImplementedException();
        }

        public bool IsVertexOnS1()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HVertex VertexOnS1()
        {
            throw new NotImplementedException();
        }

        public Adaptor2d_HCurve2d ArcOnS1()
        {
            throw new NotImplementedException();
        }

        public IntSurf_Transition TransitionLineArc1()
        {
            throw new NotImplementedException();
        }

        public IntSurf_Transition TransitionOnS1()
        {
            throw new NotImplementedException();
        }

        public double ParameterOnArc1()
        {
            throw new NotImplementedException();
        }

        public bool IsOnDomS2()
        {
            throw new NotImplementedException();
        }

        public bool IsVertexOnS2()
        {
            throw new NotImplementedException();
        }

        public Adaptor3d_HVertex VertexOnS2()
        {
            throw new NotImplementedException();
        }

        public Adaptor2d_HCurve2d ArcOnS2()
        {
            throw new NotImplementedException();
        }

        public IntSurf_Transition TransitionLineArc2()
        {
            throw new NotImplementedException();
        }

        public IntSurf_Transition TransitionOnS2()
        {
            throw new NotImplementedException();
        }

        public double ParameterOnArc2()
        {
            throw new NotImplementedException();
        }

        public IntSurf_PntOn2S PntOn2S()
        {
            throw new NotImplementedException();
        }

        public void Parameters(ref double U1, ref double V1, ref double U2, ref double V2)
        {
            throw new NotImplementedException();
        }

        public void ReverseTransition()
        {
            throw new NotImplementedException();
        }

        public void Dump()
        {
            throw new NotImplementedException();
        }
    }; // class IntPatch_Point
}