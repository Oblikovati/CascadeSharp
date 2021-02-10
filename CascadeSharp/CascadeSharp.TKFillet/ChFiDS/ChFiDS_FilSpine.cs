//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKGeomAlgo.Law;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKFillet.ChFiDS
{
	//---------------------------------------------------------------------
	//  Class  ChFiDS_FilSpine
	//---------------------------------------------------------------------
	public  sealed class ChFiDS_FilSpine : ChFiDS_Spine
	{

		public ChFiDS_FilSpine()
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_FilSpine(double Tol)
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_FilSpine(ChFiDS_FilSpine parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Reset(bool AllData)
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

		public void SetRadius(double Radius, TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void UnSetRadius(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(double Radius, TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public void UnSetRadius(TopoDS_Vertex V)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(gp_XY UandR, int IinC)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(double Radius)
		{
			throw new NotImplementedException();
		}

		public void SetRadius(Law_Function C, int IinC)
		{
			throw new NotImplementedException();
		}

		public bool IsConstant()
		{
			throw new NotImplementedException();
		}

		public bool IsConstant(int IE)
		{
			throw new NotImplementedException();
		}

		public double Radius()
		{
			throw new NotImplementedException();
		}

		public double Radius(int IE)
		{
			throw new NotImplementedException();
		}

		public double Radius(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public void AppendElSpine(ChFiDS_HElSpine Els)
		{
			throw new NotImplementedException();
		}

		public Law_Composite Law(ChFiDS_HElSpine Els)
		{
			throw new NotImplementedException();
		}

		public Law_Function ChangeLaw(TopoDS_Edge E)
		{
			throw new NotImplementedException();
		}

		public double MaxRadFromSeqAndLaws()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Law_Composite ComputeLaw(ChFiDS_HElSpine Els)
		{
			throw new NotImplementedException();
		}

		public void AppendLaw(ChFiDS_HElSpine Els)
		{
			throw new NotImplementedException();
		}


	}; // class ChFiDS_FilSpine

}
