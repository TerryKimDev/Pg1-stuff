using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9A
{
    public class Student
    {
        // Add member fields here
        int id;
        string Fname;
        string Lname;

        // Add default and overloaded constructors here
        public Student()
        {
            id = 1000000;
            Fname = Lname = "";
        }

        public Student(string ln, string fn, int No)
        {
            id = No;
            Fname = fn;
            Lname = ln;
        }

        // add Getters and Setters here
        public string GetFirstName()
        {
            return Fname;
        }

        public string GetLastName()
        {
            return Lname;
        }

        public int GetIDNumber()
        {
            return id;
        }

        public void SetFirstName(string Sf)
        {
            Fname = Sf;
        }

        public void SetLastName(string Sl)
        {
            Lname = Sl;
        }

        public void SetIDNumber(int IDN)
        {
            id = IDN;
        }


















/******************************************************************************************************
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                      do not modify any of the following code                                        *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
*                                                                                                     *
******************************************************************************************************/
        public override string ToString()
        {
            return "ID #: " + GetIDNumber() + "\tName: " + GetLastName() + ", " + GetFirstName();
        }

        public override bool Equals(object obj)
        {
            bool same = true;
            Student s2 = (Student)obj;
            if (this.GetLastName() != s2.GetLastName() || this.GetFirstName() != s2.GetFirstName() || this.GetIDNumber() != s2.GetIDNumber())
            {
                same = false;
            }
            return same;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
