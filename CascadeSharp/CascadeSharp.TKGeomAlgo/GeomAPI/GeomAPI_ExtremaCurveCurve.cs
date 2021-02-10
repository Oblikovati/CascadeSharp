//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.GeomAPI
{
    //---------------------------------------------------------------------
    //  Class  GeomAPI_ExtremaCurveCurve
    //---------------------------------------------------------------------
    public sealed class GeomAPI_ExtremaCurveCurve
    {
        public GeomAPI_ExtremaCurveCurve()
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomAPI_ExtremaCurveCurve(Geom_Curve C1, Geom_Curve C2)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomAPI_ExtremaCurveCurve(Geom_Curve C1, Geom_Curve C2, double U1min, double U1max, double U2min,
            double U2max)
            : base()
        {
            throw new NotImplementedException();
        }

        public GeomAPI_ExtremaCurveCurve(GeomAPI_ExtremaCurveCurve parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Init(Geom_Curve C1, Geom_Curve C2)
        {
            throw new NotImplementedException();
        }

        public void Init(Geom_Curve C1, Geom_Curve C2, double U1min, double U1max, double U2min, double U2max)
        {
            throw new NotImplementedException();
        }

        public int NbExtrema()
        {
            throw new NotImplementedException();
        }

        public void Points(int Index, gp_Pnt P1, gp_Pnt P2)
        {
            throw new NotImplementedException();
        }

        public void Parameters(int Index, ref double U1, ref double U2)
        {
            throw new NotImplementedException();
        }

        public double Distance(int Index)
        {
            throw new NotImplementedException();
        }

        public void NearestPoints(gp_Pnt P1, gp_Pnt P2)
        {
            throw new NotImplementedException();
        }

        public void LowerDistanceParameters(ref double U1, ref double U2)
        {
            throw new NotImplementedException();
        }

        public double LowerDistance()
        {
            throw new NotImplementedException();
        }

        public bool TotalNearestPoints(gp_Pnt P1, gp_Pnt P2)
        {
            throw new NotImplementedException();
        }

        public bool TotalLowerDistanceParameters(ref double U1, ref double U2)
        {
            throw new NotImplementedException();
        }

        public double TotalLowerDistance()
        {
            throw new NotImplementedException();
        }

        public void TotalPerform()
        {
            throw new NotImplementedException();
        }
    }; // class GeomAPI_ExtremaCurveCurve
}