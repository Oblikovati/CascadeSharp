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
    //  Class  Graphic3d_ShaderObject
    //---------------------------------------------------------------------
    public sealed class Graphic3d_ShaderObject : Standard_Transient
    {
        public Graphic3d_ShaderObject(Graphic3d_TypeOfShaderObject theType)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ShaderObject(Graphic3d_ShaderObject parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ShaderObject()
        {
            throw new NotImplementedException();
        }

        public bool IsDone()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString Source()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_TypeOfShaderObject Type()
        {
            throw new NotImplementedException();
        }

        public TCollection_AsciiString GetId()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ShaderObject CreateFromFile(Graphic3d_TypeOfShaderObject theType,
            TCollection_AsciiString thePath)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ShaderObject CreateFromSource(Graphic3d_TypeOfShaderObject theType,
            TCollection_AsciiString theSource)
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Graphic3d_ShaderObject
}