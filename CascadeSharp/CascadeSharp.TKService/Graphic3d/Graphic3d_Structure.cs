//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKService.Graphic3d
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_Structure
	//---------------------------------------------------------------------
	public  class Graphic3d_Structure : Standard_Transient
	{

		public Graphic3d_Structure(Graphic3d_StructureManager theManager, Graphic3d_Structure theLinkPrs)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Structure(Graphic3d_StructureManager theManager)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Structure(Graphic3d_Structure parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Structure()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Clear(bool WithDestruction)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public void Display()
		{
			throw new NotImplementedException();
		}

		public int DisplayPriority()
		{
			throw new NotImplementedException();
		}

		public void Erase()
		{
			throw new NotImplementedException();
		}

		public void Highlight(Graphic3d_PresentationAttributes theStyle, bool theToUpdateMgr)
		{
			throw new NotImplementedException();
		}

		public void Highlight(Graphic3d_PresentationAttributes theStyle)
		{
			throw new NotImplementedException();
		}

		public void Remove()
		{
			throw new NotImplementedException();
		}

		public void CalculateBoundBox()
		{
			throw new NotImplementedException();
		}

		public void SetInfiniteState(bool theToSet)
		{
			throw new NotImplementedException();
		}

		public void SetDisplayPriority(int Priority)
		{
			throw new NotImplementedException();
		}

		public void ResetDisplayPriority()
		{
			throw new NotImplementedException();
		}

		public void SetZLayer(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public int GetZLayer()
		{
			throw new NotImplementedException();
		}

		public void SetClipPlanes(Graphic3d_SequenceOfHClipPlane thePlanes)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_SequenceOfHClipPlane ClipPlanes()
		{
			throw new NotImplementedException();
		}

		public void SetVisible(bool AValue)
		{
			throw new NotImplementedException();
		}

		public void SetVisual(Graphic3d_TypeOfStructure AV_isual)
		{
			throw new NotImplementedException();
		}

		public void SetZoomLimit(double LimitInf, double LimitSup)
		{
			throw new NotImplementedException();
		}

		public void SetIsForHighlight(bool _isForHighlight)
		{
			throw new NotImplementedException();
		}

		public void UnHighlight()
		{
			throw new NotImplementedException();
		}

		public void Compute()
		{
			throw new NotImplementedException();
		}

		public void computeHLR(Graphic3d_Camera theProjector, Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void ReCompute()
		{
			throw new NotImplementedException();
		}

		public void ReCompute(Graphic3d_DataStructureManager aProjector)
		{
			throw new NotImplementedException();
		}

		public bool ContainsFacet()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_SequenceOfGroup Groups()
		{
			throw new NotImplementedException();
		}

		public int NumberOfGroups()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Group NewGroup()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Group CurrentGroup()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_PresentationAttributes HighlightStyle()
		{
			throw new NotImplementedException();
		}

		public bool IsDeleted()
		{
			throw new NotImplementedException();
		}

		public bool IsDisplayed()
		{
			throw new NotImplementedException();
		}

		public bool IsEmpty()
		{
			throw new NotImplementedException();
		}

		public bool IsInfinite()
		{
			throw new NotImplementedException();
		}

		public bool IsHighlighted()
		{
			throw new NotImplementedException();
		}

		public bool IsTransformed()
		{
			throw new NotImplementedException();
		}

		public bool IsVisible()
		{
			throw new NotImplementedException();
		}

		public Bnd_Box MinMaxValues(bool theToIgnoreInfiniteFlag)
		{
			throw new NotImplementedException();
		}

		public Bnd_Box MinMaxValues()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TypeOfStructure Visual()
		{
			throw new NotImplementedException();
		}

		public bool AcceptConnection(Graphic3d_Structure theStructure1, Graphic3d_Structure theStructure2, Graphic3d_TypeOfConnection theType)
		{
			throw new NotImplementedException();
		}

		public void Ancestors(Graphic3d_MapOfStructure SG)
		{
			throw new NotImplementedException();
		}

		public void Connect(Graphic3d_Structure theStructure, Graphic3d_TypeOfConnection theType, bool theWithCheck)
		{
			throw new NotImplementedException();
		}

		public void Connect(Graphic3d_Structure theStructure, Graphic3d_TypeOfConnection theType)
		{
			throw new NotImplementedException();
		}

		public void Connect(Graphic3d_Structure thePrs)
		{
			throw new NotImplementedException();
		}

		public void Descendants(Graphic3d_MapOfStructure SG)
		{
			throw new NotImplementedException();
		}

		public void Disconnect(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void Remove(Graphic3d_Structure thePrs)
		{
			throw new NotImplementedException();
		}

		public void DisconnectAll(Graphic3d_TypeOfConnection AType)
		{
			throw new NotImplementedException();
		}

		public void RemoveAll()
		{
			throw new NotImplementedException();
		}

				public void SetOwner(IntPtr theOwner)
		{
			throw new NotImplementedException();
		}

		public IntPtr Owner()
		{
			throw new NotImplementedException();
		}

		public void SetHLRValidation(bool theFlag)
		{
			throw new NotImplementedException();
		}

		public bool HLRValidation()
		{
			throw new NotImplementedException();
		}

		public TopLoc_Datum3D Transformation()
		{
			throw new NotImplementedException();
		}

		public void SetTransformation(TopLoc_Datum3D theTrsf)
		{
			throw new NotImplementedException();
		}

		public void Transform(TopLoc_Datum3D theTrsf)
		{
			throw new NotImplementedException();
		}

		public void SetTransformPersistence(Graphic3d_TransformPers theTrsfPers)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TransformPers TransformPersistence()
		{
			throw new NotImplementedException();
		}

		public void SetMutable(bool theIsMutable)
		{
			throw new NotImplementedException();
		}

		public bool IsMutable()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_TypeOfStructure ComputeVisual()
		{
			throw new NotImplementedException();
		}

		public void GraphicClear(bool WithDestruction)
		{
			throw new NotImplementedException();
		}

		public void GraphicConnect(Graphic3d_Structure theDaughter)
		{
			throw new NotImplementedException();
		}

		public void GraphicDisconnect(Graphic3d_Structure theDaughter)
		{
			throw new NotImplementedException();
		}

		public void GraphicTransform(TopLoc_Datum3D theTrsf)
		{
			throw new NotImplementedException();
		}

		public int Identification()
		{
			throw new NotImplementedException();
		}

		public void PrintNetwork(Graphic3d_Structure AStructure, Graphic3d_TypeOfConnection AType)
		{
			throw new NotImplementedException();
		}

		public void Remove(Graphic3d_Structure thePtr, Graphic3d_TypeOfConnection theType)
		{
			throw new NotImplementedException();
		}

		public void SetComputeVisual(Graphic3d_TypeOfStructure theV_isual)
		{
			throw new NotImplementedException();
		}

		public void Transforms(gp_Trsf theTrsf, double theX, double theY, double theZ, ref double theNewX, ref double theNewY, ref double theNewZ)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_CStructure CStructure()
		{
			throw new NotImplementedException();
		}

						public void TransformBoundaries(gp_Trsf theTrsf, ref double theXMin, ref double theYMin, ref double theZMin, ref double theXMax, ref double theYMax, ref double theZMax)
		{
			throw new NotImplementedException();
		}

		public bool AppendDescendant(Graphic3d_Structure theDescendant)
		{
			throw new NotImplementedException();
		}

		public bool RemoveDescendant(Graphic3d_Structure theDescendant)
		{
			throw new NotImplementedException();
		}

		public bool AppendAncestor(Graphic3d_Structure theAncestor)
		{
			throw new NotImplementedException();
		}

		public bool RemoveAncestor(Graphic3d_Structure theAncestor)
		{
			throw new NotImplementedException();
		}

		public void clear(bool WithDestruction)
		{
			throw new NotImplementedException();
		}

		public void erase()
		{
			throw new NotImplementedException();
		}

		public void Remove(Graphic3d_Group theGroup)
		{
			throw new NotImplementedException();
		}

		public void GroupsWithFacet(int ADelta)
		{
			throw new NotImplementedException();
		}

												public Graphic3d_StructureManager StructureManager()
		{
			throw new NotImplementedException();
		}

		public void Update(bool theUpdateLayer)
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_Structure

}
