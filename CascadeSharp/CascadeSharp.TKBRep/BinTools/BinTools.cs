//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using System.Globalization;
using CascadeSharp.TKBRep.TopoDS;
using CascadeSharp.TKernel.Message;
using CascadeSharp.TKernel.Standard;
using CascadeSharp.TKernel.Storage;

namespace CascadeSharp.TKBRep.BinTools
{
    //---------------------------------------------------------------------
    //  Class  BinTools
    //---------------------------------------------------------------------
    public sealed class BinTools
    {
        //TODO: is the serialization will be made in binary or stream?
        //holding this until more clarification
        public static Standard_OStream PutBool(Standard_OStream theOs, bool theValue)
        {
            theOs.Write(theValue? "1" : "0");
            return theOs;
        }
        public static Standard_OStream PutInteger(Standard_OStream theOs, int theValue)
        {
            theOs.Write(theValue.ToString(CultureInfo.InvariantCulture));
            return theOs;
        }
        public static Standard_OStream PutShortReal(Standard_OStream theOs, float theValue)
        {
            theOs.Write(theValue.ToString(CultureInfo.InvariantCulture));
            return theOs;
        }
        public static Standard_OStream PutReal(Standard_OStream theOs, double theValue)
        {
            theOs.Write(theValue.ToString(CultureInfo.InvariantCulture));
            return theOs;
        }
        public static Standard_OStream ExtChar(Standard_OStream theOs, char theValue)
        {
            theOs.Write(theValue.ToString(CultureInfo.InvariantCulture));
            return theOs;
        }

        public static Standard_IStream GetShortReal(Standard_IStream theIs, out float theValue)
        {
            char[] buffer;
            if(theIs.Read(out buffer, sizeof(float)) != sizeof(float))
                throw new Storage_StreamTypeMismatchError();
            theValue = (float) (object) buffer;
            return theIs;
        }
        public static bool Write(TopoDS_Shape theShape, string theFile, Message_ProgressRange theRange)
        {
            throw new NotImplementedException();
        }

        public static bool Write(TopoDS_Shape theShape, string theFile)
        {
            throw new NotImplementedException();
        }

        public static bool Read(TopoDS_Shape theShape, string theFile, Message_ProgressRange theRange)
        {
            throw new NotImplementedException();
        }

        public static bool Read(TopoDS_Shape theShape, string theFile)
        {
            throw new NotImplementedException();
        }
    }
}