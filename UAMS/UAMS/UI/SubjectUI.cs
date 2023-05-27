using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;
namespace UAMS.UI
{
    class SubjectUI
    {
        public static Subject takeInPutForSubject()
        {

            Console.WriteLine("enter subject code:");
            string code = Console.ReadLine();
            Console.WriteLine("enter subject type:");
            string type = Console.ReadLine();
            Console.WriteLine("enter subject cradit hours:");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("enter subject fee:");
            int fee = int.Parse(Console.ReadLine());
            Subject subject = new Subject(code, type, hour, fee);
            return subject;
        }
       public static void viewSubjects(Student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code\tSub Type");
                foreach (Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }
            }
        }
        public static void registerSubjects(Student s)
        {
            Console.WriteLine("enter how manu subjects you want to register");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("enter the subject code");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.code && !(s.regSubject.Contains(sub))) ;
                    s.regStudentSubject(sub);
                    flag = true;
                    break;
                }
                if (flag == false)
                {
                    Console.WriteLine("enter valid course");
                    x--;
                }
            }
        }
    }
}
