//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKGeomAlgo.Intf
{
	//---------------------------------------------------------------------
	//  Class  Intf_Tool
	//---------------------------------------------------------------------
	public  sealed class Intf_Tool
	{

		public Intf_Tool()
			: base()
		{
			throw new NotImplementedException();
		}

		public Intf_Tool(Intf_Tool parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Lin2dBox(gp_Lin2d theLin2d, Bnd_Box2d bounding, Bnd_Box2d boxLin)
		{
			throw new NotImplementedException();
		}

		public void Hypr2dBox(gp_Hypr2d theHypr2d, Bnd_Box2d bounding, Bnd_Box2d boxHypr)
		{
			throw new NotImplementedException();
		}

		public void Parab2dBox(gp_Parab2d theParab2d, Bnd_Box2d bounding, Bnd_Box2d boxHypr)
		{
			throw new NotImplementedException();
		}

		public void LinBox(gp_Lin theLin, Bnd_Box bounding, Bnd_Box boxLin)
		{
			throw new NotImplementedException();
		}

		public void HyprBox(gp_Hypr theHypr, Bnd_Box bounding, Bnd_Box boxHypr)
		{
			throw new NotImplementedException();
		}

		public void ParabBox(gp_Parab theParab, Bnd_Box bounding, Bnd_Box boxHypr)
		{
			throw new NotImplementedException();
		}

		public int NbSegments()
		{
			throw new NotImplementedException();
		}

		public double BeginParam(int SegmentNum)
		{
			throw new NotImplementedException();
		}

		public double EndParam(int SegmentNum)
		{
			throw new NotImplementedException();
		}

		public int Inters2d(gp_Hypr2d theCurve, Bnd_Box2d Domain)
		{
			throw new NotImplementedException();
		}

		public int Inters2d(gp_Parab2d theCurve, Bnd_Box2d Domain)
		{
			throw new NotImplementedException();
		}

		public int Inters3d(gp_Hypr theCurve, Bnd_Box Domain)
		{
			throw new NotImplementedException();
		}

		public int Inters3d(gp_Parab theCurve, Bnd_Box Domain)
		{
			throw new NotImplementedException();
		}


	}; // class Intf_Tool

}
