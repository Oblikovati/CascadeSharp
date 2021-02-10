//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace CascadeSharp
{
	//---------------------------------------------------------------------
	//  Class  ShapeFix_Shell
	//---------------------------------------------------------------------
	public  sealed class ShapeFix_Shell : CascadeSharp.ShapeFix_Root
	{

		public ShapeFix_Shell()
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Shell(TopoDS_Shell shape)
			: base()
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Shell(ShapeFix_Shell parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shell shell)
		{
			throw new NotImplementedException();
		}

		public bool Perform(Message_ProgressRange theProgress)
		{
			throw new NotImplementedException();
		}

		public bool Perform()
		{
			throw new NotImplementedException();
		}

		public bool FixFaceOrientation(TopoDS_Shell shell, bool _isAccountMultiConex, bool NonManifold)
		{
			throw new NotImplementedException();
		}

		public bool FixFaceOrientation(TopoDS_Shell shell, bool _isAccountMultiConex)
		{
			throw new NotImplementedException();
		}

		public bool FixFaceOrientation(TopoDS_Shell shell)
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shell Shell()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape Shape()
		{
			throw new NotImplementedException();
		}

		public int NbShells()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Compound ErrorFaces()
		{
			throw new NotImplementedException();
		}

		public bool Status(CascadeSharp.ShapeExtend_Status status)
		{
			throw new NotImplementedException();
		}

		public ShapeFix_Face FixFaceTool()
		{
			throw new NotImplementedException();
		}

		public void SetMsgRegistrator(ShapeExtend_BasicMsgRegistrator msgreg)
		{
			throw new NotImplementedException();
		}

		public void SetPrecision(double preci)
		{
			throw new NotImplementedException();
		}

		public void SetMinTolerance(double mintol)
		{
			throw new NotImplementedException();
		}

		public void SetMaxTolerance(double maxtol)
		{
			throw new NotImplementedException();
		}

		public int FixFaceMode()
		{
			throw new NotImplementedException();
		}

		public int FixOrientationMode()
		{
			throw new NotImplementedException();
		}

		public void SetNonManifoldFlag(bool _isNonManifold)
		{
			throw new NotImplementedException();
		}

		public char get_type_name()
		{
			throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
		}

				
	}; // class ShapeFix_Shell

}
