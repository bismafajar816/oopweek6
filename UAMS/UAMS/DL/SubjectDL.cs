using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO;


namespace UAMS.DL
{
    class SubjectDL
    {
        public static List<Subject> subjectList = new List<Subject>();
        public static void AddSubjectToList(Subject s)
        {
            subjectList.Add(s);
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
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int creditHours = int.Parse(splittedRecord[2]);
                    int subjectfees = int.Parse(splittedRecord[3]);
                    Subject s = new Subject(code, type, creditHours, subjectfees);
                    AddSubjectToList(s);

                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void StoreInFile(string path, Subject s)
        {
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(s.code + "," + s.type + "," + s.creditHour + "," + s.subjectFee);
            file.Flush();
            file.Close();
        
        }
        public static Subject isSubjectExist(string type)
        {
            foreach (Subject s in subjectList)
            {
                if (s.type == type)
                {
                    return s;
                }
            }
            return null;
        }


    }
}
