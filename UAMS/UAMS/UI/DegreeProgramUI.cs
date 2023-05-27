using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
using UAMS.UI;

namespace UAMS.UI
{
    class DegreeProgramUI
    {
        public static DegreeProgram takeInputForDegree()

        {
            List<Subject> subjects = new List<Subject>();
            Console.WriteLine("enter degree name: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Seats for Degree: ");
            int seat = int.Parse(Console.ReadLine());
            DegreeProgram program = new DegreeProgram(name, duration, seat);
            Console.WriteLine("enter how many subject you want to add");
            int subNum = int.Parse(Console.ReadLine());
            for (int x = 0; x < subNum; x++)
            {
                Subject s = SubjectUI.takeInPutForSubject();
               
               if(program.AddSbject(s))
                {
                    if(!SubjectDL.subjectList.Contains(s))
                    {
                        SubjectDL.AddSubjectToList(s);
                        SubjectDL.StoreInFile("subject.txt", s);
                    }
                    Console.WriteLine("Subject Added");
                }
               else
                {
                    Console.WriteLine("Subject Not Added");
                    Console.WriteLine("20 credit hours limited");
                    x--;
                }
            }
            return program;

        }
        public static void viewDegreeProgram(List<DegreeProgram> programList)
        {
            foreach (DegreeProgram dp in programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }

    }
}
