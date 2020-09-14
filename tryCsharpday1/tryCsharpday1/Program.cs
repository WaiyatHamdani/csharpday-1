using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace tryCsharpday1
{
    class Program
    {
        public static void forloopexample()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }


        public static void arrayandforeach()
        {
            //-----------------------begin  array ----------------------------------

            var studentGrades = new int[10];
            studentGrades[0] = 80;
            studentGrades[1] = 77;
            studentGrades[2] = 80;
            studentGrades[3] = 67;
            studentGrades[4] = 80;
            studentGrades[5] = 70;
            studentGrades[6] = 90;
            studentGrades[7] = 97;
            studentGrades[8] = 90;
            studentGrades[9] = 100;

            // or 

            var studentGrades2 = new int[4] { 100, 80, 90, 90 };

            Console.WriteLine(studentGrades[2]);
            Console.WriteLine(studentGrades2[3]);

            //-----------------------end array ----------------------------------


            //----------------- for each--------------------
            foreach (var item in studentGrades)
            {
                Console.WriteLine(item);
            }

        }


        static void StudentManager()
        {
            Console.WriteLine("How many student in your class? ");
            var totalstudent = int.Parse(Console.ReadLine());
            var Studentname = new String[totalstudent];
            var Studentgrade = new int[totalstudent];

            for (int i = 0; i < totalstudent; i++)
            {
                Console.WriteLine("Student Name:");
                Studentname[i] = Console.ReadLine();
                Console.WriteLine("Student Grade:");
                Studentgrade[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < totalstudent; i++)
            {
                Console.WriteLine(Studentname[i] +" grade is "+Studentgrade[i]);
            }
        }

        static void StudentManagerUsingCollectionList()
        {
            
            var Studentname = new List<String>();
            var Studentgrade = new List<int>();

            var adding = true;
            while (adding == true)
            {
                Console.WriteLine("Student Name:");
                Studentname.Add(Console.ReadLine());
                Console.WriteLine("Student Grade:");
                Studentgrade.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                var continuing = Console.ReadLine();
                
                if (continuing == "n")
                {
                    adding = false;
                }
            }

           

            for (int i = 0; i < Studentname.Count; i++)
            {
                Console.WriteLine(Studentname[i] + " grade is " + Studentgrade[i]);
            }
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("For loop example-------------");
            // forloopexample();
            // Console.WriteLine("array and For each loop example-------------");
            // arrayandforeach();


            //StudentManager();
            StudentManagerUsingCollectionList();
        }
    }
}
