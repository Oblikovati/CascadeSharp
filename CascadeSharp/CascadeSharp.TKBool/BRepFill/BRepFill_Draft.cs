//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKG3d.Geom;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKBool.BRepFill
{
	//---------------------------------------------------------------------
	//  Class  BRepFill_Draft
	//---------------------------------------------------------------------
	public  sealed class BRepFill_Draft
	{

		public BRepFill_Draft(TopoDS_Shape Shape, gp_Dir Dir, double Angle)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Draft(BRepFill_Draft parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFill_Draft()
		{
			throw new NotImplementedException();
		}

		public void SetOptions(BRepFill_TransitionStyle Style, double AngleMin, double AngleMax)
		{
			throw new NotImplementedException();
		}

		public void SetOptions(BRepFill_TransitionStyle Style, double AngleMin)
		{
			throw new NotImplementedException();
		}

		public void SetOptions(BRepFill_TransitionStyle Style)
		{
			throw new NotImplementedException();
		}

		public void SetOptions()
		{
			throw new NotImplementedException();
		}

		public void SetDraft(bool IsInternal)
		{
			throw new NotImplementedException();
		}

		public void SetDraft()
		{
			throw new NotImplementedException();
		}

		public void Perform(double LengthMax)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface Surface, bool KeepInsideSurface)
		{
			throw new NotImplementedException();
		}

		public void Perform(Geom_Surface Surface)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape StopShape, bool KeepOutSide)
		{
			throw new NotImplementedException();
		}

		public void Perform(TopoDS_Shape StopShape)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shell Shell()
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Generated(TopoDS_Shape S)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Surface Surf, double Length, Bnd_Box Box)
		{
			throw new NotImplementedException();
		}

		public void BuildShell(Geom_Surface Surf, bool KeepOutSide)
		{
			throw new NotImplementedException();
		}

		public void BuildShell(Geom_Surface Surf)
		{
			throw new NotImplementedException();
		}

		public bool Fuse(TopoDS_Shape S, bool KeepOutSide)
		{
			throw new NotImplementedException();
		}

		public bool Sewing()
		{
			throw new NotImplementedException();
		}


	}; // class BRepFill_Draft

}
