//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.NCollection;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKG3d.TopAbs;
using CascadeSharp.TKMath.Bnd;

namespace CascadeSharp.TKBO.BOPDS
{
    //---------------------------------------------------------------------
    //  Class  BOPDS_ShapeInfo
    //---------------------------------------------------------------------
    public sealed class BOPDS_ShapeInfo
    {
        public BOPDS_ShapeInfo()
            : base()
        {
            throw new NotImplementedException();
        }

        public BOPDS_ShapeInfo(NCollection_BaseAllocator theAllocator)
            : base()
        {
            throw new NotImplementedException();
        }

        public BOPDS_ShapeInfo(BOPDS_ShapeInfo parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void SetShape(TopoDS_Shape theS)
        {
            throw new NotImplementedException();
        }

        public TopoDS_Shape Shape()
        {
            throw new NotImplementedException();
        }

        public void SetShapeType(TopAbs_ShapeEnum theType)
        {
            throw new NotImplementedException();
        }

        public TopAbs_ShapeEnum ShapeType()
        {
            throw new NotImplementedException();
        }

        public void SetBox(Bnd_Box theBox)
        {
            throw new NotImplementedException();
        }

        public Bnd_Box Box()
        {
            throw new NotImplementedException();
        }

        public Bnd_Box ChangeBox()
        {
            throw new NotImplementedException();
        }

        public TColStd_ListOfInteger SubShapes()
        {
            throw new NotImplementedException();
        }

        public TColStd_ListOfInteger ChangeSubShapes()
        {
            throw new NotImplementedException();
        }

        public bool HasSubShape(int theI)
        {
            throw new NotImplementedException();
        }

        public bool HasReference()
        {
            throw new NotImplementedException();
        }

        public void SetReference(int theI)
        {
            throw new NotImplementedException();
        }

        public int Reference()
        {
            throw new NotImplementedException();
        }

        public bool HasBRep()
        {
            throw new NotImplementedException();
        }

        public bool IsInterfering()
        {
            throw new NotImplementedException();
        }

        public bool HasFlag()
        {
            throw new NotImplementedException();
        }

        public bool HasFlag(ref int theFlag)
        {
            throw new NotImplementedException();
        }

        public void SetFlag(int theI)
        {
            throw new NotImplementedException();
        }

        public int Flag()
        {
            throw new NotImplementedException();
        }

        public void Dump()
        {
            throw new NotImplementedException();
        }
    }; // class BOPDS_ShapeInfo
}