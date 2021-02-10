//---------------------------------------------------------------------
// CascadeSharp
// General Public License V2
//---------------------------------------------------------------------

using System;
using CascadeSharp.TKernel.TCollection;

namespace CascadeSharp.TKernel.Message
{
    //---------------------------------------------------------------------
    //  Class  Message_MsgFile
    //---------------------------------------------------------------------
    public sealed class Message_MsgFile
    {
        public Message_MsgFile()
            : base()
        {
            throw new NotImplementedException();
        }

        public Message_MsgFile(Message_MsgFile parameter1)
            : base()
        {
            throw new NotImplementedException();
        }

        public bool Load(string theDirName, string theFileName)
        {
            throw new NotImplementedException();
        }

        public bool LoadFile(string theFName)
        {
            throw new NotImplementedException();
        }

        public bool LoadFromEnv(string theEnvName, string theFileName, string theLangExt)
        {
            throw new NotImplementedException();
        }

        public bool LoadFromEnv(string theEnvName, string theFileName)
        {
            throw new NotImplementedException();
        }

        public bool LoadFromString(string theContent, int theLength)
        {
            throw new NotImplementedException();
        }

        public bool LoadFromString(string theContent)
        {
            throw new NotImplementedException();
        }

        public bool AddMsg(TCollection_AsciiString key, TCollection_ExtendedString text)
        {
            throw new NotImplementedException();
        }

        public bool HasMsg(TCollection_AsciiString key)
        {
            throw new NotImplementedException();
        }

        public TCollection_ExtendedString Msg(string key)
        {
            throw new NotImplementedException();
        }

        public TCollection_ExtendedString Msg(TCollection_AsciiString key)
        {
            throw new NotImplementedException();
        }
    }; // class Message_MsgFile
}