using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek7PratikGroupJoin
{
    public class Classes
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public Classes(int classid, string classname)
        {
            ClassId = classid;
            ClassName = classname;
        }
    }
}
