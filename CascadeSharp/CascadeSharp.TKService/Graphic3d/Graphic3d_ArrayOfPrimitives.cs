//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_ArrayOfPrimitives
	//---------------------------------------------------------------------
	public  class Graphic3d_ArrayOfPrimitives : Standard_Transient
	{

		public Graphic3d_ArrayOfPrimitives(CascadeSharp.Graphic3d_TypeOfPrimitiveArray theType, int theMaxVertexs, int theMaxBounds, int theMaxEdges, int theArrayFlags)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ArrayOfPrimitives(Graphic3d_ArrayOfPrimitives parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ArrayOfPrimitives()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public Graphic3d_ArrayOfPrimitives CreateArray(CascadeSharp.Graphic3d_TypeOfPrimitiveArray theType, int theMaxVertexs, int theMaxEdges, int theArrayFlags)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ArrayOfPrimitives CreateArray(CascadeSharp.Graphic3d_TypeOfPrimitiveArray theType, int theMaxVertexs, int theMaxBounds, int theMaxEdges, int theArrayFlags)
		{
			throw new NotImplementedException();
		}

				public CascadeSharp.Graphic3d_TypeOfPrimitiveArray Type()
		{
			throw new NotImplementedException();
		}

		public string StringType()
		{
			throw new NotImplementedException();
		}

		public bool HasVertexNormals()
		{
			throw new NotImplementedException();
		}

		public bool HasVertexColors()
		{
			throw new NotImplementedException();
		}

		public bool HasVertexTexels()
		{
			throw new NotImplementedException();
		}

		public int VertexNumber()
		{
			throw new NotImplementedException();
		}

		public int VertexNumberAllocated()
		{
			throw new NotImplementedException();
		}

		public int ItemNumber()
		{
			throw new NotImplementedException();
		}

		public bool IsValid()
		{
			throw new NotImplementedException();
		}

		public int AddVertex(gp_Pnt theVertex)
		{
			throw new NotImplementedException();
		}

				public int AddVertex(double theX, double theY, double theZ)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(float theX, float theY, float theZ)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(gp_Pnt theVertex, Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(gp_Pnt theVertex, int theColor32)
		{
			throw new NotImplementedException();
		}

				public int AddVertex(gp_Pnt theVertex, gp_Dir theNormal)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(double theX, double theY, double theZ, double theNX, double theNY, double theNZ)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(float theX, float theY, float theZ, float theNX, float theNY, float theNZ)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(gp_Pnt theVertex, gp_Dir theNormal, Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(gp_Pnt theVertex, gp_Dir theNormal, int theColor32)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(gp_Pnt theVertex, gp_Pnt2d theTexel)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(double theX, double theY, double theZ, double theTX, double theTY)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(float theX, float theY, float theZ, float theTX, float theTY)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(gp_Pnt theVertex, gp_Dir theNormal, gp_Pnt2d theTexel)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(double theX, double theY, double theZ, double theNX, double theNY, double theNZ, double theTX, double theTY)
		{
			throw new NotImplementedException();
		}

		public int AddVertex(float theX, float theY, float theZ, float theNX, float theNY, float theNZ, float theTX, float theTY)
		{
			throw new NotImplementedException();
		}

		public void SetVertice(int theIndex, gp_Pnt theVertex)
		{
			throw new NotImplementedException();
		}

		public void SetVertice(int theIndex, float theX, float theY, float theZ)
		{
			throw new NotImplementedException();
		}

		public void SetVertexColor(int theIndex, Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetVertexColor(int theIndex, double theR, double theG, double theB)
		{
			throw new NotImplementedException();
		}

				public void SetVertexColor(int theIndex, int theColor32)
		{
			throw new NotImplementedException();
		}

		public void SetVertexNormal(int theIndex, gp_Dir theNormal)
		{
			throw new NotImplementedException();
		}

		public void SetVertexNormal(int theIndex, double theNX, double theNY, double theNZ)
		{
			throw new NotImplementedException();
		}

		public void SetVertexTexel(int theIndex, gp_Pnt2d theTexel)
		{
			throw new NotImplementedException();
		}

		public void SetVertexTexel(int theIndex, double theTX, double theTY)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt Vertice(int theRank)
		{
			throw new NotImplementedException();
		}

		public void Vertice(int theRank, ref double theX, ref double theY, ref double theZ)
		{
			throw new NotImplementedException();
		}

		public Quantity_Color VertexColor(int theRank)
		{
			throw new NotImplementedException();
		}

				public void VertexColor(int theRank, ref double theR, ref double theG, ref double theB)
		{
			throw new NotImplementedException();
		}

		public void VertexColor(int theRank, ref int theColor)
		{
			throw new NotImplementedException();
		}

		public gp_Dir VertexNormal(int theRank)
		{
			throw new NotImplementedException();
		}

		public void VertexNormal(int theRank, ref double theNX, ref double theNY, ref double theNZ)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d VertexTexel(int theRank)
		{
			throw new NotImplementedException();
		}

		public void VertexTexel(int theRank, ref double theTX, ref double theTY)
		{
			throw new NotImplementedException();
		}

				public int EdgeNumber()
		{
			throw new NotImplementedException();
		}

		public int EdgeNumberAllocated()
		{
			throw new NotImplementedException();
		}

		public int Edge(int theRank)
		{
			throw new NotImplementedException();
		}

		public int AddEdge(int theVertexIndex)
		{
			throw new NotImplementedException();
		}

		public int AddEdges(int theVertexIndex1, int theVertexIndex2)
		{
			throw new NotImplementedException();
		}

		public int AddSegmentEdges(int theVertexIndex1, int theVertexIndex2)
		{
			throw new NotImplementedException();
		}

		public int AddEdges(int theVertexIndex1, int theVertexIndex2, int theVertexIndex3)
		{
			throw new NotImplementedException();
		}

		public int AddTriangleEdges(int theVertexIndex1, int theVertexIndex2, int theVertexIndex3)
		{
			throw new NotImplementedException();
		}

						public int AddEdges(int theVertexIndex1, int theVertexIndex2, int theVertexIndex3, int theVertexIndex4)
		{
			throw new NotImplementedException();
		}

		public int AddQuadEdges(int theVertexIndex1, int theVertexIndex2, int theVertexIndex3, int theVertexIndex4)
		{
			throw new NotImplementedException();
		}

		public int AddQuadTriangleEdges(int theVertexIndex1, int theVertexIndex2, int theVertexIndex3, int theVertexIndex4)
		{
			throw new NotImplementedException();
		}

				public void AddTriangleStripEdges(int theVertexLower, int theVertexUpper)
		{
			throw new NotImplementedException();
		}

		public void AddTriangleFanEdges(int theVertexLower, int theVertexUpper, bool theToClose)
		{
			throw new NotImplementedException();
		}

		public void AddPolylineEdges(int theVertexLower, int theVertexUpper, bool theToClose)
		{
			throw new NotImplementedException();
		}

				public bool HasBoundColors()
		{
			throw new NotImplementedException();
		}

		public int BoundNumber()
		{
			throw new NotImplementedException();
		}

		public int BoundNumberAllocated()
		{
			throw new NotImplementedException();
		}

		public int Bound(int theRank)
		{
			throw new NotImplementedException();
		}

		public Quantity_Color BoundColor(int theRank)
		{
			throw new NotImplementedException();
		}

		public void BoundColor(int theRank, ref double theR, ref double theG, ref double theB)
		{
			throw new NotImplementedException();
		}

		public int AddBound(int theEdgeNumber)
		{
			throw new NotImplementedException();
		}

		public int AddBound(int theEdgeNumber, Quantity_Color theBColor)
		{
			throw new NotImplementedException();
		}

		public int AddBound(int theEdgeNumber, double theR, double theG, double theB)
		{
			throw new NotImplementedException();
		}

		public void SetBoundColor(int theIndex, Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void SetBoundColor(int theIndex, double theR, double theG, double theB)
		{
			throw new NotImplementedException();
		}

		public void init(CascadeSharp.Graphic3d_TypeOfPrimitiveArray theType, int theMaxVertexs, int theMaxBounds, int theMaxEdges, int theArrayFlags)
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_ArrayOfPrimitives

}
