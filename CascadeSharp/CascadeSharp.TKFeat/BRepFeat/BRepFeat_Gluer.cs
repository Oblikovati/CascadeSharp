//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKBRep.TopTools;
using CascadeSharp.TKFeat.LocOpe;
using CascadeSharp.TKTopAlgo.BRepBuilderAPI;

namespace CascadeSharp.TKFeat.BRepFeat
{
	//---------------------------------------------------------------------
	//  Class  BRepFeat_Gluer
	//---------------------------------------------------------------------
	public  sealed class BRepFeat_Gluer : BRepBuilderAPI_MakeShape
	{

		public BRepFeat_Gluer()
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_Gluer(TopoDS_Shape Snew, TopoDS_Shape Sbase)
			: base()
		{
			throw new NotImplementedException();
		}

		public BRepFeat_Gluer(BRepFeat_Gluer parameter1)
			: base()
		{
			throw new NotImplementedException();
		}

		public void Init(TopoDS_Shape Snew, TopoDS_Shape Sbase)
		{
			throw new NotImplementedException();
		}

		public void Bind(TopoDS_Face Fnew, TopoDS_Face Fbase)
		{
			throw new NotImplementedException();
		}

		public void Bind(TopoDS_Edge Enew, TopoDS_Edge Ebase)
		{
			throw new NotImplementedException();
		}

		public LocOpe_Operation OpeType()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape BasisShape()
		{
			throw new NotImplementedException();
		}

		public TopoDS_Shape GluedShape()
		{
			throw new NotImplementedException();
		}

		public void Build()
		{
			throw new NotImplementedException();
		}

		public bool IsDeleted(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}

		public TopTools_ListOfShape Modified(TopoDS_Shape F)
		{
			throw new NotImplementedException();
		}


	}; // class BRepFeat_Gluer

}
