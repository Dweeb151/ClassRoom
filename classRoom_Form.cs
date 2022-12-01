/* 
 * File Name: classRoom.cs
 * Author: Hamish Stockwell
 * Date: 11/11/2022
 * Version: 2.0
 * Notes:   Backed up previous versions to local PC

DEVELOPMENT PLAN
01. Read through documentation provided for project                                                   
02. Review scenario
03. Create solution file
04. Develop main class which will include most functionality
05. Develop second class which will include the lists, getters and setters, compareTo and toCSV methods
06. Develop GUI
07. Program buttons
08. Validate data
09. Test all required functionality

FUNCTIONALITIES
1.	View the layout of the room including desks and student names in a graphical (grid-style) format.
2.	Edit these details on screen.
3.	Clear all the student names.
4.	Save the updated details into a new file. This will require the application also to save an updated teacher name, class, room, and date.
5.	Select a required data file via an Open-File dialog box.
6.	Sort the student list alphabetically by name, and present the resulting list on a popup dialog box with each student’s grid location noted.
7.	Search for a student and have their location highlight within the grid. 
Then display the sorted list of students (as per dot point 6 above) and highlight the required person. 
You need to search for the required student within the sorted list using a binary search. (See screen image on the following page)
8.	Save the data into a Random Access File. 

MAINTENANCE
17/11/2022
Hamish Stockwell
Fixed issue where saving out and opening the saved file would be corrupted. Was missing commas at the end of each line.
 */

namespace classRoom
{
    /// <summary>
    /// Form1 : Form creates GUI form
    /// </summary>
    public partial class Form1 : Form
    {
        // Starting data grid view
        public const int TOTAL_ROWS = 19;
        public const int TOTAL_COLS = 10;

        // private data for the GUI Form
        private List<ClassRoom> cellList;
        private List<ClassRoom> studentList;
        private string currentFilePath;
        private int currentRecord;

        /*
        Method:     ConstructorMethod()
        Purpose:    Builds GUI and prepares logic
        Inputs:     VOID
        Outputs:    VOID
        */
        /// <summary>
        /// Form1() is constructor method
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            currentRecord = 0;

            // Set columns
            classRoom_DataGridView.ColumnCount = TOTAL_COLS;

            // sff further rows to data grid view (total of 19 required)
            for (int i = 0; i < TOTAL_ROWS - 1; i++)
            {
                classRoom_DataGridView.Rows.Add();
            }

            // set appropriate row header width (for row header number)
            classRoom_DataGridView.RowHeadersWidth = 50;

            // set up row header numbers starting with 0
            for (int count = 0; count <= (classRoom_DataGridView.Rows.Count -1);
                count++)
            {
                classRoom_DataGridView.Rows[count].HeaderCell.Value = string.Format((count).ToString(), "0");
            }

            // set up font style and size for the data grid view
            classRoom_DataGridView.DefaultCellStyle.Font = new Font("Arial", 10);

            // initialize cellList
            cellList = new List<ClassRoom>();

            // init studentList (used for sorting student names)
            studentList = new List<ClassRoom>();

            //currentFilePath = "D:\\Diploma Programming\\PRO AT3 - 443 C#\\AT3\\ICTPRG443_AT3_SupportFiles\\Class_5B_Caroline_10May2022.csv";

            // Testing tools

            //ReadData();
            //if (cellList.Count > 0)
            //{
            //    DisplayCellData();
            //}            
        }

        /*
        Method:     ReadData()
        Purpose:    Reads data from external CSV and it into a string array
        Inputs:     CSV data
        Outputs:    VOID
        */
        /// <summary>
        /// ReadData() reads data from CSV, slits at comma and saves to list
        /// </summary>
        private void ReadData()
        {
            // read external file
            try
            {
                // Read file using StreamReader. Reads file line by line
                using (StreamReader file = new StreamReader(currentFilePath))
                {
                    int counter = 0;
                    string line = "";

                    while ((line = file.ReadLine()) != null)
                    {
                        string[] lineArray = line.Split(',');

                        // Collects first few lines of CSV which include the teacher, class, room and date
                        if (counter < 4)
                        {
                            string title = lineArray[0];
                            string info = lineArray[1];

                            switch (counter)
                            {
                                case 0:
                                    teacher_Text.Text = lineArray[1];
                                    break;
                                case 1:
                                    class_Text.Text = lineArray[1];
                                    break;
                                case 2:
                                    room_Text.Text = lineArray[1];
                                    break;
                                case 3:
                                    date_Text.Text = lineArray[1];
                                    break;
                            }
                        }

                        // If the row does not have 4 cols, it's either student or desk data
                        else
                        {
                            // Collects each columns data and assigns it
                            int col = Int32.Parse(lineArray[0]);
                            int row = Int32.Parse(lineArray[1]);
                            string cellValue = lineArray[2];
                            string cellColour = "NA";
                            //Console.WriteLine(cellValue);

                            if (cellValue.Equals("BKGRND FILL"));
                            {
                                cellColour = lineArray[3];
                            }

                            // add new Cell instance to cellList
                            ClassRoom newRoom = new ClassRoom(row, col, cellValue, cellColour);
                            cellList.Add(newRoom);

                            // put all students into a seperate list
                            if (! cellValue.Equals("BKGRND FILL"))
                            {
                                if (! cellValue.Equals("Front Desk"))
                                {
                                    studentList.Add(newRoom);
                                }
                            }
                        } // end else

                        // Go to next row
                        counter++;
                    }

                    // Stop reading data
                    file.Close();
                }
            }

            // if not file is found, throw exception
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        /*
        Method:     DisplayCellData()
        Purpose:    Displays data into data grid view cells (student, teacher, class....)
        Inputs:     readData
        Outputs:    Cell data to data grid view
        */
        /// <summary>
        /// DisplayCellData() uses lists generated by ReadData() and uses for loop to insert data into cells
        /// </summary>
        private void DisplayCellData()
        {
            // set up cell style for cells that display background colour
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.LightBlue;
            style.ForeColor = Color.Black;

            // loop through the cellList to display content
            for (int i = 0; i < cellList.Count; i++)
            {
                // If data is Background fill, insert colour to cell
                if (cellList[i].FieldValue.Equals("BKGRND FILL"))
                {
                    classRoom_DataGridView.Rows[cellList[i].Row].Cells[cellList[i].Col].Style = style;
                }
                // Otherwise, it is student data
                else
                {
                    classRoom_DataGridView.Rows[cellList[i].Row].Cells[cellList[i].Col].Value = cellList[i].FieldValue;
                }
            }
        }

        /*
        Method:     ExtractCellData()
        Purpose:    Reads data from cells and puts it into lists for later use
        Inputs:     Cell data
        Outputs:    string of cell data
        */
        /// <summary>
        /// ExtractCellData() extracts data from all cells in data grid and creates new lists
        /// </summary>
        /// <returns>Returns fileContent string of all cell data</returns>
        private string ExtractCellData()
        {
            // Create new lists for updated data
            List<ClassRoom> newClassRoomList = new List<ClassRoom>();
            List<ClassRoom> newStudentList = new List<ClassRoom>();

            // Collect user data
            string teacher = teacher_Text.Text;
            string classRoom = class_Text.Text;
            string room = room_Text.Text;
            string date = date_Text.Text;

            // Prepares first 4 lines
            string fileContent = "Teacher:" + "," + teacher + ",," + "\r\n";
            fileContent += "Class:" + "," + classRoom + ",," + "\r\n";
            fileContent += "Room:" + "," + room + ",," + "\r\n";
            fileContent += "Date:" + "," + date + ",," + "\r\n";
 
            // Collects the desk and student data
            for (int row = 0; row < TOTAL_ROWS; row++)
            {
                for (int col = 0; col < TOTAL_COLS; col++)
                {
                    // Student data
                    if (classRoom_DataGridView.Rows[row].Cells[col].Value != null)
                    {
                        string cellValue = classRoom_DataGridView.Rows[row].Cells[col].Value.ToString();

                        fileContent += col + "," + row + "," + cellValue + "," + "\r\n";

                        newClassRoomList.Add(new ClassRoom(col, row, cellValue, "NA"));

                        // Excludes 'Front Desk"
                        if (!cellValue.Equals("Front Desk"))
                        {
                            newStudentList.Add(new ClassRoom(col, row, cellValue, "NA"));
                        }
                    }

                    // Desk data
                    else if(classRoom_DataGridView.Rows[row].Cells[col].HasStyle)
                    {
                        fileContent += col + "," + row + "," + "BKGRND FILL,blue\r\n";

                        newClassRoomList.Add(new ClassRoom(col, row, "BKGRND FILL", "blue"));
                    }
                }
            }

            // Updates old lists
            studentList = newStudentList;
            cellList = newClassRoomList;

            // Return fileContent in a string for other methods (saving...)
            return fileContent;

        }

        /*
        Method:     BinarySearch()
        Purpose:    Performs binary search function
        Inputs:     name to search from student list
        Outputs:    int that indicates if there was a match or not
        */
        /// <summary>
        /// BinarySearch() takes a student name as input, 
        /// sorts student list and uses a binary search to find mathcing student name
        /// </summary>
        /// <param name="searchName">Student name</param>
        /// <returns>Returns int which tells program if a match was found or not</returns>
        public int BinarySearch(string searchName)
        {
            // Update cell data
            ExtractCellData();

            // Sort student list so it can be searched
            studentList.Sort();

            // sets found index to -1 by default as -1 means there is not record found
            int foundIndex = -1;

            // Starts at index 0
            int firstIndex = 0;

            // Last index is -1 otherwise it throws out of bounds error
            int lastIndex = studentList.Count - 1;

            if (studentList.Count > 0)
            {
                //Console.WriteLine(studentList);
                // While there are still records remaining to search through
                while (firstIndex <= lastIndex)
                {
                    // Set middle index to first index + last index / 2
                    // This is done as first index + last index / 2 gives you the middle
                    int midIndex = (firstIndex + lastIndex) / 2;

                    // Starts search in the middle index name
                    string valueToCompare = studentList[midIndex].FieldValue;

                    // If the index is 0, it means a matching record is found, break loop
                    if (valueToCompare.CompareTo(searchName) == 0)
                    {
                        foundIndex = midIndex;
                        break;
                    }

                    // If record is greater than the searched name go down an index and search again
                    else if (valueToCompare.CompareTo(searchName) > 0)
                    {
                        lastIndex = midIndex - 1;
                    }

                    // If record is less than the searched name go up an index and search again
                    else
                    {
                        firstIndex = midIndex + 1;
                    }
                } // end while            
            } // end if

            else
            {
                MessageBox.Show("No student names were found, please check if there are any student names, otherwise code requires a fix");
            }
            
            // Returns the result of the found index
            return foundIndex;
        }

        /*
        Method:     validateData()
        Purpose:    Validates header text boxes (teacher, class, room, date)
        Inputs:     text fields
        Outputs:    true of false if it's valid or not
        */
        /// <summary>
        /// validateData() validates header text fields to ensure they are have data
        /// </summary>
        /// <returns>true if data is valid, false if not</returns>
        private Boolean validateData()
        {

            if (String.IsNullOrEmpty(teacher_Text.Text))
            {
                MessageBox.Show("ERROR - Teacher name required, please enter", "ERROR!");
                return false;
            }

            if (String.IsNullOrEmpty(class_Text.Text))
            {
                MessageBox.Show("ERROR - Class name required, please enter", "ERROR!");
                return false;
            }

            if (String.IsNullOrEmpty(room_Text.Text))
            {
                MessageBox.Show("ERROR - Room number required, please enter", "ERROR!");
                return false;
            }

            if (String.IsNullOrEmpty(date_Text.Text))
            {
                MessageBox.Show("ERROR - Date required, please enter", "ERROR!");
                return false;
            }

            return true;
        }

        /*
        Method:     find_Button_Click()
        Purpose:    Collects name and searches for a match in studentList
        Inputs:     student name
        Outputs:    Matched names
        */
        private void find_Button_Click(object sender, EventArgs e)
        {
            // If user enters nothing into find text box, throw error
            if (String.IsNullOrEmpty(search_Text.Text))
            {
                MessageBox.Show("ERROR - Name required for the search", "ERROR!");
                return;
            }


            // If user enters name to search
            else
            {
                // Read user data
                string nameToSearch = search_Text.Text;

                // Runs binary search on name
                int foundIndex = BinarySearch(nameToSearch);

                // If search returns -1, tell user there's no match
                if (foundIndex < 0)
                {
                    MessageBox.Show("No record found for " + nameToSearch, "NOT FOUND!");
                }

                // Displays all matches
                else
                {
                    currentRecord = foundIndex;
                    MessageBox.Show("Record found for " + nameToSearch + " at index " + currentRecord, "FOUND!");

                    // Display studentList in message box
                    string sortedStudents = "Student \t\tRow\tCol\n";
                    for (int i = 0; i < studentList.Count; i++)
                    {
                        sortedStudents += studentList[i].FieldValue + "\t\t" + studentList[i].Row + "\t" + studentList[i].Col;

                        if (foundIndex == i)
                        {
                            // adds an indicator for all matching student names for user to see
                            sortedStudents += "\t<-FOUND";
                        }

                        sortedStudents += "\n";
                    }

                    // Displays message box with all student names and indicates which match
                    MessageBox.Show(sortedStudents, "Student List - Search: " + nameToSearch);
                }
            }
        }

        /*
        Method:     saveRAF_Button_Click()
        Purpose:    Saves data in a .dat file format (binary file)
        Inputs:     Cell data
        Outputs:    .dat file
        */
        private void saveRAF_Button_Click(object sender, EventArgs e)
        {
            string fileName = "randomAccessFile.dat";

            string dataToWrite = ExtractCellData();

            if (validateData())
            {
                try
                {
                    // FileStream object 
                    // sets up file stream with target file name usually in .bin or .dat format
                    // FileMode.Append means putting the stream in append mode
                    // to write content which is added to any pre-existing content)
                    // FileMode.Create means over-writing the existing content 
                    // in the binary data file
                    FileStream fstream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                    //create a binary writer object
                    BinaryWriter bwStream = new BinaryWriter(fstream);
                    //set file position where to write data
                    //fstream.Position = pos * size;
                    //write data
                    bwStream.Write(dataToWrite);
                    //close objects
                    bwStream.Close();
                    fstream.Close();
                    MessageBox.Show("Data successfully written to random access file " + fileName, "SUCCESS - Random Access File written!");
                }

                catch (Exception exc)
                {
                    MessageBox.Show("Could not save data to " + currentFilePath, "FILE SAVE FAILED!");
                }
            }
        }

        /*
        Method:     exit_Button_Click()
        Purpose:    Exits program when user wishes
        Inputs:     VOID
        Outputs:    VOID
        */
        private void exit_Button_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        /*
        Method:     exitApp()
        Purpose:    Exits program when user wishes
        Inputs:     VOID
        Outputs:    VOID
        */
        private void exitApp()
        {
            // exit the application
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        /*
        Method:     sort_Button_Click()
        Purpose:    Sorts student list and displays sorted list as message box
        Inputs:     studentList
        Outputs:    Message box
        */
        private void sort_Button_Click(object sender, EventArgs e)
        {
            // Sort studentList 
            studentList.Sort();

            // Display studentList in message box
            string sortedStudents = "Student \t\tRow\tCol\n";
            for (int i = 0; i < studentList.Count; i++)
            {
                sortedStudents += studentList[i].FieldValue + "\t\t" + studentList[i].Row + "\t" + studentList[i].Col + "\n";
            }

            MessageBox.Show(sortedStudents, "Student List");
        }

        /*
        Method:     clear_Button_Click()
        Purpose:    Clears cell data
        Inputs:     VOID
        Outputs:    Blank text for headers and removes student names
        */
        private void clear_Button_Click(object sender, EventArgs e)
        {
            clearData();
        }

        /*
        Method:     clearData()
        Purpose:    Clears cell data
        Inputs:     VOID
        Outputs:    Blank text for headers and removes student names
        */
        private void clearData()
        {
            // Sets header text fields to blank
            teacher_Text.Text = "";
            class_Text.Text = "";
            room_Text.Text = "";
            date_Text.Text = "";

            // Clears cell data
            for (int row = 0; row < TOTAL_ROWS; row++)
            {
                for (int col = 0; col < TOTAL_COLS; col++)
                {
                    classRoom_DataGridView.Rows[row].Cells[col].Value = "";
                }
            }
        }

        /*
        Method:     saveChanges_Button_Click()
        Purpose:    Overrides current CSV with updated data
        Inputs:     cell data
        Outputs:    CSV
        */
        private void saveChanges_Button_Click(object sender, EventArgs e)
        {
            saveData();
        }

        /*
        Method:     saveData()
        Purpose:    Overrides current CSV with updated data
        Inputs:     cell data
        Outputs:    CSV
        */
        private void saveData()
        {
            // Collects cell and header data
            string fileContent = ExtractCellData();

            // Validates data
            if (validateData())
            {
                // Attempts to write data to CSV over previous CSV
                try
                {
                    File.WriteAllText(currentFilePath, fileContent);
                    MessageBox.Show("Class data saved to " + currentFilePath, "FILE SAVE SUCCESSFUL!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Could not save data to " + currentFilePath, "FILE SAVE FAILED!");
                    Console.WriteLine(exc.StackTrace);
                }
            }
        }

        /*
        Method:     open_Menu_Click()
        Purpose:    Gives the user the option to open a new CSV
        Inputs:     Chosen CSV
        Outputs:    Chosen CSV into cell and header
        */
        private void open_Menu_Click(object sender, EventArgs e)
        {
            try
            {
                studentList.Clear();
                cellList.Clear();

                // Opens window for user to search for data
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Starts in c: drive
                openFileDialog.InitialDirectory = "c:\\";

                // Looks for relevent files
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    currentFilePath = openFileDialog.FileName;

                    // reads then displays data
                    ReadData();
                    DisplayCellData();
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"The file could not be opened: '{e}'");
            }
        }

        /*
        Method:     saveAs_Menu_Click()
        Purpose:    Allows user to save data where they would like
        Inputs:     Cell and header data
        Outputs:    new file with data
        */
        private void saveAs_Menu_Click(object sender, EventArgs e)
        {
            // Collects cell data
            string fileContent = ExtractCellData();

            // Validates data
            if (validateData())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                // Simplify object initialization
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    currentFilePath = saveFileDialog.FileName;
                    try
                    {
                        File.WriteAllText(currentFilePath, fileContent);
                        MessageBox.Show("Class data saved to " + currentFilePath, "FILE SAVE AS SUCCESSFUL!");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Could not save data to " + currentFilePath, "FILE SAVE AS FAILED!");
                        Console.WriteLine(exc.StackTrace);
                    }
                }
            } // end if           
        } // end method


        /*
        Method:     save_Menu_Click()
        Purpose:    Overrides current CSV with updated data
        Inputs:     cell data
        Outputs:    CSV
        */
        private void save_Menu_Click(object sender, EventArgs e)
        {
            saveData();
        }

        /*
        Method:     exitMenu_Click()
        Purpose:    Exits program when user wishes
        Inputs:     VOID
        Outputs:    VOID
        */
        private void exitMenu_Click(object sender, EventArgs e)
        {
            exitApp();
        }
    } // end class
} // end namespace