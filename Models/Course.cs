using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Course
    {
        public int Num { get; set; }
        public string VilleCourse { get; set; }
        public string LibCourse { get; set; }
        public DateTime DateCourse { get; set; }

        public Course(int num)
        {
            Num = num;
        }

        public Course(int num,string libCourse,string villeCourse,DateTime dateCourse)
        {
            Num = num;
            LibCourse = libCourse;
            VilleCourse = villeCourse;
            DateCourse = dateCourse;
        }
    }
}