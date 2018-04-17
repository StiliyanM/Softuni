using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



[Serializable]
public class InvalidSongNameException : InvalidSongException
{
    public InvalidSongNameException() { }
    public InvalidSongNameException(string message) : base(message) { }
    public InvalidSongNameException(string message, Exception inner) : base(message, inner) { }
    protected InvalidSongNameException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
