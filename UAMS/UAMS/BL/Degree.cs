using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DegreeProgram
    {
        public string degreeName;
        public float degreeDurration;
        public List<Subject> subjects;
        public int seats;
        public DegreeProgram(string degreeName)
        {
            this.degreeName = degreeName;
        }
        public DegreeProgram(string degreeName, float degreeDurration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeDurration = degreeDurration;
            subjects = new List<Subject>();
            this.seats = seats;
        }
        public  int calculateCreditHour()
        {
            int craditHour = 0;
            foreach (Subject storeCradit in subjects)
            {
                craditHour += storeCradit.creditHour;
            }
            return craditHour;
        }
        public bool AddSbject(Subject s)
        {
            int creditHour = calculateCreditHour();
            if (creditHour + s.creditHour <= 20)
            {
                subjects.Add(s);
                return true;
            }
            return false;
        }
        public  bool isSubjectExist(Subject sub)
        {
            foreach (Subject storesubject in subjects)
            {
                if (storesubject.code == sub.code && storesubject.type == sub.type)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
