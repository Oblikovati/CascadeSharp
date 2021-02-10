//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKService.Aspect;
using CascadeSharp.TKV3d.Prs3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_Point
	//---------------------------------------------------------------------
	public  class AIS_Point : AIS_InteractiveObject
	{

		public AIS_Point(Geom_Point aComponent)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Point(AIS_Point parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_Point()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public int Signature()
		{
			throw new NotImplementedException();
		}

		public AIS_KindOfInteractive Type()
		{
			throw new NotImplementedException();
		}

		public Geom_Point Component()
		{
			throw new NotImplementedException();
		}

		public void SetComponent(Geom_Point aComponent)
		{
			throw new NotImplementedException();
		}

		public bool AcceptDisplayMode(int aMode)
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void UnsetColor()
		{
			throw new NotImplementedException();
		}

		public void SetMarker(Aspect_TypeOfMarker aType)
		{
			throw new NotImplementedException();
		}

		public void UnsetMarker()
		{
			throw new NotImplementedException();
		}

		public bool HasMarker()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Vertex Vertex()
		{
			throw new NotImplementedException();
		}

						public void ComputeSelection(SelectMgr_Selection aSelection, int aMode)
		{
			throw new NotImplementedException();
		}

		public void UpdatePointValues()
		{
			throw new NotImplementedException();
		}

		public void replaceWithNewPointAspect(Prs3d_PointAspect theAspect)
		{
			throw new NotImplementedException();
		}


	}; // class AIS_Point

}
