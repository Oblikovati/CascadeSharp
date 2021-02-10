//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;
using CascadeSharp.TKService.Graphic3d;
using CascadeSharp.TKV3d.SelectMgr;

namespace CascadeSharp.TKV3d.AIS
{
    //---------------------------------------------------------------------
    //  Class  AIS_MediaPlayer
    //---------------------------------------------------------------------
    public sealed class AIS_MediaPlayer : AIS_InteractiveObject
    {
        public AIS_MediaPlayer()
            : base()
        {
            throw new NotImplementedException();
        }

        public AIS_MediaPlayer(AIS_MediaPlayer parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }

        public void OpenInput(TCollection_AsciiString thePath, bool theToWait)
        {
            throw new NotImplementedException();
        }

        public bool PresentFrame(Graphic3d_Vec2i theLeftCorner, Graphic3d_Vec2i theMaxSize)
        {
            throw new NotImplementedException();
        }

        public void PlayPause()
        {
            throw new NotImplementedException();
        }

        public void SetClosePlayer()
        {
            throw new NotImplementedException();
        }

        public double Duration()
        {
            throw new NotImplementedException();
        }

        public bool AcceptDisplayMode(int theMode)
        {
            throw new NotImplementedException();
        }

        public void ComputeSelection(SelectMgr_Selection theSel, int theMode)
        {
            throw new NotImplementedException();
        }

        public bool updateSize(Graphic3d_Vec2i theLeftCorner, Graphic3d_Vec2i theMaxSize)
        {
            throw new NotImplementedException();
        }
    }; // class AIS_MediaPlayer
}