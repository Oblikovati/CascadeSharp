//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKernel.TColStd;
using CascadeSharp.TKService.Aspect;

namespace CascadeSharp.TKService.Graphic3d
{
    //---------------------------------------------------------------------
    //  Class  Graphic3d_GraphicDriver
    //---------------------------------------------------------------------
    public abstract class Graphic3d_GraphicDriver : Standard_Transient
    {
        public Graphic3d_GraphicDriver(Aspect_DisplayConnection theD_isp)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Graphic3d_GraphicDriver(Graphic3d_GraphicDriver parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Graphic3d_GraphicDriver()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public int InquireLimit(Graphic3d_TypeOfLimit theType)
        {
            throw new NotImplementedException();
        }

        public int InquireLightLimit()
        {
            throw new NotImplementedException();
        }

        public int InquirePlaneLimit()
        {
            throw new NotImplementedException();
        }

        public int InquireViewLimit()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_CStructure CreateStructure(Graphic3d_StructureManager theManager)
        {
            throw new NotImplementedException();
        }

        public void RemoveStructure(Graphic3d_CStructure theCStructure)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_CView CreateView(Graphic3d_StructureManager theMgr)
        {
            throw new NotImplementedException();
        }

        public void RemoveView(Graphic3d_CView theView)
        {
            throw new NotImplementedException();
        }

        public void EnableVBO(bool status)
        {
            throw new NotImplementedException();
        }

        public bool MemoryInfo(ref ulong theFreeBytes, TCollection_AsciiString theInfo)
        {
            throw new NotImplementedException();
        }

        public float DefaultTextHeight()
        {
            throw new NotImplementedException();
        }

        public void TextSize(Graphic3d_CView theView, string theText, float theHeight, ref float theWidth,
            ref float theAscent, ref float theDescent)
        {
            throw new NotImplementedException();
        }

        public void InsertLayerBefore(int theNewLayerId, Graphic3d_ZLayerSettings theSettings, int theLayerAfter)
        {
            throw new NotImplementedException();
        }

        public void InsertLayerAfter(int theNewLayerId, Graphic3d_ZLayerSettings theSettings, int theLayerBefore)
        {
            throw new NotImplementedException();
        }

        public void RemoveZLayer(int theLayerId)
        {
            throw new NotImplementedException();
        }

        public void ZLayers(TColStd_SequenceOfInteger theLayerSeq)
        {
            throw new NotImplementedException();
        }

        public void SetZLayerSettings(int theLayerId, Graphic3d_ZLayerSettings theSettings)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ZLayerSettings ZLayerSettings(int theLayerId)
        {
            throw new NotImplementedException();
        }

        public bool ViewExists(Aspect_Window theWindow, Graphic3d_CView theView)
        {
            throw new NotImplementedException();
        }

        public Aspect_DisplayConnection GetDisplayConnection()
        {
            throw new NotImplementedException();
        }

        public int NewIdentification()
        {
            throw new NotImplementedException();
        }

        public void RemoveIdentification(int theId)
        {
            throw new NotImplementedException();
        }
    }; // class Graphic3d_GraphicDriver
}