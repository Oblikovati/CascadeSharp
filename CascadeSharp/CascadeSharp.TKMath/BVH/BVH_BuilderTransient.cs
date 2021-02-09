//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  BVH_BuilderTransient
	//---------------------------------------------------------------------
	public  sealed class BVH_BuilderTransient : Standard_Transient
	{

		public BVH_BuilderTransient(int theLeafNodeSize, int theMaxTreeDepth)
			: base()
		{
			throw new NotImplementedException();
		}

		public BVH_BuilderTransient(BVH_BuilderTransient parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public BVH_BuilderTransient()
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

						public int MaxTreeDepth()
		{
			throw new NotImplementedException();
		}

		public int LeafNodeSize()
		{
			throw new NotImplementedException();
		}

		public bool IsParallel()
		{
			throw new NotImplementedException();
		}

		public void SetParallel(bool _isParallel)
		{
			throw new NotImplementedException();
		}


	}; // class BVH_BuilderTransient

}
