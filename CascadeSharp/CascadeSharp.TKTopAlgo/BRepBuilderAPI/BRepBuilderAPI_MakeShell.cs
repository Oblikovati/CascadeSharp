//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKG3d.Geom;

namespace CascadeSharp.TKTopAlgo.BRepBuilderAPI
{
	//---------------------------------------------------------------------
	//  Class  BRepBuilderAPI_MakeShell
	//---------------------------------------------------------------------
	public  sealed class BRepBuilderAPI_MakeShell : BRepBuilderAPI_MakeShape
	{

		public BRepBuilderAPI_MakeShell()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_MakeShell(Geom_Surface S, bool Segment)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_MakeShell(Geom_Surface S)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_MakeShell(Geom_Surface S, double UMin, double UMax, double VMin, double VMax, bool Segment)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_MakeShell(Geom_Surface S, double UMin, double UMax, double VMin, double VMax)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_MakeShell(BRepBuilderAPI_MakeShell parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Surface S, double UMin, double UMax, double VMin, double VMax, bool Segment)
		{
			throw new NotImplementedException();
		}

		public void Init(Geom_Surface S, double UMin, double UMax, double VMin, double VMax)
		{
			throw new NotImplementedException();
		}

		public bool IsDone()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_ShellError Error()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shell Shell()
		{
			throw new NotImplementedException();
		}


	}; // class BRepBuilderAPI_MakeShell

}
