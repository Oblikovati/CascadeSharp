//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.Quantity;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_AttributeFilter
    //---------------------------------------------------------------------
    public sealed class AIS_AttributeFilter : SelectMgr_Filter
    {
        public AIS_AttributeFilter()
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_AttributeFilter(Quantity_NameOfColor aCol)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_AttributeFilter(double aWidth)
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_AttributeFilter(AIS_AttributeFilter parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool HasColor()
        {
            throw new NotImplementedException();
        }

        public bool HasWidth()
        {
            throw new NotImplementedException();
        }

        public void SetColor(Quantity_NameOfColor aCol)
        {
            throw new NotImplementedException();
        }

        public void SetWidth(double aWidth)
        {
            throw new NotImplementedException();
        }

        public void UnsetColor()
        {
            throw new NotImplementedException();
        }

        public void UnsetWidth()
        {
            throw new NotImplementedException();
        }

        public bool IsOk(SelectMgr_EntityOwner anObj)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class AIS_AttributeFilter
}