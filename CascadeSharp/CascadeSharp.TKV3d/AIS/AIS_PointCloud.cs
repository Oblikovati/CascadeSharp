//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.TColgp;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
	//---------------------------------------------------------------------
	//  Class  AIS_PointCloud
	//---------------------------------------------------------------------
	public  sealed class AIS_PointCloud : AIS_InteractiveObject
	{

		public AIS_PointCloud()
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_PointCloud(AIS_PointCloud parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void SetPoints(Graphic3d_ArrayOfPoints thePoints)
		{
			throw new NotImplementedException();
		}

		public void SetPoints(TColgp_HArray1OfPnt theCoords, Quantity_HArray1OfColor theColors, TColgp_HArray1OfDir theNormals)
		{
			throw new NotImplementedException();
		}

		public void SetPoints(TColgp_HArray1OfPnt theCoords, Quantity_HArray1OfColor theColors)
		{
			throw new NotImplementedException();
		}

		public void SetPoints(TColgp_HArray1OfPnt theCoords)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ArrayOfPoints GetPoints()
		{
			throw new NotImplementedException();
		}

		public Bnd_Box GetBoundingBox()
		{
			throw new NotImplementedException();
		}

		public void SetColor(Quantity_Color theColor)
		{
			throw new NotImplementedException();
		}

		public void UnsetColor()
		{
			throw new NotImplementedException();
		}

		public void SetMaterial(Graphic3d_MaterialAspect theMat)
		{
			throw new NotImplementedException();
		}

		public void UnsetMaterial()
		{
			throw new NotImplementedException();
		}

				public void ComputeSelection(SelectMgr_Selection theSelection, int theMode)
		{
			throw new NotImplementedException();
		}


		//---------------------------------------------------------------------
		//  Enum  DisplayMode
		//---------------------------------------------------------------------
		public		enum DisplayMode
		{
			DM_Points = 0,
			DM_BndBox = 2
		} // enum  class DisplayMode

		//---------------------------------------------------------------------
		//  Enum  SelectionMode
		//---------------------------------------------------------------------
		public		enum SelectionMode
		{
			SM_Points = 0,
			SM_SubsetOfPoints = 1,
			SM_BndBox = 2
		} // enum  class SelectionMode

	}; // class AIS_PointCloud

}
