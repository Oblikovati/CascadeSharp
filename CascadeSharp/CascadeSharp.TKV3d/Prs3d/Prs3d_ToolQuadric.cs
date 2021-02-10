//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.Prs3d
{
	//---------------------------------------------------------------------
	//  Class  Prs3d_ToolQuadric
	//---------------------------------------------------------------------
	public  abstract class Prs3d_ToolQuadric
	{

		public Prs3d_ToolQuadric()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Prs3d_ToolQuadric(Prs3d_ToolQuadric parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public int TrianglesNb(int theSlicesNb, int theStacksNb)
		{
			throw new NotImplementedException();
		}

		public int VerticesNb(int theSlicesNb, int theStacksNb, bool theIsIndexed)
		{
			throw new NotImplementedException();
		}

		public int VerticesNb(int theSlicesNb, int theStacksNb)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ArrayOfTriangles CreateTriangulation(gp_Trsf theTrsf)
		{
			throw new NotImplementedException();
		}

				public void FillArray(Graphic3d_ArrayOfTriangles theArray, gp_Trsf theTrsf)
		{
			throw new NotImplementedException();
		}

				public int TrianglesNb()
		{
			throw new NotImplementedException();
		}

		public int VerticesNb(bool theIsIndexed)
		{
			throw new NotImplementedException();
		}

		public int VerticesNb()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Vertex(double theU, double theV)
		{
			throw new NotImplementedException();
		}

		public gp_Dir Normal(double theU, double theV)
		{
			throw new NotImplementedException();
		}


	}; // class Prs3d_ToolQuadric

}
