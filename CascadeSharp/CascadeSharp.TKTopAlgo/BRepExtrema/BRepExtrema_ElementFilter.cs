//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKTopAlgo.BRepExtrema
{
	//---------------------------------------------------------------------
	//  Class  BRepExtrema_ElementFilter
	//---------------------------------------------------------------------
	public  sealed class BRepExtrema_ElementFilter
	{

		public BRepExtrema_ElementFilter(BRepExtrema_ElementFilter parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepExtrema_ElementFilter()
			: base()
		{
			throw new NotImplementedException();
		}

		public FilterResult PreCheckElements(int parameter1, int parameter2)
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  FilterResult
		//---------------------------------------------------------------------
		public		enum FilterResult
		{
			NoCheck = 0,
			Overlap = 1,
			DoCheck = 2
		} // enum  class FilterResult

	}; // class BRepExtrema_ElementFilter

}
