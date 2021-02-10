//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKMath.gp;

namespace CascadeSharp.TKService.Graphic3d
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_Group
	//---------------------------------------------------------------------
	public  abstract class Graphic3d_Group : Standard_Transient
	{

		public Graphic3d_Group(Graphic3d_Structure theStructure)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_Group(Graphic3d_Group parameter1)
			: base()
		{
			throw new NotImplementedException("Native class is abstract");
		}

		public Graphic3d_Group()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Clear(bool theUpdateStructureMgr)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Remove()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Aspects Aspects()
		{
			throw new NotImplementedException();
		}

		public void SetGroupPrimitivesAspect(Graphic3d_Aspects theAspect)
		{
			throw new NotImplementedException();
		}

		public void SetPrimitivesAspect(Graphic3d_Aspects theAspect)
		{
			throw new NotImplementedException();
		}

		public void SynchronizeAspects()
		{
			throw new NotImplementedException();
		}

		public void ReplaceAspects(Graphic3d_MapOfAspectsToAspects theMap)
		{
			throw new NotImplementedException();
		}

		public void AddText(Graphic3d_Text theTextParams, bool theToEvalMinMax)
		{
			throw new NotImplementedException();
		}

		public void AddText(Graphic3d_Text theTextParams)
		{
			throw new NotImplementedException();
		}

						public void AddPrimitiveArray(Graphic3d_ArrayOfPrimitives thePrim, bool theToEvalMinMax)
		{
			throw new NotImplementedException();
		}

		public void AddPrimitiveArray(Graphic3d_ArrayOfPrimitives thePrim)
		{
			throw new NotImplementedException();
		}

						public void SetStencilTestOptions(bool theIsEnabled)
		{
			throw new NotImplementedException();
		}

		public void SetFlippingOptions(bool theIsEnabled, gp_Ax2 theRefPlane)
		{
			throw new NotImplementedException();
		}

		public bool ContainsFacet()
		{
			throw new NotImplementedException();
		}

		public bool IsDeleted()
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public void MinMaxValues(ref double theXMin, ref double theYMin, ref double theZMin, ref double theXMax, ref double theYMax, ref double theZMax)
		{
			throw new NotImplementedException();
		}

		public void SetMinMaxValues(double theXMin, double theYMin, double theZMin, double theXMax, double theYMax, double theZMax)
		{
			throw new NotImplementedException();
		}

						public Graphic3d_Structure Structure()
		{
			throw new NotImplementedException();
		}

		public void SetClosed(bool theIsClosed)
		{
			throw new NotImplementedException();
		}

		public bool IsClosed()
		{
			throw new NotImplementedException();
		}

																		public void Text(string theTextUtf, gp_Ax2 theOrientation, double theHeight, double theAngle, Graphic3d_TextPath theTp, Graphic3d_HorizontalTextAlignment theHTA, Graphic3d_VerticalTextAlignment theVTA, bool theToEvalMinMax, bool theHasOwnAnchor)
		{
			throw new NotImplementedException();
		}

		public void Text(string theTextUtf, gp_Ax2 theOrientation, double theHeight, double theAngle, Graphic3d_TextPath theTp, Graphic3d_HorizontalTextAlignment theHTA, Graphic3d_VerticalTextAlignment theVTA, bool theToEvalMinMax)
		{
			throw new NotImplementedException();
		}

		public void Text(string theTextUtf, gp_Ax2 theOrientation, double theHeight, double theAngle, Graphic3d_TextPath theTp, Graphic3d_HorizontalTextAlignment theHTA, Graphic3d_VerticalTextAlignment theVTA)
		{
			throw new NotImplementedException();
		}

		public void Text(TCollection_ExtendedString theText, gp_Ax2 theOrientation, double theHeight, double theAngle, Graphic3d_TextPath theTp, Graphic3d_HorizontalTextAlignment theHTA, Graphic3d_VerticalTextAlignment theVTA, bool theToEvalMinMax, bool theHasOwnAnchor)
		{
			throw new NotImplementedException();
		}

		public void Text(TCollection_ExtendedString theText, gp_Ax2 theOrientation, double theHeight, double theAngle, Graphic3d_TextPath theTp, Graphic3d_HorizontalTextAlignment theHTA, Graphic3d_VerticalTextAlignment theVTA, bool theToEvalMinMax)
		{
			throw new NotImplementedException();
		}

		public void Text(TCollection_ExtendedString theText, gp_Ax2 theOrientation, double theHeight, double theAngle, Graphic3d_TextPath theTp, Graphic3d_HorizontalTextAlignment theHTA, Graphic3d_VerticalTextAlignment theVTA)
		{
			throw new NotImplementedException();
		}

						public void Update()
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_Group

}
