using System;
using System.Text;
using Lab_7A;

namespace FSPG1
{
    public class Submission
    {
        public static StringBuilder Test1(string[] names)
        {
            StringBuilder Build = new StringBuilder();
            for (int i = 0; i < names.Length; i++)
            {
                Build.Append(names[i][0]);
            }
            return Build;
        }

        public static object Test2(float x, float y, float radius)
        {
            Circle circ = new Circle(x,y,radius);
            return circ;
        }

        public static object Test3(float x, float y, float radius)
        {
            Circle circ2 = new Circle(x, y, radius);
            return circ2;
        }

        public static object Test4(float x, float y, float radius)
        {
            Circle circ3 = new Circle(x, y, radius);
            return circ3;
        }

        public static object Test5(float x, float y, float radius)
        {
            Circle circ4 = new Circle(x, y, radius);
            return circ4;
        }

        public static int Test6(string str1, string str2, bool ignoreCase)
        {

            return string.Compare(str1, str2, ignoreCase);
        }

        public static string Test7(sbyte offset, string message)
        {
            TextCodec Mess1 = new TextCodec(offset);
            return Mess1.Encode(message);
        }

        public static string Test8(sbyte offset, string message)
        {
            TextCodec Mess2 = new TextCodec(offset);
            return Mess2.Decode(message);
        }
    }
}
