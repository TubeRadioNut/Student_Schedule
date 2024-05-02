using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Schedule
{
    public class Schedule
    {
        //Fields
        string _studentId;
        string _studentName;

        //- '_studentId': A private string to store the studen ID
        //- '_studentName': A private string to store the student name
        //- '_courses': A private list of 'Course' objects, indicating a one-to-many relationship(a schedul has multiple courses)


        //Constructor
        //- 'Schedule()': Initializes a Schedule object, generation a random student ID and creating and empty course list


        //Properties
        //- 'StudentId': read-only property to gete the student ID
        //- 'StudentName': Read-only property to get the student name
        //- 'Courses': read-only property to get the course list


        //Methods
        //- 'AddCourse(course: Course)': Add a course to the schedule
        //- 'FormattedSchedule()': Creates a formatted string representation of the schedule
        //- 'ToString()': Override the drfault 'ToString()' method for a custom representation.

    }//end of class


}//end namespace
