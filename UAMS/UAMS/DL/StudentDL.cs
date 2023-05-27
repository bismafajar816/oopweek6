using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO;

namespace UAMS.DL
{
    class StudentDL
    {
        public static List<Student> studentList = new List<Student>();
        public static void storeStudentInList(Student s)
        {
            studentList.Add(s);
        }
        public static Student StudentPresent(string name)
        {
            foreach (Student s in StudentDL.studentList)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        public static List<Student> sortStudentsByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.CalculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
       public  static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student s in sortedStudentList)
            {
                foreach (DegreeProgram d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        public static void StoreInFile(string path, Student s)
        {
            StreamWriter file = new StreamWriter(path);
            string DegreeName = "";
            for(int x = 0; x < s.preferences.Count - 1; x++)
            {
                DegreeName = DegreeName + s.preferences[x].degreeName + ";";

            }
            DegreeName = DegreeName + s.preferences[s.preferences.Count - 1].degreeName;
            file.WriteLine(s.name + "," + s.age + "," + s.fscMarks + "," + s.ecatMarks + "," + DegreeName);
            file.Flush();
            file.Close();
        }
        public static bool ReadFromFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            if(File.Exists(path))
            {
                while((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');
                    string name = splittedRecord[0];
                    int age = int.Parse(splittedRecord[1]);
                    double fscMarks = double.Parse(splittedRecord[2]);
                    double ecatMarks = double.Parse(splittedRecord[3]);
                    string[] AgainSplit = splittedRecord[4].Split(';');
                    List<DegreeProgram> preferences = new List<DegreeProgram>();
                    for(int x = 0; x< AgainSplit.Length; x++)
                    {
                        DegreeProgram d = DegreeProgramDL.IsDegreeExist(AgainSplit[x]);
                        if(d!= null)
                        {
                            if(!preferences.Contains(d))
                            {
                                preferences.Add(d);
                            }
                        }
                    }
                    Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
                    studentList.Add(s);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
