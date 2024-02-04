using KodlamaIOKamp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOKamp.Business
{
    public class CourseManager
    {
        Course[] courses=new Course[3];


        public CourseManager()
        {
        
            Course course1 = new Course();
            course1.Name = "c#";
            course1.Id = 1;
            course1.Description = ".NET 8";
            course1.Price = 0;


            Course course2 = new Course();
            course2.Name = "Java";
            course2.Id = 2;
            course2.Description = "JAVA 8";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Name = "Python";
            course3.Id = 3;
            course3.Description = "Python 3.12";
            course3.Price = 00;

            courses[0] = course1;
            courses[1] = course2;
            courses[2] = course3;
        }

        public Course[] GetAll() 
        {
            // veri kaynağından çekilir
            return courses;
        }
    }
}
