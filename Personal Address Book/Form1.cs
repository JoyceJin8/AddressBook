using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace L2_Personal_Address_Book
{
    
    public partial class Form1 : Form
    {
        public struct PersonalInfo
        {
            public string FirstName;
            public string LastName;
            public string PhoneNum;
            public string Email;
            public int day;
            public int month;
            public int year;
        }

        PersonalInfo[] ContactArray = new PersonalInfo[100];  //creates array of 100
        int iCurrentIndex = 0;

        public Form1()
        {
            //set limit the date user can choose
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Today;
            dtpEditBday.MaxDate = DateTime.Today;
        }
        public void ClearContactInfo()
        {
            //clears contact information in search tab when other information is saved
            txtSearchFirstName.Clear();
            txtSearchLastName.Clear();
            txtSearchPhoneNum.Visible = false;
            txtSearchEmail.Visible = false;
            dtpShowBday.Visible = false;
        }
        public void ClearTodayBday()
        {
            //clears birthday listbox when other information is saved
            lbTodaysBday.Items.Clear();
        }

        public void ClearShowAllContact()
        {
            //clears information listbox when other information is saved
            lbShowAll.Items.Clear();
        }
        public void EnableTab()
        {
            //enables all the tabs after you finish editing your information
            tpAddContact.Enabled = true;
            tpShowContact.Enabled = true;
            tpShowBirthday.Enabled = true;
            tpDelete.Enabled = true;
        }
        public void ResetEdit()
        {
            //initial edit tab setting
            txtEditFirstName.ReadOnly = false;
            txtEditLastName.ReadOnly = false;
            btnEdit.Enabled = true;

            txtEditCell.ReadOnly = true;
            txtEditEmail.ReadOnly = true;
            dtpEditBday.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        public void EditClearTextbox()
        {
            //clears and resets all textboxes/dtp in edit tab
            txtEditCell.Clear();
            txtEditEmail.Clear();
            txtEditFirstName.Clear();
            txtEditLastName.Clear();
            dtpEditBday.Value = DateTime.Today;
        }
        public void ClearTextbox()
        {
            //resets information in add contact tab
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNum.Clear();
            dtpBirthday.Value = DateTime.Today;
        }

        public int FindPerson(string FirstName, string LastName)
        {
            //finds the index of the person
            if (iCurrentIndex==0)
            {
                return -1;
            }
                
            for (int i = 0; i < iCurrentIndex; i++)
                {
                    if (ContactArray[i].FirstName.ToLower() == FirstName.ToLower() && ContactArray[i].LastName.ToLower() == LastName.ToLower())
                    {
                        return i;
                    }
                }
                return -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName, LastName, PhoneNum, EmailAddress;
                int index;

                FirstName = txtFirstName.Text.Trim().ToLower();
                LastName = txtLastName.Text.Trim().ToLower();
                PhoneNum = txtPhoneNum.Text.Trim();
                EmailAddress = txtEmailAddress.Text.Trim();

                if (iCurrentIndex >= 100) // checks if array is full
                {
                    MessageBox.Show("Database is full!");
                    ClearTextbox(); //methods clears textboxes
                    return;
                }
                else
                {
                    if (FirstName == "" || LastName == "" || PhoneNum == "" || EmailAddress == "")  //check if any required boxes are empty
                    {
                        MessageBox.Show("Please provide ALL information");
                        ClearTextbox(); //methods clears textboxes
                        return;
                    }
                    else
                    {
                        ClearTodayBday();  //clears todays birthday listbox
                        ClearContactInfo(); //clear contact information
                        ClearShowAllContact(); //clear show all contact listbox

                        index = FindPerson(FirstName, LastName);  //finds index of person
                        if (index == -1) // Add the person if it is not already in the Address Book
                        {
                            //Format Name
                            FirstName = char.ToUpper(FirstName[0]) + FirstName.Substring(1);
                            LastName = char.ToUpper(LastName[0]) + LastName.Substring(1);
                            PhoneNum = PhoneNum.Replace(" ", ""); //remove spaces inbetween phone num

                            //saves all given information in array
                            ContactArray[iCurrentIndex].FirstName = FirstName;
                            ContactArray[iCurrentIndex].LastName = LastName;
                            ContactArray[iCurrentIndex].PhoneNum = PhoneNum;
                            ContactArray[iCurrentIndex].Email = EmailAddress;
                            ContactArray[iCurrentIndex].day = dtpBirthday.Value.Day;
                            ContactArray[iCurrentIndex].month = dtpBirthday.Value.Month;
                            ContactArray[iCurrentIndex].year = dtpBirthday.Value.Year;

                            iCurrentIndex = iCurrentIndex + 1;  //increases counter

                            MessageBox.Show(FirstName.ToString() + " " + LastName.ToString() + " was added to the Contact Organizer");
                            ClearTextbox();  //methods clears textboxes
                        }
                        else
                        {
                            MessageBox.Show("This person is already in the Contact Organizer!");
                            ClearTextbox(); //methods clears textboxes
                        }
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName, LastName;
                int index, day, month, year;

                FirstName = txtSearchFirstName.Text.Trim().ToLower();
                LastName = txtSearchLastName.Text.Trim().ToLower();

                if (FirstName == "" || LastName == "")  //checks if you fill all required boxes
                {
                    MessageBox.Show("Please provide both first and last names");
                    txtSearchFirstName.Clear();
                    txtSearchLastName.Clear();
                    return;
                }

                index = FindPerson(FirstName, LastName);  //finds index of person in array
                if (index == -1)  //runs if person is not in array
                {
                    MessageBox.Show("The person is not in the Contact Organizer");
                    //clears and hides information
                    txtSearchFirstName.Clear();
                    txtSearchLastName.Clear();
                    txtSearchPhoneNum.Visible = false;
                    txtSearchEmail.Visible = false;
                    dtpShowBday.Visible = false;
                }
                else  //runs if person is in array
                {
                    ClearTodayBday();  //clears todays birthday listbox
                    ClearShowAllContact(); //clear sow all contact listbox
                    dtpShowBday.Enabled = false; //disables dtp

                    day = ContactArray[index].day;
                    month = ContactArray[index].month;
                    year = ContactArray[index].year;

                    //shows information for the person
                    txtSearchPhoneNum.Visible = true;
                    txtSearchEmail.Visible = true;
                    dtpShowBday.Visible = true;
                    txtSearchPhoneNum.Text = (ContactArray[index].PhoneNum).ToString();
                    txtSearchEmail.Text = (ContactArray[index].Email).ToString();
                    dtpShowBday.Value = new DateTime(year, month, day);
                }   
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnShowTodaysBirthday_Click(object sender, EventArgs e)
        {
            ClearShowAllContact(); //clear show all contact listbox
            ClearShowAllContact(); //clears all contact from listbox                                
            
            var today = DateTime.Today; // Save today's date.

            // Go back to the year in which the person was born in case of a leap year
            

            if (iCurrentIndex == 0)  //if array is empty, show no bday
            {
                lbTodaysBday.Items.Add("There are no birthdays today");
                return;
            }
            else 
            {
                for (int i = 0; i < iCurrentIndex; i++)  //runs through the array
                {
                    if (ContactArray[i].day == DateTime.Now.Day && ContactArray[i].month == DateTime.Now.Month)  //adds to listbox if there is the birthday today
                    {
                        var age = today.Year - ContactArray[i].year; // Calculate the age.
                        if (ContactArray[i].month >= today.Month && ContactArray[i].day > today.Day)
                        {
                            age--;
                        }
                        lbTodaysBday.Items.Add(ContactArray[i].FirstName + " " + ContactArray[i].LastName + ": " + age + " years old");
                    }
                }

                if (lbTodaysBday.Items.Count == 0)  //if the listbox is empty, there are no bday today
                {
                    lbTodaysBday.Items.Add("There are no birthdays today");
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                dtpBirthday.MaxDate = DateTime.Today;
                string FirstName, LastName;
                int index, day, month, year;

                FirstName = txtEditFirstName.Text.Trim().ToLower();
                LastName = txtEditLastName.Text.Trim().ToLower();

                if (FirstName == "" || LastName == "")  //checks if user inputted required feilds
                {
                    MessageBox.Show("Please provide both first and last names");
                    txtEditFirstName.Clear();
                    txtEditLastName.Clear();
                    return;
                }

                index = FindPerson(FirstName, LastName);  //finds index of the person the user wants to edit

                if (index == -1)   //runs if person is not in the array
                {
                    MessageBox.Show("The person is not in the contact organizer!");
                    txtEditFirstName.Clear();
                    txtEditLastName.Clear();
                }
                else  //runs if person is in array
                {
                    //disables other tabs while you edit
                    tpAddContact.Enabled = false;
                    tpShowContact.Enabled = false;
                    tpShowBirthday.Enabled = false;
                    tpDelete.Enabled = false;

                    //disables option to change persons name while editing
                    txtEditFirstName.ReadOnly = true;
                    txtEditLastName.ReadOnly = true;
                    btnEdit.Enabled = false;

                    //enables textboxes so you can edit and buttons to save/cancel
                    txtEditCell.ReadOnly = false;
                    txtEditEmail.ReadOnly = false;
                    dtpEditBday.Enabled = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

                    //shows your information in the boxes
                    txtEditCell.Text = ContactArray[index].PhoneNum;
                    txtEditEmail.Text = ContactArray[index].Email;
                    day = ContactArray[index].day;
                    month = ContactArray[index].month;
                    year = ContactArray[index].year;
                    dtpEditBday.Value = new DateTime(year, month, day);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EditClearTextbox();  //clears textboxes
            ResetEdit();   //enable and disable textboxes
            EnableTab();   //enable all the tabs
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName, LastName;
                int index;

                FirstName = txtEditFirstName.Text.Trim().ToLower();
                LastName = txtEditLastName.Text.Trim().ToLower();

                if (txtEditCell.Text == "" || txtEditEmail.Text == "")  //checks if required boxes are filled
                {
                    MessageBox.Show("Please fill out all information");
                    return;
                }
                else
                {
                    index = FindPerson(FirstName, LastName);  //finds index of person

                    //saves changed information to array
                    ContactArray[index].PhoneNum = txtEditCell.Text;
                    ContactArray[index].Email = txtEditEmail.Text;
                    ContactArray[index].day = dtpEditBday.Value.Day;
                    ContactArray[index].month = dtpEditBday.Value.Month;
                    ContactArray[index].year = dtpEditBday.Value.Year;

                    MessageBox.Show("Your information has been saved and changed");

                    EnableTab();  //enable all the tabs
                    EditClearTextbox();   //clears the textboxes
                    ResetEdit();   //enable and disable the textboxes and button
                    ClearTodayBday();  //clears todays birthday listbox
                    ClearContactInfo(); //clear contact information
                    ClearShowAllContact(); //clear show all contact listbox
                }  
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName, LastName;
                int index;

                FirstName = txtDelFirstName.Text.Trim().ToLower();
                LastName = txtDelLastName.Text.Trim().ToLower();

                if (txtDelFirstName.Text == "" || txtDelLastName.Text == "")  //checks if required info is filled
                {
                    MessageBox.Show("Please fill in all information");
                    txtDelFirstName.Clear();
                    txtDelLastName.Clear();
                    return;
                }

                index = FindPerson(FirstName, LastName);  //finds index of person you want to delete
                if (index == -1)   //runs if person is not in array
                {
                    MessageBox.Show(FirstName + " " + LastName + " is not in the contact organizer!");
                    txtDelFirstName.Clear();
                    txtDelLastName.Clear();
                }
                else   //runs if person is found in the array
                {
                    //deletes specified person
                    for (int i = index + 1; i <= iCurrentIndex; i++)   //starting at the person, it moves the array down one person
                    {
                        ContactArray[i - 1] = ContactArray[i];
                    }
                    iCurrentIndex -= 1;

                    //Format Name
                    FirstName = char.ToUpper(FirstName[0]) + FirstName.Substring(1);
                    LastName = char.ToUpper(LastName[0]) + LastName.Substring(1);

                    MessageBox.Show(FirstName + " " + LastName + "'s contact has been deleted");
                    txtDelFirstName.Clear();
                    txtDelLastName.Clear();
                    ClearTodayBday();  //clears todays birthday listbox
                    ClearContactInfo(); //clear contact information
                    ClearShowAllContact(); //clear show all contact listbox
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                string FileName;
                sf.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";  //can only save as text file

                if (sf.ShowDialog() == DialogResult.OK)  //runs if ok button is clicked
                {
                    FileName = sf.FileName;
                    TextWriter tw = new StreamWriter(FileName); // create a writer and open the file

                    //runs through contact array and write out all information in text file
                    for (int i = 0; i < iCurrentIndex; i++)   
                    {
                        tw.Write(ContactArray[i].FirstName + ",");
                        tw.Write(ContactArray[i].LastName + ",");
                        tw.Write(ContactArray[i].PhoneNum + ",");
                        tw.Write(ContactArray[i].Email + ",");
                        tw.Write(ContactArray[i].day.ToString() + ",");
                        tw.Write(ContactArray[i].month.ToString() + ",");
                        tw.WriteLine(ContactArray[i].year.ToString());
                    }
                    tw.Close();  // close the stream
                }              
            }
            catch
            {
                MessageBox.Show("Error");
            }   
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                string FileName, strInput;
                string[] splittedInput;

                op.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";  //can only open text file
                if (op.ShowDialog() == DialogResult.OK)
                {
                    FileName = op.FileName;
                    TextReader tr = new StreamReader(FileName);  // create a reader and open the file
                    iCurrentIndex = 0;

                    //Reads from the file in a loop until it reaches the end of the file
                    while ((strInput = tr.ReadLine()) != null)
                    {
                        splittedInput = strInput.Split(',');  //split the input
                        ContactArray[iCurrentIndex].FirstName = splittedInput[0];
                        ContactArray[iCurrentIndex].LastName = splittedInput[1];
                        ContactArray[iCurrentIndex].PhoneNum = splittedInput[2];
                        ContactArray[iCurrentIndex].Email = splittedInput[3];
                        ContactArray[iCurrentIndex].day = Convert.ToInt32(splittedInput[4]);
                        ContactArray[iCurrentIndex].month = Convert.ToInt32(splittedInput[5]);
                        ContactArray[iCurrentIndex].year = Convert.ToInt32(splittedInput[6]);
                        iCurrentIndex += 1;
                    }
                    // close the stream
                    tr.Close();
                }        
            }
            catch
            {
                MessageBox.Show("Error! Please only open .txt file that you saved.");
            }
        }

        private void saveBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();  //allows you to save file
                string FileName;
                saveDialog.Filter = "binary files (*.cao)|*.cao|All files (*.*)|*.*";  //saves file as .cao
                if (saveDialog.ShowDialog() == DialogResult.OK)   //saves if OK is clicked
                {
                    FileName = saveDialog.FileName;
                    FileStream fs = new FileStream(FileName, FileMode.Create);
                    BinaryWriter binWriter = new BinaryWriter(fs);  //creates a new BinaryWriter

                    //writes all contact array into binary file
                    for (int i = 0; i < iCurrentIndex; i = i + 1)
                    {
                        binWriter.Write(ContactArray[i].FirstName);
                        binWriter.Write(ContactArray[i].LastName);
                        binWriter.Write(ContactArray[i].PhoneNum);
                        binWriter.Write(ContactArray[i].Email);
                        binWriter.Write(ContactArray[i].day);
                        binWriter.Write(ContactArray[i].month);
                        binWriter.Write(ContactArray[i].year);
                    }
                    binWriter.Flush(); //causes any buffered data to be written to the underlying device
                    binWriter.Close();  //closes reader
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void openBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                string FileName;
                long length;
                openDialog.Filter = "binary files (*.cao)|*.cao|All files (*.*)|*.*";  //shows only .cao file
                if (openDialog.ShowDialog() == DialogResult.OK)  //opens file is ok is clicked
                {
                    FileName = openDialog.FileName;  //saves file name you pick
                    FileStream fs = new FileStream(FileName, FileMode.Open);  
                    BinaryReader binReader = new BinaryReader(fs);  // It creates a new BinaryReader
                    iCurrentIndex = 0;
                    length = binReader.BaseStream.Length;

                    while (fs.Position < length)  //goes through information and saves it in contact array
                    {
                        ContactArray[iCurrentIndex].FirstName = binReader.ReadString();
                        ContactArray[iCurrentIndex].LastName = binReader.ReadString();
                        ContactArray[iCurrentIndex].PhoneNum = binReader.ReadString();
                        ContactArray[iCurrentIndex].Email = binReader.ReadString();
                        ContactArray[iCurrentIndex].day = binReader.ReadInt32();
                        ContactArray[iCurrentIndex].month = binReader.ReadInt32();
                        ContactArray[iCurrentIndex].year = binReader.ReadInt32();
                        iCurrentIndex = iCurrentIndex + 1;
                    }
                    binReader.Close();  //closes reader
                }
            }
            catch
            {
                MessageBox.Show("Error! Please only open .cao file");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                ClearShowAllContact(); //clear show all contact listbox
                ClearContactInfo();//clears information
                ClearTodayBday();//clears listbox

                if (iCurrentIndex == 0)  //if array is empty, show no bday
                {
                    lbTodaysBday.Items.Add("There are no people in your contact array");
                    return;
                }
                for (int i = 0; i < iCurrentIndex; i++) //show all information in contact array in list box
                {
                    lbShowAll.Items.Add(ContactArray[i].FirstName + " " + ContactArray[i].LastName + ":");
                    lbShowAll.Items.Add("Phone Number:" + ContactArray[i].PhoneNum + "  Email: " + ContactArray[i].Email + "  Birthday: " + ContactArray[i].day.ToString() + "/" + ContactArray[i].month.ToString() + "/" + ContactArray[i].year.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
