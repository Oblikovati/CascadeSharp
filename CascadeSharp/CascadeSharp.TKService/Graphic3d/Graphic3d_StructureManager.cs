//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKMath.TopLoc;

namespace CascadeSharp.TKService.Graphic3d
{
	//---------------------------------------------------------------------
	//  Class  Graphic3d_StructureManager
	//---------------------------------------------------------------------
	public  sealed class Graphic3d_StructureManager : Standard_Transient
	{

		public Graphic3d_StructureManager(Graphic3d_GraphicDriver theDriver)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_StructureManager(Graphic3d_StructureManager parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_StructureManager()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Update(int theLayerId)
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Remove()
		{
			throw new NotImplementedException();
		}

		public void Erase()
		{
			throw new NotImplementedException();
		}

		public void DisplayedStructures(Graphic3d_MapOfStructure SG)
		{
			throw new NotImplementedException();
		}

		public void HighlightedStructures(Graphic3d_MapOfStructure SG)
		{
			throw new NotImplementedException();
		}

		public void ReCompute(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void ReCompute(Graphic3d_Structure theStructure, Graphic3d_DataStructureManager theProjector)
		{
			throw new NotImplementedException();
		}

		public void Clear(Graphic3d_Structure theStructure, bool theWithDestruction)
		{
			throw new NotImplementedException();
		}

		public void Connect(Graphic3d_Structure theMother, Graphic3d_Structure theDaughter)
		{
			throw new NotImplementedException();
		}

		public void Disconnect(Graphic3d_Structure theMother, Graphic3d_Structure theDaughter)
		{
			throw new NotImplementedException();
		}

		public void Display(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void Erase(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void Highlight(Graphic3d_Structure theStructure)
		{
			throw new NotImplementedException();
		}

		public void SetTransform(Graphic3d_Structure theStructure, TopLoc_Datum3D theTrsf)
		{
			throw new NotImplementedException();
		}

		public void ChangeDisplayPriority(Graphic3d_Structure theStructure, int theOldPriority, int theNewPriority)
		{
			throw new NotImplementedException();
		}

		public void ChangeZLayer(Graphic3d_Structure theStructure, int theLayerId)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_GraphicDriver GraphicDriver()
		{
			throw new NotImplementedException();
		}

		public int Identification(Graphic3d_CView theView)
		{
			throw new NotImplementedException();
		}

		public void UnIdentification(Graphic3d_CView theView)
		{
			throw new NotImplementedException();
		}

				public int MaxNumOfViews()
		{
			throw new NotImplementedException();
		}

		public Graphic3d_Structure Identification(int AId)
		{
			throw new NotImplementedException();
		}

		public void UnHighlight(Graphic3d_Structure AStructure)
		{
			throw new NotImplementedException();
		}

		public void UnHighlight()
		{
			throw new NotImplementedException();
		}

		public void RecomputeStructures()
		{
			throw new NotImplementedException();
		}

				public Graphic3d_ViewAffinity RegisterObject(Standard_Transient theObject)
		{
			throw new NotImplementedException();
		}

		public void UnregisterObject(Standard_Transient theObject)
		{
			throw new NotImplementedException();
		}

		public Graphic3d_ViewAffinity ObjectAffinity(Standard_Transient theObject)
		{
			throw new NotImplementedException();
		}

		public bool IsDeviceLost()
		{
			throw new NotImplementedException();
		}

		public void SetDeviceLost()
		{
			throw new NotImplementedException();
		}

						public int NumberOfDisplayedStructures()
		{
			throw new NotImplementedException();
		}


	}; // class Graphic3d_StructureManager

}
