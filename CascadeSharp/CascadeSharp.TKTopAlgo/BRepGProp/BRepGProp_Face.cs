//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKMath.GeomAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKTopAlgo.BRepGProp
{
	//---------------------------------------------------------------------
	//  Class  BRepGProp_Face
	//---------------------------------------------------------------------
	public  sealed class BRepGProp_Face
	{

		public BRepGProp_Face(bool IsUseSpan)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepGProp_Face(TopoDS_Face F, bool IsUseSpan)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepGProp_Face(TopoDS_Face F)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepGProp_Face(BRepGProp_Face parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepGProp_Face()
		{
			throw new NotImplementedException();
		}

		public void Load(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public int VIntegrationOrder()
		{
			throw new NotImplementedException();
		}

		public bool NaturalRestriction()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face GetFace()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Value2d(double U)
		{
			throw new NotImplementedException();
		}

		public int SIntOrder(double Eps)
		{
			throw new NotImplementedException();
		}

		public int SVIntSubs()
		{
			throw new NotImplementedException();
		}

		public int SUIntSubs()
		{
			throw new NotImplementedException();
		}

		public void UKnots(TColStd_Array1OfReal Knots)
		{
			throw new NotImplementedException();
		}

		public void VKnots(TColStd_Array1OfReal Knots)
		{
			throw new NotImplementedException();
		}

		public int LIntOrder(double Eps)
		{
			throw new NotImplementedException();
		}

		public int LIntSubs()
		{
			throw new NotImplementedException();
		}

		public void LKnots(TColStd_Array1OfReal Knots)
		{
			throw new NotImplementedException();
		}

		public int UIntegrationOrder()
		{
			throw new NotImplementedException();
		}

		public void Bounds(ref double U1, ref double U2, ref double V1, ref double V2)
		{
			throw new NotImplementedException();
		}

		public void Normal(double U, double V, gp_Pnt P, gp_Vec VNor)
		{
			throw new NotImplementedException();
		}

		public bool Load(TopoDS_Edge E)
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

		public int IntegrationOrder()
		{
			throw new NotImplementedException();
		}

		public void D12d(double U, gp_Pnt2d P, gp_Vec2d V1)
		{
			throw new NotImplementedException();
		}

		public void Load(bool IsFirstParam, GeomAbs_IsoType theIsoType)
		{
			throw new NotImplementedException();
		}

		public void GetUKnots(double theUMin, double theUMax, TColStd_HArray1OfReal theUKnots)
		{
			throw new NotImplementedException();
		}

		public void GetTKnots(double theTMin, double theTMax, TColStd_HArray1OfReal theTKnots)
		{
			throw new NotImplementedException();
		}


	}; // class BRepGProp_Face

}
