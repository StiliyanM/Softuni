using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Serializable]
public class InvalidSongSecondsException : InvalidSongLengthException
{
    public InvalidSongSecondsException() { }
    public InvalidSongSecondsException(string message) : base(message) { }
    public InvalidSongSecondsException(string message, Exception inner) : base(message, inner) { }
    protected InvalidSongSecondsException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
