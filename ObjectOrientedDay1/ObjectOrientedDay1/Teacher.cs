using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedDay1
{
    class Teacher
    {
        private String name;
        private String subject;

        // c sharp can have multiple constructor

        public Teacher() { }
        public Teacher(String Name, String Subject)
        {
            this.name = Name;
            this.subject = Subject;
        }

        public String Name
        {
            get { return name; }
        }

        public String Subject
        {
            get { return subject; }
        }
    }
}
