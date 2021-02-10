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
    //  Class  Prs3d_ToolSphere
    //---------------------------------------------------------------------
    public sealed class Prs3d_ToolSphere : Prs3d_ToolQuadric
    {
        public Prs3d_ToolSphere(double theRadius, int theNbSlices, int theNbStacks)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_ToolSphere(Prs3d_ToolSphere parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public Prs3d_ToolSphere()
        {
            throw new NotImplementedException();
        }

        public Graphic3d_ArrayOfTriangles Create(double theRadius, int theNbSlices, int theNbStacks, gp_Trsf theTrsf)
        {
            throw new NotImplementedException();
        }

        public gp_Pnt Vertex(double theU, double theV)
        {
            throw new NotImplementedException();
        }

        public gp_Dir Normal(double theU, double theV)
        {
            throw new NotImplementedException();
        }
    }; // class Prs3d_ToolSphere
}