//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
    //---------------------------------------------------------------------
    //  Class  GeomFill_QuasiAngularConvertor
    //---------------------------------------------------------------------
    public sealed class GeomFill_QuasiAngularConvertor
    {
        public GeomFill_QuasiAngularConvertor()
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_QuasiAngularConvertor(GeomFill_QuasiAngularConvertor parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool Initialized()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public void Section(gp_Pnt FirstPnt, gp_Pnt Center, gp_Vec Dir, double Angle, TColgp_Array1OfPnt Poles,
            TColStd_Array1OfReal Weights)
        {
            throw new NotImplementedException();
        }

        public void Section(gp_Pnt FirstPnt, gp_Vec DFirstPnt, gp_Pnt Center, gp_Vec DCenter, gp_Vec Dir, gp_Vec DDir,
            double Angle, double DAngle, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles,
            TColStd_Array1OfReal Weights, TColStd_Array1OfReal DWeights)
        {
            throw new NotImplementedException();
        }

        public void Section(gp_Pnt FirstPnt, gp_Vec DFirstPnt, gp_Vec D2FirstPnt, gp_Pnt Center, gp_Vec DCenter,
            gp_Vec D2Center, gp_Vec Dir, gp_Vec DDir, gp_Vec D2Dir, double Angle, double DAngle, double D2Angle,
            TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfVec D2Poles,
            TColStd_Array1OfReal Weights, TColStd_Array1OfReal DWeights, TColStd_Array1OfReal D2Weights)
        {
            throw new NotImplementedException();
        }
    }; // class GeomFill_QuasiAngularConvertor
}