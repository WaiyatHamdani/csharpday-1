using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedDay1
{
    class Student
    {
        private string Name;
        private int Grade;
        private String phone;

        public String Phone
        {
            set { phone = value; }
            get { return phone; }
        }

        public String getname()
        {
            return Name;
        }
      
        public void setname(String Name)
        {
            this.Name = Name;
        }

        public int GRADE
        {
            set { Grade = value; }
            get { return Grade; }
        }
    }
}
