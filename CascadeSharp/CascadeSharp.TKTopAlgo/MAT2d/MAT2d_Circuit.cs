//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  MAT2d_Circuit
	//---------------------------------------------------------------------
	public  sealed class MAT2d_Circuit : Standard_Transient
	{

		public MAT2d_Circuit(CascadeSharp.GeomAbs_JoinType aJoinType, bool IsOpenResult)
			: base()
		{
			throw new NotImplementedException();
		}

		public MAT2d_Circuit(CascadeSharp.GeomAbs_JoinType aJoinType)
			: base()
		{
			throw new NotImplementedException();
		}

		public MAT2d_Circuit(MAT2d_Circuit parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public MAT2d_Circuit()
		{
			throw new NotImplementedException();
		}

		public void Perform(MAT2d_SequenceOfSequenceOfGeometry aFigure, TColStd_SequenceOfBoolean IsClosed, int IndRefLine, bool Trigo)
		{
			throw new NotImplementedException();
		}

		public int NumberOfItems()
		{
			throw new NotImplementedException();
		}

		public Geom2d_Geometry Value(int Index)
		{
			throw new NotImplementedException();
		}

		public int LineLength(int IndexLine)
		{
			throw new NotImplementedException();
		}

		public TColStd_SequenceOfInteger RefToEqui(int IndLine, int IndCurve)
		{
			throw new NotImplementedException();
		}

		public MAT2d_Connexion Connexion(int Index)
		{
			throw new NotImplementedException();
		}

		public bool ConnexionOn(int Index)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsSharpCorner(Geom2d_Geometry Geom1, Geom2d_Geometry Geom2, double Direction)
		{
			throw new NotImplementedException();
		}

		public bool PassByLast(MAT2d_Connexion C1, MAT2d_Connexion C2)
		{
			throw new NotImplementedException();
		}

		public double Side(MAT2d_Connexion C, TColGeom2d_SequenceOfGeometry Line)
		{
			throw new NotImplementedException();
		}

		public void UpDateLink(int IFirst, int ILine, int ICurveFirst, int ICurveLast)
		{
			throw new NotImplementedException();
		}

		public void SortRefToEqui(MAT2d_BiInt aBiInt)
		{
			throw new NotImplementedException();
		}

		public void InitOpen(TColGeom2d_SequenceOfGeometry Line)
		{
			throw new NotImplementedException();
		}

		public void InsertCorner(TColGeom2d_SequenceOfGeometry Line)
		{
			throw new NotImplementedException();
		}

		public void DoubleLine(TColGeom2d_SequenceOfGeometry Line, MAT2d_SequenceOfConnexion Connexions, MAT2d_Connexion Father, double Side)
		{
			throw new NotImplementedException();
		}

		public void ConstructCircuit(MAT2d_SequenceOfSequenceOfGeometry aFigure, int IndRefLine, MAT2d_MiniPath aPath)
		{
			throw new NotImplementedException();
		}


	}; // class MAT2d_Circuit

}
