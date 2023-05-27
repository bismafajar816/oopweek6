using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
namespace UAMS.UI
{
    class StudentUI
    {
        public static void printStudents()
        {
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "got Admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + "did not get admission");
                }
            }
        }
       public static void viewStudentInDegree(string degrName)
        {
            Console.WriteLine("name\t\tFSC\t\tAge");
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    if (degrName == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "\t\t" + s.fscMarks + "\t\t" + s.age);
                    }
                }
            }
        }
      public  static void viewRegisteredStudents()
        {
            Console.WriteLine("name\t\tfsc\t\tEcat\t\tage");
            foreach (Student s in StudentDL.studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " " + s.fscMarks + " " + s.ecatMarks + " " + s.age);
                }
            }
        }
        public static Student takeInPutForStudent()
        {
            List<DegreeProgram> pref = new List<DegreeProgram>();
            Console.WriteLine("enter student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter student age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter student fscMarks: ");
            float fscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("enter student ecatMarks: ");
            float ecatMarks = float.Parse(Console.ReadLine());
            DegreeProgramUI.viewDegreeProgram(pref);
            Console.WriteLine("enter how many preferences you want to add");
            int prefNum = int.Parse(Console.ReadLine());

            for (int x = 0; x < prefNum; x++)
            {
                Console.WriteLine("enter your pref:");
                string prefer = Console.ReadLine();
                bool flag = false;
                foreach (DegreeProgram dp in DegreeProgramDL.programList)
                {
                    if (prefer == dp.degreeName && !(pref.Contains(dp)))
                    {
                        pref.Add(new DegreeProgram(prefer));
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("enter valid degree name:");
                }

            }
            Student student = new Student(name, age, fscMarks, ecatMarks, pref);
            return student;
        }

    }
}
