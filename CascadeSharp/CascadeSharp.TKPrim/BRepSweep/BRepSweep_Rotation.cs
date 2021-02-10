//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepSweep_Rotation
	//---------------------------------------------------------------------
	public  sealed class BRepSweep_Rotation : CascadeSharp.BRepSweep_Trsf
	{

		public BRepSweep_Rotation(TopoDS_Shape S, Sweep_NumShape N, TopLoc_Location L, gp_Ax1 A, double D, bool C)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepSweep_Rotation(BRepSweep_Rotation parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepSweep_Rotation()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape MakeEmptyVertex(TopoDS_Shape aGenV, Sweep_NumShape aDirV)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape MakeEmptyDirectingEdge(TopoDS_Shape aGenV, Sweep_NumShape aDirE)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape MakeEmptyGeneratingEdge(TopoDS_Shape aGenE, Sweep_NumShape aDirV)
		{
			throw new NotImplementedException();
		}

		public void SetParameters(TopoDS_Shape aNewFace, TopoDS_Shape aNewVertex, TopoDS_Shape aGenF, TopoDS_Shape aGenV, Sweep_NumShape aDirV)
		{
			throw new NotImplementedException();
		}

		public void SetDirectingParameter(TopoDS_Shape aNewEdge, TopoDS_Shape aNewVertex, TopoDS_Shape aGenV, Sweep_NumShape aDirE, Sweep_NumShape aDirV)
		{
			throw new NotImplementedException();
		}

		public void SetGeneratingParameter(TopoDS_Shape aNewEdge, TopoDS_Shape aNewVertex, TopoDS_Shape aGenE, TopoDS_Shape aGenV, Sweep_NumShape aDirV)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape MakeEmptyFace(TopoDS_Shape aGenS, Sweep_NumShape aDirS)
		{
			throw new NotImplementedException();
		}

		public void SetPCurve(TopoDS_Shape aNewFace, TopoDS_Shape aNewEdge, TopoDS_Shape aGenF, TopoDS_Shape aGenE, Sweep_NumShape aDirV, CascadeSharp.TopAbs_Orientation orien)
		{
			throw new NotImplementedException();
		}

		public void SetGeneratingPCurve(TopoDS_Shape aNewFace, TopoDS_Shape aNewEdge, TopoDS_Shape aGenE, Sweep_NumShape aDirE, Sweep_NumShape aDirV, CascadeSharp.TopAbs_Orientation orien)
		{
			throw new NotImplementedException();
		}

		public void SetDirectingPCurve(TopoDS_Shape aNewFace, TopoDS_Shape aNewEdge, TopoDS_Shape aGenE, TopoDS_Shape aGenV, Sweep_NumShape aDirE, CascadeSharp.TopAbs_Orientation orien)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.TopAbs_Orientation DirectSolid(TopoDS_Shape aGenS, Sweep_NumShape aDirS)
		{
			throw new NotImplementedException();
		}

		public bool GGDShapeIsToAdd(TopoDS_Shape aNewShape, TopoDS_Shape aNewSubShape, TopoDS_Shape aGenS, TopoDS_Shape aSubGenS, Sweep_NumShape aDirS)
		{
			throw new NotImplementedException();
		}

		public bool GDDShapeIsToAdd(TopoDS_Shape aNewShape, TopoDS_Shape aNewSubShape, TopoDS_Shape aGenS, Sweep_NumShape aDirS, Sweep_NumShape aSubDirS)
		{
			throw new NotImplementedException();
		}

		public bool SeparatedWires(TopoDS_Shape aNewShape, TopoDS_Shape aNewSubShape, TopoDS_Shape aGenS, TopoDS_Shape aSubGenS, Sweep_NumShape aDirS)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape SplitShell(TopoDS_Shape aNewShape)
		{
			throw new NotImplementedException();
		}

		public bool HasShape(TopoDS_Shape aGenS, Sweep_NumShape aDirS)
		{
			throw new NotImplementedException();
		}

		public bool IsInvariant(TopoDS_Shape aGenS)
		{
			throw new NotImplementedException();
		}

		public gp_Ax1 Axe()
		{
			throw new NotImplementedException();
		}

		public double Angle()
		{
			throw new NotImplementedException();
		}


	}; // class BRepSweep_Rotation

}
