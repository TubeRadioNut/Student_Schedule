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
        List<Course> _courses;


        //Constructor
        //- 'Schedule()': Initializes a Schedule object, generation a random student ID and creating and empty course list
        public Schedule()
        {
            //Generate a random student ID Number
            //10000000 - 100000000
            Random rand = new Random();
            _studentId = rand.Next(10000000, 100000000).ToString();


            //Initialize Course List
            _courses = new List<Course>();
        }


        //Properties
        //Read only
        public string StudentId
        {
            get { return _studentId; }
        }
        public string StudentName
        {
            get { return _studentName; }
            set { _studentName = value; }
        }
        //Read only
        public List <Course> Courses
        {
            get { return _courses; }
        }


        //Methods
        //- 'AddCourse(course: Course)': Add a course to the schedule
        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }
        //- 'FormattedSchedule()': Creates a formatted string representation of the schedule
        public string FormatSchedule()
        {
            string formatString = "";
            //Student Id: 26358940 - Display Student ID
            formatString += $"Student ID: {_studentId}\n";
            //Student Name: Will - Display student name
            formatString += $"Studnet Name: {_studentName}\n";
            formatString += $"\n";

            for (int i = 0; _courses.Count > i; i++)
            {
                formatString += _courses[i].ToString() + "\n";
            }
            //Display All Classes
            //Programming 122 - J310
            //Database 1 - J315
            //Front End Web Development -J312
            //Programming 122 - J310
            return formatString;
        }
        //- 'ToString()': Override the drfault 'ToString()' method for a custom representation.
        //- `Student ID - Student Name`
        
        public override string ToString()
        {
            //- `12345823 - Will`
            return $"{_studentId} - {_studentName}";
        }

    }//end of class


}//end namespace
