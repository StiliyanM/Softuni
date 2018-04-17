using System;
using System.IO;
namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var source = new FileStream("../Files/copyMe.png",FileMode.Open))
            {
                using (var destination = new FileStream("copy.png",FileMode.Create))
                {
                    while (true)
                    {
                        var buffer = new byte[source.Length];

                        int readbytes = source.Read(buffer, 0, buffer.Length);

                        if (readbytes == 0) 
                        { 
                            break;
                        }
                        destination.Write(buffer, 0, readbytes);
                    }
                }
            }
        }
    }
}
