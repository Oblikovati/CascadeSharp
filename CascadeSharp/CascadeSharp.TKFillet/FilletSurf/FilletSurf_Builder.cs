//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG3d.Geom;

namespace CascadeSharp.TKFillet.FilletSurf
{
    //---------------------------------------------------------------------
    //  Class  FilletSurf_Builder
    //---------------------------------------------------------------------
    public sealed class FilletSurf_Builder
    {
        public FilletSurf_Builder(TopoDS_Shape S, TopTools_ListOfShape E, double R, double Ta, double Tapp3d,
            double Tapp2d)
            : base()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_Builder(TopoDS_Shape S, TopTools_ListOfShape E, double R, double Ta, double Tapp3d)
            : base()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_Builder(TopoDS_Shape S, TopTools_ListOfShape E, double R, double Ta)
            : base()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_Builder(TopoDS_Shape S, TopTools_ListOfShape E, double R)
            : base()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_Builder(FilletSurf_Builder parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_Builder()
        {
            throw new NotImplementedException();
        }

        public void Perform()
        {
            throw new NotImplementedException();
        }

        public void Simulate()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_StatusDone IsDone()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_ErrorTypeStatus StatusError()
        {
            throw new NotImplementedException();
        }

        public int NbSurface()
        {
            throw new NotImplementedException();
        }

        public Geom_Surface SurfaceFillet(int Index)
        {
            throw new NotImplementedException();
        }

        public double TolApp3d(int Index)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face SupportFace1(int Index)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Face SupportFace2(int Index)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve CurveOnFace1(int Index)
        {
            throw new NotImplementedException();
        }

        public Geom_Curve CurveOnFace2(int Index)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve PCurveOnFace1(int Index)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve PCurve1OnFillet(int Index)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve PCurveOnFace2(int Index)
        {
            throw new NotImplementedException();
        }

        public Geom2d_Curve PCurve2OnFillet(int Index)
        {
            throw new NotImplementedException();
        }

        public double FirstParameter()
        {
            throw new NotImplementedException();
        }

        public double LastParameter()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_StatusType StartSectionStatus()
        {
            throw new NotImplementedException();
        }

        public FilletSurf_StatusType EndSectionStatus()
        {
            throw new NotImplementedException();
        }

        public int NbSection(int IndexSurf)
        {
            throw new NotImplementedException();
        }

        public void Section(int IndexSurf, int IndexSec, Geom_TrimmedCurve Circ)
        {
            throw new NotImplementedException();
        }
    }; // class FilletSurf_Builder
}