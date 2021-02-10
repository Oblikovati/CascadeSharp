//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.TopLoc;
using CascadeSharp.TKShHealing.ShapeAnalysis;
using CascadeSharp.TKShHealing.ShapeBuild;
using CascadeSharp.TKShHealing.ShapeConstruct;
using CascadeSharp.TKShHealing.ShapeExtend;

namespace CascadeSharp.TKShHealing.ShapeFix
{
	//---------------------------------------------------------------------
	//  Class  ShapeFix_Edge
	//---------------------------------------------------------------------
	public  sealed class ShapeFix_Edge : Standard_Transient
	{

		public ShapeFix_Edge()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Edge(ShapeFix_Edge parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeConstruct_ProjectCurveOnSurface Projector()
		{
			throw new NotImplementedException();
		}

		public bool FixRemovePCurve(TopoDS_Edge edge, TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public bool FixRemovePCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location)
		{
			throw new NotImplementedException();
		}

		public bool FixRemoveCurve3d(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public bool FixAddPCurve(TopoDS_Edge edge, TopoDS_Face face, bool _isSeam, double prec)
		{
			throw new NotImplementedException();
		}

		public bool FixAddPCurve(TopoDS_Edge edge, TopoDS_Face face, bool _isSeam)
		{
			throw new NotImplementedException();
		}

		public bool FixAddPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, bool _isSeam, double prec)
		{
			throw new NotImplementedException();
		}

		public bool FixAddPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, bool _isSeam)
		{
			throw new NotImplementedException();
		}

		public bool FixAddPCurve(TopoDS_Edge edge, TopoDS_Face face, bool _isSeam, ShapeAnalysis_Surface surfana, double prec)
		{
			throw new NotImplementedException();
		}

		public bool FixAddPCurve(TopoDS_Edge edge, TopoDS_Face face, bool _isSeam, ShapeAnalysis_Surface surfana)
		{
			throw new NotImplementedException();
		}

		public bool FixAddPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, bool _isSeam, ShapeAnalysis_Surface surfana, double prec)
		{
			throw new NotImplementedException();
		}

		public bool FixAddPCurve(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location, bool _isSeam, ShapeAnalysis_Surface surfana)
		{
			throw new NotImplementedException();
		}

		public bool FixAddCurve3d(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public bool FixVertexTolerance(TopoDS_Edge edge, TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public bool FixVertexTolerance(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public bool FixReversed2d(TopoDS_Edge edge, TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public bool FixReversed2d(TopoDS_Edge edge, Geom_Surface surface, TopLoc_Location location)
		{
			throw new NotImplementedException();
		}

		public bool FixSameParameter(TopoDS_Edge edge, double tolerance)
		{
			throw new NotImplementedException();
		}

		public bool FixSameParameter(TopoDS_Edge edge)
		{
			throw new NotImplementedException();
		}

		public bool FixSameParameter(TopoDS_Edge edge, TopoDS_Face face, double tolerance)
		{
			throw new NotImplementedException();
		}

		public bool FixSameParameter(TopoDS_Edge edge, TopoDS_Face face)
		{
			throw new NotImplementedException();
		}

		public bool Status(ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public void SetContext(ShapeBuild_ReShape context)
		{
			throw new NotImplementedException();
		}

		public ShapeBuild_ReShape Context()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeFix_Edge

}
