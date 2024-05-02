using Student_Schedule;
using System.CodeDom;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Student_Schedule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Fields
        List<Schedule> previousSchedules = new List<Schedule>();
        //previousSchedules:
        //Type: List<Schedule>
        //Purpose: Stores a list of completed schedules, likely for historical reference or selection.

        //programs:
        //Type: ClassProgram
        //Purpose: Provides access to organized course lists (programming, database, front-end).
        ClassProgram programs = new ClassProgram();
        //currentSchedule:
        //Type: Schedule
        //Purpose: Holds the schedule currently being built by the user.
        Schedule currentSchedule;
        //Methods
        //MainWindow()
        //Purpose: The constructor of the MainWindow class. Initializes components, creates a new currentSchedule, and
        //binds the previousSchedules to the ComboBox.
        //We need to add information to the combo box to display
        //We can use the .ItemsSource property to assing a list
        //that list will be displayed to the combo box
        public MainWindow()
        {
            InitializeComponent();//<----Don't delete this and keep it at the top of MainWindow()

            //Initialize our currentSchedule object
            currentSchedule = new Schedule();
            //assign perviousSchedules to our combo box
            cmbChooseSchedule.ItemsSource = previousSchedules;

            //TEST CODE START
            //Course prog122Course = new Course("Programming 122", "J310");
            //Schedule testSchedule = new Schedule();
            //testSchedule.AddCourse(prog122Course);
            //rtbDisplaySchedule.Text = testSchedule.FormatSchedule();
            //TEST CODE END


        }//end MainWindow

        //btnAddProgramming_Click(object sender, RoutedEventArgs e)
        //Purpose: Event handler for the "Add Programming" button click.
        //Adds the first programming course from programs.ProgrammingCourses to the currentSchedule.
        //Updates the display (rtbDisplaySchedule) with the formatted schedule.
        private void btnAddProgramming_Click(object sender, RoutedEventArgs e)
        {
            //Get the required class from out ClassProgram instance
            //usingindex to get the first time from out list of progamming classes
            //Accessing the instance of our ClassProgram, called programs
            //Accessing the ProgramingCourses LIST - ProgrammingCourses
            //accessing the first item in the list - index 0
            Course progClass = programs.ProgrammingCourses[0];

            //assign the class to our CurrentSchedule instance
            currentSchedule.AddCourse(progClass);
            //Refesh rtbDisplaySchedule
            rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();
        }

        //btnDatabase_Click(object sender, RoutedEventArgs e)
        //Purpose: Event handler for the "Add Database" button click.
        //Adds the first database course from programs.DatabaseCourses to the currentSchedule.
        //Updates the display (rtbDisplaySchedule) with the formatted schedule.
        private void btnDataBase_Click(object sender, RoutedEventArgs e)
        {
            //get the required class from our ClassProgram instace
            Course databaseCourse = programs.DatabaseCourses[0];
            //assign the class to our CurrenSchedule instace
            currentSchedule.AddCourse(databaseCourse);
            //refresh the rtbdisplaySchedule
            rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();
        }

        //btnFrontEnd_Click(object sender, RoutedEventArgs e)
        //Purpose: Event handler for the "Add Front End Web Dev" button click.
        //Adds the first front-end course from programs.FrontEndCourses to the currentSchedule.
        //Updates the display (rtbDisplaySchedule) with the formatted schedule.
        private void btnFrontEnd_Click(object sender, RoutedEventArgs e)
        {
            //get the required class from our ClassProgram instance
            Course frontEndCourse = programs.FrontEndCourses[0];
            //assign the class to our CurrentSchedule instance
            currentSchedule.AddCourse(frontEndCourse);
            //refresh rtbDisplaySchedule
            rtbDisplaySchedule.Text = currentSchedule.FormatSchedule();
        }
        //btnFinalizeSchedule_Click(object sender, RoutedEventArgs e)
        //Purpose: Event handler for the "Finalize Schedule" button click.
        //Gets the student's name from the txtName textbox.
        //If the name is not empty:
        //Assigns the name to the currentSchedule.
        //Adds the currentSchedule to previousSchedules.
        //Updates and refreshes the ComboBox (cmbChooseSchedule).
        //Clears the name textbox.
        //Creates a new currentSchedule.
        //If the name is empty, shows a "Enter a name" message box.
        private void btnFinalizeSchedule_Click(object sender, RoutedEventArgs e)
        {
            //Check to make sure the user has enter a student name
            //if they have, "process" the schedule
            string userName = txtName.Text;
            bool isNotEmpty = userName.Length != 0;

            if (isNotEmpty)
            {
                //run code to process
                //add user name to current schedule
                currentSchedule.StudentName = userName;
                //Add current Schedule to our list of previous schedules
                previousSchedules.Add(currentSchedule);
                //Create a NEW Schedule for current schedule
                currentSchedule = new Schedule();
                //Cleaar test box for name txtName
                txtName.Text = "";
                //clear rtDisplaySchedule
                rtbDisplaySchedule.Text = "";
                //update the combo box to show new items from attached list Refresh cmbChooseSchedule
                cmbChooseSchedule.Items.Refresh();
            }
            else
            {
                //show message box, "enter a name"
                MessageBox.Show("Enter A Name");
            }

            //if not prompt user with message box to enter a name
        }

        //cmbChooseSchedule_SelectionChanged
        //Purpose: Display.FormattedSchedule for the selectedItem in the ComboBox.
        //Events:
        private void cmbChooseSchedule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Grab the selected item
            //tell the computer it is a schedule
            Schedule selectedSchedule = cmbChooseSchedule.SelectedItem as Schedule;
            rtbPreviousSchedule.Text = selectedSchedule.FormatSchedule();
            //Assign the formatSchedule to the rtbPreviousSchedules

        }
    }//partial class

}//end namespace

















