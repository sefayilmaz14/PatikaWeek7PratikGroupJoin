using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PatikaWeek7PratikGroupJoin
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }

        public Student(int studentId, string name, int classid)
        {
            StudentId = studentId;
            Name = name;
            ClassId = classid;
        }
    
        
    
    }

}
