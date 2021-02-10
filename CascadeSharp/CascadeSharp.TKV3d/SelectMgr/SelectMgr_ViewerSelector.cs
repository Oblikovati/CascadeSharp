//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  SelectMgr_ViewerSelector
	//---------------------------------------------------------------------
	public  class SelectMgr_ViewerSelector : Standard_Transient
	{

		public SelectMgr_ViewerSelector()
			: base()
		{
			throw new NotImplementedException();
		}

		public SelectMgr_ViewerSelector(SelectMgr_ViewerSelector parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void Clear()
		{
			throw new NotImplementedException();
		}

		public int CustomPixelTolerance()
		{
			throw new NotImplementedException();
		}

		public void SetPixelTolerance(int theTolerance)
		{
			throw new NotImplementedException();
		}

		public double Sensitivity()
		{
			throw new NotImplementedException();
		}

		public int PixelTolerance()
		{
			throw new NotImplementedException();
		}

		public void SortResult()
		{
			throw new NotImplementedException();
		}

		public SelectMgr_EntityOwner OnePicked()
		{
			throw new NotImplementedException();
		}

		public bool ToPickClosest()
		{
			throw new NotImplementedException();
		}

		public void SetPickClosest(bool theToP_referClosest)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.SelectMgr_TypeOfDepthTolerance DepthToleranceType()
		{
			throw new NotImplementedException();
		}

		public double DepthTolerance()
		{
			throw new NotImplementedException();
		}

		public void SetDepthTolerance(CascadeSharp.SelectMgr_TypeOfDepthTolerance theType, double theTolerance)
		{
			throw new NotImplementedException();
		}

		public int NbPicked()
		{
			throw new NotImplementedException();
		}

		public void ClearPicked()
		{
			throw new NotImplementedException();
		}

		public SelectMgr_EntityOwner Picked(int theRank)
		{
			throw new NotImplementedException();
		}

		public SelectMgr_SortCriterion PickedData(int theRank)
		{
			throw new NotImplementedException();
		}

				public gp_Pnt PickedPoint(int theRank)
		{
			throw new NotImplementedException();
		}

		public bool Contains(SelectMgr_SelectableObject theObject)
		{
			throw new NotImplementedException();
		}

						public bool Modes(SelectMgr_SelectableObject theSelectableObject, TColStd_ListOfInteger theModeL_ist, CascadeSharp.SelectMgr_StateOfSelection theWantedState)
		{
			throw new NotImplementedException();
		}

		public bool Modes(SelectMgr_SelectableObject theSelectableObject, TColStd_ListOfInteger theModeL_ist)
		{
			throw new NotImplementedException();
		}

		public bool IsActive(SelectMgr_SelectableObject theSelectableObject, int theMode)
		{
			throw new NotImplementedException();
		}

		public bool IsInside(SelectMgr_SelectableObject theSelectableObject, int theMode)
		{
			throw new NotImplementedException();
		}

		public CascadeSharp.SelectMgr_StateOfSelection Status(SelectMgr_Selection theSelection)
		{
			throw new NotImplementedException();
		}

		public TCollection_AsciiString Status(SelectMgr_SelectableObject theSelectableObject)
		{
			throw new NotImplementedException();
		}

				public void AddSelectableObject(SelectMgr_SelectableObject theObject)
		{
			throw new NotImplementedException();
		}

		public void AddSelectionToObject(SelectMgr_SelectableObject theObject, SelectMgr_Selection theSelection)
		{
			throw new NotImplementedException();
		}

		public void MoveSelectableObject(SelectMgr_SelectableObject theObject)
		{
			throw new NotImplementedException();
		}

		public void RemoveSelectableObject(SelectMgr_SelectableObject theObject)
		{
			throw new NotImplementedException();
		}

		public void RemoveSelectionOfObject(SelectMgr_SelectableObject theObject, SelectMgr_Selection theSelection)
		{
			throw new NotImplementedException();
		}

		public void RebuildObjectsTree(bool theIsForce)
		{
			throw new NotImplementedException();
		}

		public void RebuildObjectsTree()
		{
			throw new NotImplementedException();
		}

		public void RebuildSensitivesTree(SelectMgr_SelectableObject theObject, bool theIsForce)
		{
			throw new NotImplementedException();
		}

		public void RebuildSensitivesTree(SelectMgr_SelectableObject theObject)
		{
			throw new NotImplementedException();
		}

				public SelectMgr_SelectableObjectSet SelectableObjects()
		{
			throw new NotImplementedException();
		}

		public void ResetSelectionActivationStatus()
		{
			throw new NotImplementedException();
		}

		public void AllowOverlapDetection(bool theIsToAllow)
		{
			throw new NotImplementedException();
		}

						public void Init()
		{
			throw new NotImplementedException();
		}

		public bool More()
		{
			throw new NotImplementedException();
		}

		public void Next()
		{
			throw new NotImplementedException();
		}

		public SelectMgr_EntityOwner Picked()
		{
			throw new NotImplementedException();
		}

		public void InitDetected()
		{
			throw new NotImplementedException();
		}

		public void NextDetected()
		{
			throw new NotImplementedException();
		}

		public bool MoreDetected()
		{
			throw new NotImplementedException();
		}

				public void SetToPrebuildBVH(bool theToPrebuild, int theThreadsNum)
		{
			throw new NotImplementedException();
		}

		public void SetToPrebuildBVH(bool theToPrebuild)
		{
			throw new NotImplementedException();
		}

				public void WaitForBVHBuild()
		{
			throw new NotImplementedException();
		}

		public bool ToPrebuildBVH()
		{
			throw new NotImplementedException();
		}

		public void TraverseSensitives()
		{
			throw new NotImplementedException();
		}

										public void Activate(SelectMgr_Selection theSelection)
		{
			throw new NotImplementedException();
		}

		public void Deactivate(SelectMgr_Selection theSelection)
		{
			throw new NotImplementedException();
		}

		public void Remove(SelectMgr_Selection aSelection)
		{
			throw new NotImplementedException();
		}

				public void initPicked()
		{
			throw new NotImplementedException();
		}

		public void nextPicked()
		{
			throw new NotImplementedException();
		}

		public bool morePicked()
		{
			throw new NotImplementedException();
		}

		
	}; // class SelectMgr_ViewerSelector

}
