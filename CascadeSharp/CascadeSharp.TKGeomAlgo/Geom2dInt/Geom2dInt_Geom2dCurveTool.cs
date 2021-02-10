//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG2d.Adaptor2d;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.Geom2dInt
{
    //---------------------------------------------------------------------
    //  Class  Geom2dInt_Geom2dCurveTool
    //---------------------------------------------------------------------
    public sealed class Geom2dInt_Geom2dCurveTool
    {
        public Geom2dInt_Geom2dCurveTool()
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dInt_Geom2dCurveTool(Geom2dInt_Geom2dCurveTool parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomAbs_CurveType GetGeomType(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public bool IsComposite(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Lin2d Line(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Circ2d Circle(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Elips2d Ellipse(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Parab2d Parabola(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Hypr2d Hyperbola(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public double EpsX(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public double EpsX(Adaptor2d_Curve2d C, double Eps_XYZ)
        {
            throw new NotImplementedException();
        }

        public int NbSamples(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public int NbSamples(Adaptor2d_Curve2d C, double U0, double U1)
        {
            throw new NotImplementedException();
        }

        public double FirstParameter(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public double LastParameter(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt2d Value(Adaptor2d_Curve2d C, double X)
        {
            throw new NotImplementedException();
        }

        public void D0(Adaptor2d_Curve2d C, double U, gp_Pnt2d P)
        {
            throw new NotImplementedException();
        }

        public void D1(Adaptor2d_Curve2d C, double U, gp_Pnt2d P, gp_Vec2d T)
        {
            throw new NotImplementedException();
        }

        public void D2(Adaptor2d_Curve2d C, double U, gp_Pnt2d P, gp_Vec2d T, gp_Vec2d N)
        {
            throw new NotImplementedException();
        }

        public void D3(Adaptor2d_Curve2d C, double U, gp_Pnt2d P, gp_Vec2d T, gp_Vec2d N, gp_Vec2d V)
        {
            throw new NotImplementedException();
        }

        public gp_Vec2d DN(Adaptor2d_Curve2d C, double U, int N)
        {
            throw new NotImplementedException();
        }

        public int NbIntervals(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }

        public void Intervals(Adaptor2d_Curve2d C, TColStd_Array1OfReal Tab)
        {
            throw new NotImplementedException();
        }

        public void GetInterval(Adaptor2d_Curve2d C, int Index, TColStd_Array1OfReal Tab, ref double U1, ref double U2)
        {
            throw new NotImplementedException();
        }

        public int Degree(Adaptor2d_Curve2d C)
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dInt_Geom2dCurveTool
}