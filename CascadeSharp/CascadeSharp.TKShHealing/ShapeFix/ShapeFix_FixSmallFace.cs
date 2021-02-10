//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;

namespace CascadeSharp.TKShHealing.ShapeFix
{
	//---------------------------------------------------------------------
	//  Class  ShapeFix_FixSmallFace
	//---------------------------------------------------------------------
	public  sealed class ShapeFix_FixSmallFace : ShapeFix_Root
	{

		public ShapeFix_FixSmallFace()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_FixSmallFace(ShapeFix_FixSmallFace parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape FixSpotFace()
		{
			throw new NotImplementedException();
		}

		public bool ReplaceVerticesInCaseOfSpot(TopoDS_Face F, double tol)
		{
			throw new NotImplementedException();
		}

		public bool RemoveFacesInCaseOfSpot(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape FixStripFace(bool wasdone)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape FixStripFace()
		{
			throw new NotImplementedException();
		}

		public bool ReplaceInCaseOfStrip(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2, double tol)
		{
			throw new NotImplementedException();
		}

		public bool RemoveFacesInCaseOfStrip(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Edge ComputeSharedEdgeForStripFace(TopoDS_Face F, TopoDS_Edge E1, TopoDS_Edge E2, TopoDS_Face F1, double tol)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape FixSplitFace(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public bool SplitOneFace(TopoDS_Face F, TopoDS_Compound theSplittedFaces)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face FixFace(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape FixShape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public bool FixPinFace(TopoDS_Face F)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeFix_FixSmallFace

}
