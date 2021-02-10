//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TColgp;

namespace CascadeSharp.TKService.SelectBasics
{
	//---------------------------------------------------------------------
	//  Class  SelectBasics_SelectingVolumeManager
	//---------------------------------------------------------------------
	public  abstract class SelectBasics_SelectingVolumeManager
	{

		public SelectBasics_SelectingVolumeManager()
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public SelectBasics_SelectingVolumeManager(SelectBasics_SelectingVolumeManager parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public int GetActiveSelectionType()
		{
			throw new NotImplementedException();
		}

								public bool Overlaps(gp_Pnt thePnt, SelectBasics_PickResult thePickResult)
		{
			throw new NotImplementedException();
		}

		public bool Overlaps(gp_Pnt thePnt)
		{
			throw new NotImplementedException();
		}

		public bool Overlaps(TColgp_HArray1OfPnt theArrayOfPts, int theSensType, SelectBasics_PickResult thePickResult)
		{
			throw new NotImplementedException();
		}

		public bool Overlaps(TColgp_Array1OfPnt theArrayOfPts, int theSensType, SelectBasics_PickResult thePickResult)
		{
			throw new NotImplementedException();
		}

		public bool Overlaps(gp_Pnt thePt1, gp_Pnt thePt2, SelectBasics_PickResult thePickResult)
		{
			throw new NotImplementedException();
		}

		public bool Overlaps(gp_Pnt thePt1, gp_Pnt thePt2, gp_Pnt thePt3, int theSensType, SelectBasics_PickResult thePickResult)
		{
			throw new NotImplementedException();
		}

		public double DistToGeometryCenter(gp_Pnt theCOG)
		{
			throw new NotImplementedException();
		}

		public gp_Pnt DetectedPoint(double theDepth)
		{
			throw new NotImplementedException();
		}

		public bool IsOverlapAllowed()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt GetNearPickedPnt()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt GetFarPickedPnt()
		{
			throw new NotImplementedException();
		}

		public gp_Pnt2d GetMousePosition()
		{
			throw new NotImplementedException();
		}

						
		//---------------------------------------------------------------------
		//  Enum  SelectionType
		//---------------------------------------------------------------------
		public		enum SelectionType
		{
			Point = 0,
			Box = 1,
			Polyline = 2,
			Unknown = 3
		} // enum  class SelectionType

	}; // class SelectBasics_SelectingVolumeManager

}
