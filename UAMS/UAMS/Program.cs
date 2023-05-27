using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
using UAMS.UI;


namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string subjectPath = "subject.txt";
            string degreePath = "degree.txt";
            string studentPath = "student.txt";
            if(SubjectDL.ReadFromFile(subjectPath))
            {
                Console.WriteLine("Subject DAta loaded");

            }
            if(DegreeProgramDL.ReadFromFile(degreePath))
            {
                Console.WriteLine("Degree DAta loaded");

            }
            if(StudentDL.ReadFromFile(studentPath))
            {
                Console.WriteLine("Student DAta loaded");

            }
            int option;
            do
            {
                option = MenuUI.menu();
                MenuUI.ClearScreen();
                if (option == 1)
                {
                    if (DegreeProgramDL.programList.Count > 0)
                    {
                        Student s = StudentUI.takeInPutForStudent();
                        StudentDL.storeStudentInList(s);
                        StudentDL.StoreInFile(studentPath, s);
                    }
                    option = MenuUI.menu();
                }
                else if (option == 2)
                {
                    DegreeProgram d = DegreeProgramUI.takeInputForDegree();
                    DegreeProgramDL.AddIntoDegreeList(d);
                    DegreeProgramDL.StoreInFile(degreePath, d);
                    option = MenuUI.menu();
                }
                else if (option == 3)
                {
                    List<Student> storedStudentsList = new List<Student>();
                    storedStudentsList = StudentDL.sortStudentsByMerit();
                    StudentDL.giveAdmission(storedStudentsList);
                    StudentUI.printStudents();


                }
                else if (option == 4)
                {
                    StudentUI.viewRegisteredStudents();

                }
                else if (option == 5)
                {
                    string name;
                    Console.WriteLine("Enter degree name: ");
                    name = Console.ReadLine();
                    StudentUI.viewStudentInDegree(name);
                }
                else if (option == 6)
                {
                    Console.WriteLine("Enter name of student: ");
                    string name = Console.ReadLine();
                    Student s = StudentDL.StudentPresent(name);
                    if (s != null)
                    {
                        SubjectUI.viewSubjects(s);
                        SubjectUI.registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    Student s = new Student();
                    s.calculateFee();
                }
                    MenuUI.ClearScreen();                            
                 
            }
            while (option != 0);

        }
    }
}
