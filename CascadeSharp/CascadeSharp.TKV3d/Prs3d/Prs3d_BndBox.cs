//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.Bnd;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.Prs3d
{
    //---------------------------------------------------------------------
    //  Class  Prs3d_BndBox
    //---------------------------------------------------------------------
    public sealed class Prs3d_BndBox : Prs3d_Root
    {
        public Prs3d_BndBox()
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_BndBox(Prs3d_BndBox parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public void Add(Graphic3d_Structure thePresentation, Bnd_Box theBndBox, Prs3d_Drawer theDrawer)
        {
            throw new NotImplementedException();
        }

        public void Add(Graphic3d_Structure thePresentation, Bnd_OBB theBndBox, Prs3d_Drawer theDrawer)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ArrayOfSegments FillSegments(Bnd_OBB theBox)
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ArrayOfSegments FillSegments(Bnd_Box theBox)
        {
            throw new NotImplementedException();
        }

        public void FillSegments(Graphic3d_ArrayOfSegments theSegments, Bnd_OBB theBox)
        {
            throw new NotImplementedException();
        }

        public void FillSegments(Graphic3d_ArrayOfSegments theSegments, Bnd_Box theBox)
        {
            throw new NotImplementedException();
        }

        public void fillSegments(Graphic3d_ArrayOfSegments theSegments, gp_Pnt theBox)
        {
            throw new NotImplementedException();
        }
    }; // class Prs3d_BndBox
}