using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Schedule
{
    public class Course
    {
        //Fields

        string _name;// Course Name
        string _location;//Course Location - Room Number
        


        //Constructor
        public Course(string name, string location)
        {
            _name = name;
            _location = location;
        }

        //Properties
        public string Name
        {
            //Getters and Setters
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Location
        {
            //Getters and Setters
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }


        //Method
        public override string ToString()
        {
            return $"{_name} - {_location}";
        }

    }//end of class

}//end of namespace
