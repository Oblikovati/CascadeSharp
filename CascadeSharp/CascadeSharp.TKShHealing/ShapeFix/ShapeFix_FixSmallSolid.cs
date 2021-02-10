//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKShHealing.ShapeBuild;

namespace CascadeSharp.TKShHealing.ShapeFix
{
	//---------------------------------------------------------------------
	//  Class  ShapeFix_FixSmallSolid
	//---------------------------------------------------------------------
	public  sealed class ShapeFix_FixSmallSolid : ShapeFix_Root
	{

		public ShapeFix_FixSmallSolid()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_FixSmallSolid(ShapeFix_FixSmallSolid parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void SetFixMode(int theMode)
		{
			throw new NotImplementedException();
		}

		public void SetVolumeThreshold(double theThreshold)
		{
			throw new NotImplementedException();
		}

		public void SetVolumeThreshold()
		{
			throw new NotImplementedException();
		}

		public void SetWidthFactorThreshold(double theThreshold)
		{
			throw new NotImplementedException();
		}

		public void SetWidthFactorThreshold()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Remove(TopoDS_Shape theShape, ShapeBuild_ReShape theContext)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Merge(TopoDS_Shape theShape, ShapeBuild_ReShape theContext)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public bool IsThresholdsSet()
		{
			throw new NotImplementedException();
		}

		public bool IsSmall(TopoDS_Shape theSolid)
		{
			throw new NotImplementedException();
		}

		public bool IsUsedWidthFactorThreshold()
		{
			throw new NotImplementedException();
		}

		public bool IsUsedVolumeThreshold()
		{
			throw new NotImplementedException();
		}


	}; // class ShapeFix_FixSmallSolid

}
