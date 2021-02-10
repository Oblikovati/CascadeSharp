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
	//  Class  Prs3d_ToolCylinder
	//---------------------------------------------------------------------
	public  sealed class Prs3d_ToolCylinder : Prs3d_ToolQuadric
	{

		public Prs3d_ToolCylinder(double theBottomRad, double theTopRad, double theHeight, int theNbSlices, int theNbStacks)
			: base()
		{
			throw new NotImplementedException();
		}

		public Prs3d_ToolCylinder(Prs3d_ToolCylinder parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Prs3d_ToolCylinder()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ArrayOfTriangles Create(double theBottomRad, double theTopRad, double theHeight, int theNbSlices, int theNbStacks, gp_Trsf theTrsf)
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


	}; // class Prs3d_ToolCylinder

}
