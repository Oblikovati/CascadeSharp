//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKGeomAlgo.GeomFill
{
    //---------------------------------------------------------------------
    //  Class  GeomFill_PolynomialConvertor
    //---------------------------------------------------------------------
    public sealed class GeomFill_PolynomialConvertor
    {
        public GeomFill_PolynomialConvertor()
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomFill_PolynomialConvertor(GeomFill_PolynomialConvertor parameter1)
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

        public void Section(gp_Pnt FirstPnt, gp_Pnt Center, gp_Vec Dir, double Angle, TColgp_Array1OfPnt Poles)
        {
            throw new NotImplementedException();
        }

        public void Section(gp_Pnt FirstPnt, gp_Vec DFirstPnt, gp_Pnt Center, gp_Vec DCenter, gp_Vec Dir, gp_Vec DDir,
            double Angle, double DAngle, TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles)
        {
            throw new NotImplementedException();
        }

        public void Section(gp_Pnt FirstPnt, gp_Vec DFirstPnt, gp_Vec D2FirstPnt, gp_Pnt Center, gp_Vec DCenter,
            gp_Vec D2Center, gp_Vec Dir, gp_Vec DDir, gp_Vec D2Dir, double Angle, double DAngle, double D2Angle,
            TColgp_Array1OfPnt Poles, TColgp_Array1OfVec DPoles, TColgp_Array1OfVec D2Poles)
        {
            throw new NotImplementedException();
        }
    }; // class GeomFill_PolynomialConvertor
}