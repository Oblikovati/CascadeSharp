using System.IO;

namespace CascadeSharp.TKernel.Standard
{
    public abstract class Standard_OStream : Stream
    {
        public void Write(string s)
        {
            using var writer = new StreamWriter(this);
            writer.Write(s);
        }
    }
}
