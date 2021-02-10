//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKG3d.GeomAdaptor;
using CascadeSharp.TKGeomAlgo.IntPatch;

namespace CascadeSharp.TKGeomAlgo.GeomInt
{
	//---------------------------------------------------------------------
	//  Class  GeomInt_LineTool
	//---------------------------------------------------------------------
	public  sealed class GeomInt_LineTool
	{

		public GeomInt_LineTool()
			: base()
		{
			throw new NotImplementedException();
		}

		public GeomInt_LineTool(GeomInt_LineTool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public int NbVertex(IntPatch_Line L)
		{
			throw new NotImplementedException();
		}

		public IntPatch_Point Vertex(IntPatch_Line L, int I)
		{
			throw new NotImplementedException();
		}

		public double FirstParameter(IntPatch_Line L)
		{
			throw new NotImplementedException();
		}

		public double LastParameter(IntPatch_Line L)
		{
			throw new NotImplementedException();
		}

		public bool DecompositionOfWLine(IntPatch_WLine theWLine, GeomAdaptor_HSurface theSurface1, GeomAdaptor_HSurface theSurface2, double aTolSum, GeomInt_LineConstructor theLConstructor, IntPatch_SequenceOfLine theNewLines)
		{
			throw new NotImplementedException();
		}


	}; // class GeomInt_LineTool

}
