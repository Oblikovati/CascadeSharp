//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.BRepAdaptor;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel;
using CascadeSharp.TKG2d.Geom2dAdaptor;
using CascadeSharp.TKGeomAlgo.IntRes2d;

namespace CascadeSharp.TKBool.TopOpeBRep
{
	//---------------------------------------------------------------------
	//  Class  TopOpeBRep_Hctxee2d
	//---------------------------------------------------------------------
	public  sealed class TopOpeBRep_Hctxee2d : Standard_Transient
	{

		public TopOpeBRep_Hctxee2d()
			: base()
		{
			throw new NotImplementedException();
		}

		public TopOpeBRep_Hctxee2d(TopOpeBRep_Hctxee2d parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetEdges(TopoDS_Edge E1, TopoDS_Edge E2, BRepAdaptor_Surface BAS1, BRepAdaptor_Surface BAS2)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Edge(int I)
		{
			throw new NotImplementedException();
		}

		public Geom2dAdaptor_Curve Curve(int I)
		{
			throw new NotImplementedException();
		}

		public IntRes2d_Domain Domain(int I)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class TopOpeBRep_Hctxee2d

}
