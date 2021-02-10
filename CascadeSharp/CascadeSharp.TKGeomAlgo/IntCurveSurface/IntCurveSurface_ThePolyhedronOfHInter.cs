//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.Adaptor3d;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.IntCurveSurface
{
    //---------------------------------------------------------------------
    //  Class  IntCurveSurface_ThePolyhedronOfHInter
    //---------------------------------------------------------------------
    public sealed class IntCurveSurface_ThePolyhedronOfHInter
    {
        public IntCurveSurface_ThePolyhedronOfHInter(Adaptor3d_HSurface Surface, int nbdU, int nbdV, double U1,
            double V1, double U2, double V2)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_ThePolyhedronOfHInter(Adaptor3d_HSurface Surface, TColStd_Array1OfReal Upars,
            TColStd_Array1OfReal Vpars)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_ThePolyhedronOfHInter(IntCurveSurface_ThePolyhedronOfHInter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public IntCurveSurface_ThePolyhedronOfHInter()
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void DeflectionOverEstimation(double flec)
        {
            throw new NotImplementedException();
        }

        public double DeflectionOnTriangle(Adaptor3d_HSurface Surface, int Index)
        {
            throw new NotImplementedException();
        }

        public void UMinSingularity(bool Sing)
        {
            throw new NotImplementedException();
        }

        public void UMaxSingularity(bool Sing)
        {
            throw new NotImplementedException();
        }

        public void VMinSingularity(bool Sing)
        {
            throw new NotImplementedException();
        }

        public void VMaxSingularity(bool Sing)
        {
            throw new NotImplementedException();
        }

        public void Size(ref int nbdu, ref int nbdv)
        {
            throw new NotImplementedException();
        }

        public int NbTriangles()
        {
            throw new NotImplementedException();
        }

        public void Triangle(int Index, ref int P1, ref int P2, ref int P3)
        {
            throw new NotImplementedException();
        }

        public int TriConnex(int Triang, int Pivot, int Pedge, ref int TriCon, ref int OtherP)
        {
            throw new NotImplementedException();
        }

        public int NbPoints()
        {
            throw new NotImplementedException();
        }

        public void Point(gp_Pnt thePnt, int lig, int col, double U, double V)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point(int Index, ref double U, ref double V)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Point(int Index)
        {
            throw new NotImplementedException();
        }

        public void Point(int Index, gp_Pnt P)
        {
            throw new NotImplementedException();
        }

        public Bnd_Box Bounding()
        {
            throw new NotImplementedException();
        }

        public void FillBounding()
        {
            throw new NotImplementedException();
        }

        public Bnd_HArray1OfBox ComponentsBounding()
        {
            throw new NotImplementedException();
        }

        public double DeflectionOverEstimation()
        {
            throw new NotImplementedException();
        }

        public bool HasUMinSingularity()
        {
            throw new NotImplementedException();
        }

        public bool HasUMaxSingularity()
        {
            throw new NotImplementedException();
        }

        public bool HasVMinSingularity()
        {
            throw new NotImplementedException();
        }

        public bool HasVMaxSingularity()
        {
            throw new NotImplementedException();
        }

        public void PlaneEquation(int Triang, gp_XYZ NormalVector, ref double PolarD_istance)
        {
            throw new NotImplementedException();
        }

        public bool Contain(int Triang, gp_Pnt ThePnt)
        {
            throw new NotImplementedException();
        }

        public void Parameters(int Index, ref double U, ref double V)
        {
            throw new NotImplementedException();
        }

        public bool IsOnBound(int Index1, int Index2)
        {
            throw new NotImplementedException();
        }

        public double GetBorderDeflection()
        {
            throw new NotImplementedException();
        }

        public void Dump()
        {
            throw new NotImplementedException();
        }

        public void Init(Adaptor3d_HSurface Surface, double U1, double V1, double U2, double V2)
        {
            throw new NotImplementedException();
        }

        public void Init(Adaptor3d_HSurface Surface, TColStd_Array1OfReal Upars, TColStd_Array1OfReal Vpars)
        {
            throw new NotImplementedException();
        }

        public double ComputeBorderDeflection(Adaptor3d_HSurface Surface, double Parameter, double PMin, double PMax,
            bool _isUIso)
        {
            throw new NotImplementedException();
        }
    }; // class IntCurveSurface_ThePolyhedronOfHInter
}