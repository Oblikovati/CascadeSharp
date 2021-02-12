//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;

namespace CascadeSharp.TKG3d.TopAbs
{
    //---------------------------------------------------------------------
    //  Class  TopAbs
    //---------------------------------------------------------------------
    public sealed class TopAbs
    {

        public static TopAbs_Orientation Compose(TopAbs_Orientation Or1, TopAbs_Orientation Or2)
        {
            throw new NotImplementedException();
        }

        public static TopAbs_Orientation Reverse(TopAbs_Orientation Or)
        {
            throw new NotImplementedException();
        }

        public static TopAbs_Orientation Complement(TopAbs_Orientation Or)
        {
            throw new NotImplementedException();
        }

        public static string ShapeTypeToString(TopAbs_ShapeEnum theType)
        {
            throw new NotImplementedException();
        }

        public static TopAbs_ShapeEnum ShapeTypeFromString(string theTypeString)
        {
            throw new NotImplementedException();
        }

        public static bool ShapeTypeFromString(string theTypeString, ref TopAbs_ShapeEnum theType)
        {
            throw new NotImplementedException();
        }

        public static string ShapeOrientationToString(TopAbs_Orientation theOrientation)
        {
            throw new NotImplementedException();
        }

        public static TopAbs_Orientation ShapeOrientationFromString(string theOrientationString)
        {
            throw new NotImplementedException();
        }

        public static bool ShapeOrientationFromString(string theOrientationString, ref TopAbs_Orientation theOrientation)
        {
            throw new NotImplementedException();
        }
    }; // class TopAbs
}