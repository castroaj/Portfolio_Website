using System;
using System.Linq;
using System.Collections.Generic;


namespace Web.Models {

    public class EducationModel {
        public List<Course> csCourses {get; set;}
        public List<Course> cisCourses {get; set;}
        public List<Course> genEdCourses {get; set;}
    }

}