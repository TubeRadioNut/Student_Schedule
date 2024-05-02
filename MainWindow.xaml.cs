using Student_Schedule;
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
        public MainWindow()
        {
            InitializeComponent();
        }//end MainWindow

    }//partial class

}//end namespace

//Fields

//previousSchedules:
//Type: List<Schedule>
//Purpose: Stores a list of completed schedules, likely for historical reference or selection.
//programs:
//Type: ClassProgram
//Purpose: Provides access to organized course lists (programming, database, front-end).
//currentSchedule:
//Type: Schedule
//Purpose: Holds the schedule currently being built by the user.
//Methods

//MainWindow()

//Purpose: The constructor of the MainWindow class. Initializes components, creates a new currentSchedule, and binds the previousSchedules to the ComboBox.
//btnAddProgramming_Click(object sender, RoutedEventArgs e)

//Purpose: Event handler for the "Add Programming" button click.
//Adds the first programming course from programs.ProgrammingCourses to the currentSchedule.
//Updates the display (rtbDisplaySchedule) with the formatted schedule.
//btnDatabase_Click(object sender, RoutedEventArgs e)

//Purpose: Event handler for the "Add Database" button click.
//Adds the first database course from programs.DatabaseCourses to the currentSchedule.
//Updates the display (rtbDisplaySchedule) with the formatted schedule.
//btnFrontEnd_Click(object sender, RoutedEventArgs e)

//Purpose: Event handler for the "Add Front End Web Dev" button click.
//Adds the first front-end course from programs.FrontEndCourses to the currentSchedule.
//Updates the display (rtbDisplaySchedule) with the formatted schedule.
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
//cmbChooseSchedule_SelectionChanged

//Purpose: Display.FormattedSchedule for the selectedItem in the ComboBox.
//Events:

//btnAddProgramming_Click: Triggered when the "Add Programming" button is clicked.
//btnDatabase_Click: Triggered when the "Add Database" button is clicked.
//btnFrontEnd_Click: Triggered when the "Add Front End Web Dev" button is clicked.
//btnFinalizeSchedule_Click: Triggered when the "Finalize Schedule" button is clicked.
//cmbChooseSchedule_SelectionChanged: Triggers when a new item is selected in the combo box