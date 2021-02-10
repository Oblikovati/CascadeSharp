//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  TopClass_SolidExplorer
	//---------------------------------------------------------------------
	public  abstract class TopClass_SolidExplorer
	{

		public TopClass_SolidExplorer()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public TopClass_SolidExplorer(TopClass_SolidExplorer parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public bool Reject(gp_Pnt P)
		{
			throw new NotImplementedException();
		}

		public void Segment(gp_Pnt P, gp_Lin L, ref double Par)
		{
			throw new NotImplementedException();
		}

		public void OtherSegment(gp_Pnt P, gp_Lin L, ref double Par)
		{
			throw new NotImplementedException();
		}

		public void InitShell()
		{
			throw new NotImplementedException();
		}

		public bool MoreShells()
		{
			throw new NotImplementedException();
		}

		public void NextShell()
		{
			throw new NotImplementedException();
		}

		public bool RejectShell(gp_Lin L, double Par)
		{
			throw new NotImplementedException();
		}

		public void InitFace()
		{
			throw new NotImplementedException();
		}

		public bool MoreFaces()
		{
			throw new NotImplementedException();
		}

		public void NextFace()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Face CurrentFace()
		{
			throw new NotImplementedException();
		}

		public bool RejectFace(gp_Lin L, double Par)
		{
			throw new NotImplementedException();
		}


	}; // class TopClass_SolidExplorer

}
