//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKBool.TopOpeBRepDS
{
    //---------------------------------------------------------------------
    //  Class  TopOpeBRepDS_SolidSurfaceInterference
    //---------------------------------------------------------------------
    public sealed class TopOpeBRepDS_SolidSurfaceInterference : TopOpeBRepDS_Interference
    {
        public TopOpeBRepDS_SolidSurfaceInterference(TopOpeBRepDS_Transition Transition, TopOpeBRepDS_Kind SupportType,
            int Support, TopOpeBRepDS_Kind GeometryType, int Geometry)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_SolidSurfaceInterference(TopOpeBRepDS_SolidSurfaceInterference parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public TopOpeBRepDS_SolidSurfaceInterference()
        {
            throw new NotImplementedException();
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class TopOpeBRepDS_SolidSurfaceInterference
}