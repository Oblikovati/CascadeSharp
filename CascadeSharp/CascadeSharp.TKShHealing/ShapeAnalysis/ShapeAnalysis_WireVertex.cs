//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeAnalysis
{
	//---------------------------------------------------------------------
	//  Class  ShapeAnalysis_WireVertex
	//---------------------------------------------------------------------
	public  sealed class ShapeAnalysis_WireVertex
	{

		public ShapeAnalysis_WireVertex()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeAnalysis_WireVertex(ShapeAnalysis_WireVertex parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Wire wire, double preci)
		{
			throw new NotImplementedException();
		}

		public void Init(ShapeExtend_WireData swbd, double preci)
		{
			throw new NotImplementedException();
		}

		public void Load(TopoDS_Wire wire)
		{
			throw new NotImplementedException();
		}

		public void Load(ShapeExtend_WireData sbwd)
		{
			throw new NotImplementedException();
		}

		public void SetPrecision(double preci)
		{
			throw new NotImplementedException();
		}

		public void Analyze()
		{
			throw new NotImplementedException();
		}

		public void SetSameVertex(int num)
		{
			throw new NotImplementedException();
		}

		public void SetSameCoords(int num)
		{
			throw new NotImplementedException();
		}

		public void SetClose(int num)
		{
			throw new NotImplementedException();
		}

		public void SetEnd(int num, gp_XYZ pos, double ufol)
		{
			throw new NotImplementedException();
		}

		public void SetStart(int num, gp_XYZ pos, double upre)
		{
			throw new NotImplementedException();
		}

		public void SetInters(int num, gp_XYZ pos, double upre, double ufol)
		{
			throw new NotImplementedException();
		}

		public void SetDisjoined(int num)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public double Precision()
		{
			throw new NotImplementedException();
		}

		public int NbEdges()
		{
			throw new NotImplementedException();
		}

		public ShapeExtend_WireData WireData()
		{
			throw new NotImplementedException();
		}

		public int Status(int num)
		{
			throw new NotImplementedException();
		}

		public gp_XYZ Position(int num)
		{
			throw new NotImplementedException();
		}

		public double UPrevious(int num)
		{
			throw new NotImplementedException();
		}

		public double UFollowing(int num)
		{
			throw new NotImplementedException();
		}

		public int Data(int num, gp_XYZ pos, ref double upre, ref double ufol)
		{
			throw new NotImplementedException();
		}

		public int NextStatus(int stat, int num)
		{
			throw new NotImplementedException();
		}

		public int NextStatus(int stat)
		{
			throw new NotImplementedException();
		}

		public int NextCriter(int crit, int num)
		{
			throw new NotImplementedException();
		}

		public int NextCriter(int crit)
		{
			throw new NotImplementedException();
		}


	}; // class ShapeAnalysis_WireVertex

}
