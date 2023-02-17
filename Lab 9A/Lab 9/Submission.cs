using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Submission
    {
        public static Student[] enrollment = new Student[0];

        public static Student Test1(string last, string first, int idNo)
        {
            Student s = new Student(last,first,idNo);
            return s;
        }

        public static Student Test2()
        {
            Student s1 = new Student();
            return s1;
        }

        public static bool Test3(Student enrolled)
        {
            bool check  = false;
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i] == null)
                {
                    enrollment[i] = enrolled;
                    check = true;
                    break;
                }

            }
            return check;
        }

        public static bool Test4(int idNumber)
        {
            bool check1 = false;
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i] != null &&enrollment[i].GetIDNumber() == idNumber)
                {
                    enrollment[i] = null;
                    check1 = true;
                    break;
                }
            }
            return check1;
        }

        public static Student Test5(int idNumber)
        {
            Student s3 = new Student();
            s3 = null;
            for (int i = 0; i < enrollment.Length; i++)
            {
                if (enrollment[i] != null && enrollment[i].GetIDNumber() == idNumber)
                {
                    s3 = enrollment[i];
                    break;
                }
            }
            return s3;
        }
    }
}
