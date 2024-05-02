using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Schedule
{
    public class ClassProgram
    {
        //Fields
        List<Course> _programmingCourses;//Declaring progamming courses list
        List<Course> _databaseCourses;//Declaring database courses list
        List<Course> _frontEndCourses;//Declaring front-end courses list

        //Constructor
        public ClassProgram()
        {
            //Initializing our programming courses list
            _programmingCourses = new List<Course>();
            // Progamming 122 - J310
            //Created a course to add to our ClassProgram list
            Course prog122 = new Course("Programming 122", "J310");
            //Add the couse to the _programmingCourse list
            _programmingCourses.Add(prog122);
            _databaseCourses = new List<Course>();
            // Database I - J315
            _databaseCourses.Add(new Course("Database I", "J315"));
            _frontEndCourses = new List<Course>();
            // Front End Web Development - J312
            _frontEndCourses.Add(new Course("Front End Web Development", "J312"));
        }

        //Properies
        //-ProgrammingCourses': Read-only property to access the list of programmiong courses
        //-'DatabaseCourses': Read-only property to access the list of database courses
        //- 'FrontEndCourses': Read-only property to access the list of front-end develepment courses

        


    }//end of class

}//end namespace
