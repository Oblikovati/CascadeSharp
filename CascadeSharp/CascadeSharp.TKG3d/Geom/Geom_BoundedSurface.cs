//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKG3d.Geom
{
    //---------------------------------------------------------------------
    //  Class  Geom_BoundedSurface
    //---------------------------------------------------------------------
    public abstract class Geom_BoundedSurface : Geom_Surface
    {
        public Geom_BoundedSurface(Geom_BoundedSurface parameter1)
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public Geom_BoundedSurface()
            : base()
        {
            throw new NotImplementedException("Native class is abstract");
        }

        public char get_type_name()
        {
            throw new NotImplementedException("Native class returns pointer to integer/double/handle.");
        }
    }; // class Geom_BoundedSurface
}