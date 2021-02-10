//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKFillet.ChFiDS
{
	//---------------------------------------------------------------------
	//  Class  ChFiDS_SurfData
	//---------------------------------------------------------------------
	public  sealed class ChFiDS_SurfData : Standard_Transient
	{

		public ChFiDS_SurfData()
			: base()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_SurfData(ChFiDS_SurfData parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Copy(ChFiDS_SurfData Other)
		{
			throw new NotImplementedException();
		}

		public int IndexOfS1()
		{
			throw new NotImplementedException();
		}

		public int IndexOfS2()
		{
			throw new NotImplementedException();
		}

		public bool IsOnCurve1()
		{
			throw new NotImplementedException();
		}

		public bool IsOnCurve2()
		{
			throw new NotImplementedException();
		}

		public int IndexOfC1()
		{
			throw new NotImplementedException();
		}

		public int IndexOfC2()
		{
			throw new NotImplementedException();
		}

		public int Surf()
		{
			throw new NotImplementedException();
		}

		public TopAbs_Orientation Orientation()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_FaceInterference InterferenceOnS1()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_FaceInterference InterferenceOnS2()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint VertexFirstOnS1()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint VertexFirstOnS2()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint VertexLastOnS1()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint VertexLastOnS2()
		{
			throw new NotImplementedException();
		}

		public void ChangeIndexOfS1(int Index)
		{
			throw new NotImplementedException();
		}

		public void ChangeIndexOfS2(int Index)
		{
			throw new NotImplementedException();
		}

		public void ChangeSurf(int Index)
		{
			throw new NotImplementedException();
		}

		public void SetIndexOfC1(int Index)
		{
			throw new NotImplementedException();
		}

		public void SetIndexOfC2(int Index)
		{
			throw new NotImplementedException();
		}

		public TopAbs_Orientation ChangeOrientation()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_FaceInterference ChangeInterferenceOnS1()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_FaceInterference ChangeInterferenceOnS2()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint ChangeVertexFirstOnS1()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint ChangeVertexFirstOnS2()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint ChangeVertexLastOnS1()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint ChangeVertexLastOnS2()
		{
			throw new NotImplementedException();
		}

		public ChFiDS_FaceInterference Interference(int OnS)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_FaceInterference ChangeInterference(int OnS)
		{
			throw new NotImplementedException();
		}

		public int Index(int OfS)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint Vertex(bool First, int OnS)
		{
			throw new NotImplementedException();
		}

		public ChFiDS_CommonPoint ChangeVertex(bool First, int OnS)
		{
			throw new NotImplementedException();
		}

		public bool IsOnCurve(int OnS)
		{
			throw new NotImplementedException();
		}

		public int IndexOfC(int OnS)
		{
			throw new NotImplementedException();
		}

		public double FirstSpineParam()
		{
			throw new NotImplementedException();
		}

		public double LastSpineParam()
		{
			throw new NotImplementedException();
		}

		public void FirstSpineParam(double Par)
		{
			throw new NotImplementedException();
		}

		public void LastSpineParam(double Par)
		{
			throw new NotImplementedException();
		}

		public double FirstExtensionValue()
		{
			throw new NotImplementedException();
		}

		public double LastExtensionValue()
		{
			throw new NotImplementedException();
		}

		public void FirstExtensionValue(double Extend)
		{
			throw new NotImplementedException();
		}

		public void LastExtensionValue(double Extend)
		{
			throw new NotImplementedException();
		}

		public Standard_Transient Simul()
		{
			throw new NotImplementedException();
		}

		public void SetSimul(Standard_Transient S)
		{
			throw new NotImplementedException();
		}

		public void ResetSimul()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d Get2dPoints(bool First, int OnS)
		{
			throw new NotImplementedException();
		}

		public void Get2dPoints(gp_Pnt2d P2df1, gp_Pnt2d P2dl1, gp_Pnt2d P2df2, gp_Pnt2d P2dl2)
		{
			throw new NotImplementedException();
		}

		public void Set2dPoints(gp_Pnt2d P2df1, gp_Pnt2d P2dl1, gp_Pnt2d P2df2, gp_Pnt2d P2dl2)
		{
			throw new NotImplementedException();
		}

		public bool TwistOnS1()
		{
			throw new NotImplementedException();
		}

		public bool TwistOnS2()
		{
			throw new NotImplementedException();
		}

		public void TwistOnS1(bool T)
		{
			throw new NotImplementedException();
		}

		public void TwistOnS2(bool T)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ChFiDS_SurfData

}
