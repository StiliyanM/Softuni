using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



[Serializable]
public class InvalidSongLengthException : InvalidSongException
{
    public InvalidSongLengthException() { }
    public InvalidSongLengthException(string message) : base(message) { }
    public InvalidSongLengthException(string message, Exception inner) : base(message, inner) { }
    protected InvalidSongLengthException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
