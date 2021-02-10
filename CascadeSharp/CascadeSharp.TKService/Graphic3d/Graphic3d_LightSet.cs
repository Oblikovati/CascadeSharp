//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_LightSet
    //---------------------------------------------------------------------
    public sealed class Graphic3d_LightSet : Standard_Transient
    {
        public Graphic3d_LightSet()
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_LightSet(Graphic3d_LightSet parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public int Lower()
        {
            throw new NotImplementedException();
        }

        public int Upper()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public int Extent()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_CLight Value(int theIndex)
        {
            throw new NotImplementedException();
        }

        public bool Contains(Graphic3d_CLight theLight)
        {
            throw new NotImplementedException();
        }

        public bool Add(Graphic3d_CLight theLight)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Graphic3d_CLight theLight)
        {
            throw new NotImplementedException();
        }

        public int NbLightsOfType(Graphic3d_TypeOfLightSource theType)
        {
            throw new NotImplementedException();
        }

        public ulong UpdateRevision()
        {
            throw new NotImplementedException();
        }

        public ulong Revision()
        {
            throw new NotImplementedException();
        }

        public int NbEnabled()
        {
            throw new NotImplementedException();
        }

        public int NbEnabledLightsOfType(Graphic3d_TypeOfLightSource theType)
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString KeyEnabledLong()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString KeyEnabledShort()
        {
            throw new NotImplementedException();
        }


        //---------------------------------------------------------------------
        //  Enum  IterationFilter
        //---------------------------------------------------------------------
        public enum IterationFilter
        {
            IterationFilter_None = 0,
            IterationFilter_ExcludeAmbient = 2,
            IterationFilter_ExcludeDisabled = 4,
            IterationFilter_ExcludeDisabledAndAmbient = 6
        } // enum  class IterationFilter
    }; // class Graphic3d_LightSet
}