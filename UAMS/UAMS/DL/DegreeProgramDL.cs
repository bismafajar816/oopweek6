using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using System.IO;

namespace UAMS.DL
{
    class DegreeProgramDL
    {
        public static List<DegreeProgram> programList = new List<DegreeProgram>();
        public static void AddIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }
        public static DegreeProgram IsDegreeExist(string degreeName)
        {
            foreach(DegreeProgram d in programList)
            {
                if(d.degreeName == degreeName)
                {
                    return d;
                }
            }
            return null;
        }
        public static void StoreInFile(string path, DegreeProgram d)
        {
            StreamWriter file = new StreamWriter(path,true);
            string SubjectNames = " ";
            for(int x = 0; x < d.subjects.Count() - 1; x++)
            {
                SubjectNames = SubjectNames + d.subjects[x].type + ";";

            }
            SubjectNames = SubjectNames + d.subjects[d.subjects.Count - 1].type;
            file.WriteLine(d.degreeName + "," + d.degreeDurration + "," + d.seats + "," + SubjectNames);
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
                    string degreeName = splittedRecord[0];
                    float degreeduration = float.Parse( splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    string[] AgainSplit = splittedRecord[3].Split(';');
                    DegreeProgram d = new DegreeProgram(degreeName, degreeduration, seats);
                    for(int x = 0; x < AgainSplit.Length; x++)
                    {
                        Subject s = SubjectDL.isSubjectExist(AgainSplit[x]);
                        if(s != null)
                        {
                            d.AddSbject(s);
                        }
                    }
                    AddIntoDegreeList(d);

                    file.Close();
                    return true;
                }

            }
            else
            {
                return false;
            }
            file.Close();
            return false;

        }
    }
}
