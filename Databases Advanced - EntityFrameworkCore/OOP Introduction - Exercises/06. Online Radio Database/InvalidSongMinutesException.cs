﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Serializable]
public class InvalidSongMinutesException : InvalidSongLengthException
{
    public InvalidSongMinutesException() { }
    public InvalidSongMinutesException(string message) : base(message) { }
    public InvalidSongMinutesException(string message, Exception inner) : base(message, inner) { }
    protected InvalidSongMinutesException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}