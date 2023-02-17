using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    public class TextCodec
    {
        //field
        sbyte mOffset;
        //constructor
        public TextCodec(sbyte offset)
        {
            mOffset = offset;
        }

        //encode
        public string Encode(string message)
        {
            StringBuilder EBuild = new StringBuilder(message);
            for (int i = 0; i < message.Length; i++)
            {
                EBuild[i] = (char)(EBuild[i] + mOffset);
            }
            return EBuild.ToString();
        }

        //decode
        public string Decode(string message)
        {
            StringBuilder DBuild = new StringBuilder(message);
            for (int i = 0; i < message.Length; i++)
            {
                DBuild[i] = (char)(DBuild[i] - mOffset);
            }
            return DBuild.ToString();
        }
    }
}
