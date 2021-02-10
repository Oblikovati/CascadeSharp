//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2dAdaptor;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.math;

namespace CascadeSharp.TKGeomAlgo.Geom2dGcc
{
    //---------------------------------------------------------------------
    //  Class  Geom2dGcc_FunctionTanCuCuCu
    //---------------------------------------------------------------------
    public sealed class Geom2dGcc_FunctionTanCuCuCu : math_FunctionSetWithDerivatives
    {
        public Geom2dGcc_FunctionTanCuCuCu(Geom2dAdaptor_Curve C1, Geom2dAdaptor_Curve C2, Geom2dAdaptor_Curve C3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(gp_Circ2d C1, Geom2dAdaptor_Curve C2, Geom2dAdaptor_Curve C3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(gp_Circ2d C1, gp_Circ2d C2, Geom2dAdaptor_Curve C3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(gp_Circ2d C1, gp_Lin2d L2, Geom2dAdaptor_Curve C3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(gp_Lin2d L1, gp_Lin2d L2, Geom2dAdaptor_Curve C3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(gp_Lin2d L1, Geom2dAdaptor_Curve C2, Geom2dAdaptor_Curve C3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(gp_Circ2d C1, Geom2dAdaptor_Curve C2, gp_Pnt2d P3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(gp_Lin2d L1, Geom2dAdaptor_Curve C2, gp_Pnt2d P3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(Geom2dAdaptor_Curve C1, gp_Pnt2d P2, gp_Pnt2d P3)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu(Geom2dGcc_FunctionTanCuCuCu parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Geom2dGcc_FunctionTanCuCuCu()
        {
            throw new NotImplementedException();
        }

        public void InitDerivative(Vector X, gp_Pnt2d Point1, gp_Pnt2d Point2, gp_Pnt2d Point3, gp_Vec2d Tan1,
            gp_Vec2d Tan2, gp_Vec2d Tan3, gp_Vec2d D21, gp_Vec2d D22, gp_Vec2d D23)
        {
            throw new NotImplementedException();
        }

        public int NbVariables()
        {
            throw new NotImplementedException();
        }

        public int NbEquations()
        {
            throw new NotImplementedException();
        }

        public bool Value(Vector X, Vector F)
        {
            throw new NotImplementedException();
        }

        public bool Derivatives(Vector X, math_Matrix D)
        {
            throw new NotImplementedException();
        }

        public bool Values(Vector X, Vector F, math_Matrix D)
        {
            throw new NotImplementedException();
        }
    }; // class Geom2dGcc_FunctionTanCuCuCu
}