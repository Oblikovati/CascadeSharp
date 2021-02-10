//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BRepBuilderAPI_FastSewing
	//---------------------------------------------------------------------
	public  sealed class BRepBuilderAPI_FastSewing : Standard_Transient
	{

		public BRepBuilderAPI_FastSewing(double theTolerance)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_FastSewing(BRepBuilderAPI_FastSewing parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepBuilderAPI_FastSewing()
		{
			throw new NotImplementedException();
		}

		public bool Add(TopoDS_Shape theShape)
		{
			throw new NotImplementedException();
		}

		public bool Add(Geom_Surface theSurface)
		{
			throw new NotImplementedException();
		}

		public void Perform()
		{
			throw new NotImplementedException();
		}

		public void SetTolerance(double theToler)
		{
			throw new NotImplementedException();
		}

		public double GetTolerance()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape GetResult()
		{
			throw new NotImplementedException();
		}

				public uint GetStatuses()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

								public void FindEdges(int theSurfID)
		{
			throw new NotImplementedException();
		}

		public void UpdateEdgeInfo(int theIDPrevVertex, int theIDCurrVertex, int theFaceID, int theIDCurvOnFace)
		{
			throw new NotImplementedException();
		}

		public void CreateNewEdge(int theIDPrevVertex, int theIDCurrVertex, int theFaceID, int theIDCurvOnFace)
		{
			throw new NotImplementedException();
		}

		public double Compute3DRange()
		{
			throw new NotImplementedException();
		}

		public uint SetStatus(CascadeSharp.BRepBuilderAPI_FastSewing.FS_Statuses theStatus)
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  FS_Statuses
		//---------------------------------------------------------------------
		public		enum FS_Statuses
		{
			FS_OK = 0,
			FS_Degenerated = 1,
			FS_FindVertexError = 2,
			FS_FindEdgeError = 4,
			FS_FaceWithNullSurface = 8,
			FS_NotNaturalBoundsFace = 16,
			FS_InfiniteSurface = 32,
			FS_EmptyInput = 64,
			FS_Exception = 128
		} // enum  class FS_Statuses

	}; // class BRepBuilderAPI_FastSewing

}
