//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKMath.gp;
using CascadeSharp.TKService.Graphic3d;

namespace CascadeSharp.TKV3d.Prs3d
{
    //---------------------------------------------------------------------
    //  Class  Prs3d_ToolDisk
    //---------------------------------------------------------------------
    public sealed class Prs3d_ToolDisk : Prs3d_ToolQuadric
    {
        public Prs3d_ToolDisk(double theInnerRadius, double theOuterRadius, int theNbSlices, int theNbStacks)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_ToolDisk(Prs3d_ToolDisk parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_ToolDisk()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ArrayOfTriangles Create(double theInnerRadius, double theOuterRadius, int theNbSlices,
            int theNbStacks, gp_Trsf theTrsf)
        {
            throw new NotImplementedException();
        }

        public void SetAngleRange(double theStartAngle, double theEndAngle)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Vertex(double theU, double theV)
        {
            throw new NotImplementedException();
        }

        public gp_Dir Normal(double parameter1, double parameter2)
        {
            throw new NotImplementedException();
        }
    }; // class Prs3d_ToolDisk
}