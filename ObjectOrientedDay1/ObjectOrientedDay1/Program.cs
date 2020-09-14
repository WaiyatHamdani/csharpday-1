using System;
using System.Collections.Generic;
using System.Globalization;

namespace ObjectOrientedDay1
{
    class Program
    {
        static void Main(string[] args)
        {

            //student.setname("Waiyat");
            // student.setgrade(90);

            // Console.WriteLine(student.getname());
            // Console.WriteLine(student.getGrade());
            Student student;

            var Students = new List<Student>();

            var adding = true;
            while (adding == true)
            {
                student = new Student();

                //the way java did the encapsulation
                Console.WriteLine("enter student name :");
                student.setname(Console.ReadLine());
                //------------------------------------

                // the way c sharp do encapsulation using set and get
                Console.WriteLine("enter grade :");
                student.GRADE= int.Parse(Console.ReadLine());


                //-------------------------------------------------

                //working with namespace console.cs 

                //Console.WriteLine("enter phone number: "); --> original
                //student.Phone = Console.ReadLine();

                //now u can do this 
                student.Phone = Util.Console.Ask("student phone number : ");



                //-------------------------------------------------------

                Students.Add(student);


                Console.WriteLine("do you want to continue y/n  :");
                var yorn = Console.ReadLine();

                if(yorn == "n")
                {
                    adding = false;

                    //try adding teache name and subject they teach
                    Teacher t = new Teacher("Karl", "C sharp class");
                    Console.WriteLine("teacher name: {0}", t.Name);
                    Console.WriteLine("Subject : {0}", t.Subject);
                }

            }

            foreach(var temp in Students)
            {
                Console.WriteLine(temp.getname() 
                    + " grade is "
                    +temp.GRADE 
                    +" phone number is "
                    +temp.Phone);
            }
        }
    }

}
