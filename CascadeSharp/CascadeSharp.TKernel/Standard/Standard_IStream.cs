
using System.IO;

namespace CascadeSharp.TKernel.Standard
{
    public abstract class Standard_IStream : Stream
    {
        public int Read(out char[] output, int size)
        {
            output = new char[size];
            using var reader = new StreamReader(this);
            return reader.Read(output, 0, size);
        }
    }
}
