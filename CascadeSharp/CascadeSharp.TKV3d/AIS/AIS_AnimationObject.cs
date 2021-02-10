//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  AIS_AnimationObject
	//---------------------------------------------------------------------
	public  sealed class AIS_AnimationObject : CascadeSharp.AIS_Animation
	{

		public AIS_AnimationObject(TCollection_AsciiString theAnimationName, AIS_InteractiveContext theContext, AIS_InteractiveObject theObject, gp_Trsf theTrsfStart, gp_Trsf theTrsfEnd)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_AnimationObject(AIS_AnimationObject parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public AIS_AnimationObject()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public void update(AIS_AnimationProgress theProgress)
		{
			throw new NotImplementedException();
		}

		public void invalidateViewer()
		{
			throw new NotImplementedException();
		}


	}; // class AIS_AnimationObject

}
