//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKService.Aspect;

namespace CascadeSharp.TKV3d.Prs3d
{
	//---------------------------------------------------------------------
	//  Class  Prs3d_IsoAspect
	//---------------------------------------------------------------------
	public  sealed class Prs3d_IsoAspect : Prs3d_LineAspect
	{

		public Prs3d_IsoAspect(Quantity_Color theColor, Aspect_TypeOfLine theType, double theWidth, int theNumber)
			: base()
		{
			throw new NotImplementedException();
		}

		public Prs3d_IsoAspect(Prs3d_IsoAspect parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Prs3d_IsoAspect()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetNumber(int theNumber)
		{
			throw new NotImplementedException();
		}

		public int Number()
		{
			throw new NotImplementedException();
		}


	}; // class Prs3d_IsoAspect

}
