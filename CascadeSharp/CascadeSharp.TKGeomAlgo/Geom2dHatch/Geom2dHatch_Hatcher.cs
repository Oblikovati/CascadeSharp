//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG2d.Geom2d;
using CascadeSharp.TKG2d.Geom2dAdaptor;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKGeomAlgo.HatchGen;

namespace CascadeSharp.TKGeomAlgo.Geom2dHatch
{
	//---------------------------------------------------------------------
	//  Class  Geom2dHatch_Hatcher
	//---------------------------------------------------------------------
	public  sealed class Geom2dHatch_Hatcher
	{

		public Geom2dHatch_Hatcher(Geom2dHatch_Intersector Intersector, double Confusion2d, double Confusion3d, bool KeepPnt, bool KeepSeg)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dHatch_Hatcher(Geom2dHatch_Intersector Intersector, double Confusion2d, double Confusion3d, bool KeepPnt)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dHatch_Hatcher(Geom2dHatch_Intersector Intersector, double Confusion2d, double Confusion3d)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dHatch_Hatcher(Geom2dHatch_Hatcher parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Geom2dHatch_Hatcher()
		{
			throw new NotImplementedException();
		}

		public void Intersector(Geom2dHatch_Intersector Intersector)
		{
			throw new NotImplementedException();
		}

		public Geom2dHatch_Intersector Intersector()
		{
			throw new NotImplementedException();
		}

		public Geom2dHatch_Intersector ChangeIntersector()
		{
			throw new NotImplementedException();
		}

		public void Confusion2d(double Confusion)
		{
			throw new NotImplementedException();
		}

		public double Confusion2d()
		{
			throw new NotImplementedException();
		}

		public void Confusion3d(double Confusion)
		{
			throw new NotImplementedException();
		}

		public double Confusion3d()
		{
			throw new NotImplementedException();
		}

		public void KeepPoints(bool Keep)
		{
			throw new NotImplementedException();
		}

		public bool KeepPoints()
		{
			throw new NotImplementedException();
		}

		public void KeepSegments(bool Keep)
		{
			throw new NotImplementedException();
		}

		public bool KeepSegments()
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public Geom2dAdaptor_Curve ElementCurve(int IndE)
		{
			throw new NotImplementedException();
		}

		public int AddElement(Geom2dAdaptor_Curve Curve, TopAbs_Orientation Orientation)
		{
			throw new NotImplementedException();
		}

		public int AddElement(Geom2dAdaptor_Curve Curve)
		{
			throw new NotImplementedException();
		}

		public int AddElement(Geom2d_Curve Curve, TopAbs_Orientation Orientation)
		{
			throw new NotImplementedException();
		}

		public int AddElement(Geom2d_Curve Curve)
		{
			throw new NotImplementedException();
		}

		public void RemElement(int IndE)
		{
			throw new NotImplementedException();
		}

		public void ClrElements()
		{
			throw new NotImplementedException();
		}

		public Geom2dAdaptor_Curve HatchingCurve(int IndH)
		{
			throw new NotImplementedException();
		}

		public int AddHatching(Geom2dAdaptor_Curve Curve)
		{
			throw new NotImplementedException();
		}

		public void RemHatching(int IndH)
		{
			throw new NotImplementedException();
		}

		public void ClrHatchings()
		{
			throw new NotImplementedException();
		}

		public int NbPoints(int IndH)
		{
			throw new NotImplementedException();
		}

		public HatchGen_PointOnHatching Point(int IndH, int IndP)
		{
			throw new NotImplementedException();
		}

		public void Trim()
		{
			throw new NotImplementedException();
		}

		public int Trim(Geom2dAdaptor_Curve Curve)
		{
			throw new NotImplementedException();
		}

		public void Trim(int IndH)
		{
			throw new NotImplementedException();
		}

		public void ComputeDomains()
		{
			throw new NotImplementedException();
		}

		public void ComputeDomains(int IndH)
		{
			throw new NotImplementedException();
		}

		public bool TrimDone(int IndH)
		{
			throw new NotImplementedException();
		}

		public bool TrimFailed(int IndH)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public bool IsDone(int IndH)
		{
			throw new NotImplementedException();
		}

		public HatchGen_ErrorStatus Status(int IndH)
		{
			throw new NotImplementedException();
		}

		public int NbDomains(int IndH)
		{
			throw new NotImplementedException();
		}

		public HatchGen_Domain Domain(int IndH, int IDom)
		{
			throw new NotImplementedException();
		}

		public void Dump()
		{
			throw new NotImplementedException();
		}

		public Geom2dHatch_Element Element(int IndE)
		{
			throw new NotImplementedException();
		}

		public Geom2dHatch_Hatching Hatching(int IndH)
		{
			throw new NotImplementedException();
		}

		public bool Trim(int IndH, int IndE)
		{
			throw new NotImplementedException();
		}

		public bool GlobalTransition(HatchGen_PointOnHatching Point)
		{
			throw new NotImplementedException();
		}


	}; // class Geom2dHatch_Hatcher

}
