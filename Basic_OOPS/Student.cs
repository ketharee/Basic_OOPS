using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_OOPS
{
    public class Student
    {
        #region Variables
        private int _rollnumber;
        private string _name;
        #endregion

        #region Properties
        public int Rollnumber
        {
            get { return _rollnumber; }
            set { _rollnumber = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Methods
        public Student SetStudentInfo(int rollnumber, string name)
        {
            return new Student { Rollnumber = rollnumber, Name = name };
        }
        #endregion               

    }
}
