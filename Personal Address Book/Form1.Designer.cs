namespace L2_Personal_Address_Book
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAdressBook = new System.Windows.Forms.TabControl();
            this.tpAddContact = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpShowContact = new System.Windows.Forms.TabPage();
            this.dtpShowBday = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.txtSearchPhoneNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tpShowBirthday = new System.Windows.Forms.TabPage();
            this.lbTodaysBday = new System.Windows.Forms.ListBox();
            this.btnShowTodaysBirthday = new System.Windows.Forms.Button();
            this.tpEditInfo = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtpEditBday = new System.Windows.Forms.DateTimePicker();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.txtEditCell = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tpDelete = new System.Windows.Forms.TabPage();
            this.txtDelLastName = new System.Windows.Forms.TextBox();
            this.txtDelFirstName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tpShowAll = new System.Windows.Forms.TabPage();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lbShowAll = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcAdressBook.SuspendLayout();
            this.tpAddContact.SuspendLayout();
            this.tpShowContact.SuspendLayout();
            this.tpShowBirthday.SuspendLayout();
            this.tpEditInfo.SuspendLayout();
            this.tpDelete.SuspendLayout();
            this.tpShowAll.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdressBook
            // 
            this.tcAdressBook.Controls.Add(this.tpAddContact);
            this.tcAdressBook.Controls.Add(this.tpShowContact);
            this.tcAdressBook.Controls.Add(this.tpShowBirthday);
            this.tcAdressBook.Controls.Add(this.tpEditInfo);
            this.tcAdressBook.Controls.Add(this.tpDelete);
            this.tcAdressBook.Controls.Add(this.tpShowAll);
            this.tcAdressBook.Location = new System.Drawing.Point(34, 78);
            this.tcAdressBook.Name = "tcAdressBook";
            this.tcAdressBook.SelectedIndex = 0;
            this.tcAdressBook.Size = new System.Drawing.Size(750, 400);
            this.tcAdressBook.TabIndex = 0;
            this.tcAdressBook.TabStop = false;
            // 
            // tpAddContact
            // 
            this.tpAddContact.Controls.Add(this.btnAdd);
            this.tpAddContact.Controls.Add(this.dtpBirthday);
            this.tpAddContact.Controls.Add(this.txtEmailAddress);
            this.tpAddContact.Controls.Add(this.txtPhoneNum);
            this.tpAddContact.Controls.Add(this.label5);
            this.tpAddContact.Controls.Add(this.label4);
            this.tpAddContact.Controls.Add(this.label3);
            this.tpAddContact.Controls.Add(this.txtLastName);
            this.tpAddContact.Controls.Add(this.txtFirstName);
            this.tpAddContact.Controls.Add(this.label2);
            this.tpAddContact.Controls.Add(this.label1);
            this.tpAddContact.Location = new System.Drawing.Point(4, 29);
            this.tpAddContact.Name = "tpAddContact";
            this.tpAddContact.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddContact.Size = new System.Drawing.Size(742, 367);
            this.tpAddContact.TabIndex = 0;
            this.tpAddContact.Text = "Add Contact";
            this.tpAddContact.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(230, 211);
            this.dtpBirthday.MaxDate = new System.DateTime(2030, 7, 11, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1871, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(404, 26);
            this.dtpBirthday.TabIndex = 4;
            this.dtpBirthday.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(230, 156);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(404, 26);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(230, 102);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(404, 26);
            this.txtPhoneNum.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cell Phone Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(469, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 26);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(177, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 26);
            this.txtFirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tpShowContact
            // 
            this.tpShowContact.Controls.Add(this.dtpShowBday);
            this.tpShowContact.Controls.Add(this.label10);
            this.tpShowContact.Controls.Add(this.txtSearchEmail);
            this.tpShowContact.Controls.Add(this.txtSearchPhoneNum);
            this.tpShowContact.Controls.Add(this.label8);
            this.tpShowContact.Controls.Add(this.label9);
            this.tpShowContact.Controls.Add(this.txtSearchLastName);
            this.tpShowContact.Controls.Add(this.txtSearchFirstName);
            this.tpShowContact.Controls.Add(this.label6);
            this.tpShowContact.Controls.Add(this.label7);
            this.tpShowContact.Controls.Add(this.btnSearch);
            this.tpShowContact.Location = new System.Drawing.Point(4, 29);
            this.tpShowContact.Name = "tpShowContact";
            this.tpShowContact.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowContact.Size = new System.Drawing.Size(742, 367);
            this.tpShowContact.TabIndex = 1;
            this.tpShowContact.Text = "Show Contact Info";
            this.tpShowContact.UseVisualStyleBackColor = true;
            // 
            // dtpShowBday
            // 
            this.dtpShowBday.Location = new System.Drawing.Point(282, 289);
            this.dtpShowBday.Name = "dtpShowBday";
            this.dtpShowBday.Size = new System.Drawing.Size(340, 26);
            this.dtpShowBday.TabIndex = 5;
            this.dtpShowBday.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Birthday";
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(282, 233);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.ReadOnly = true;
            this.txtSearchEmail.Size = new System.Drawing.Size(340, 26);
            this.txtSearchEmail.TabIndex = 4;
            this.txtSearchEmail.TabStop = false;
            this.txtSearchEmail.Visible = false;
            // 
            // txtSearchPhoneNum
            // 
            this.txtSearchPhoneNum.Location = new System.Drawing.Point(282, 179);
            this.txtSearchPhoneNum.Name = "txtSearchPhoneNum";
            this.txtSearchPhoneNum.ReadOnly = true;
            this.txtSearchPhoneNum.Size = new System.Drawing.Size(340, 26);
            this.txtSearchPhoneNum.TabIndex = 3;
            this.txtSearchPhoneNum.TabStop = false;
            this.txtSearchPhoneNum.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cell Phone Number";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(493, 40);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(129, 26);
            this.txtSearchLastName.TabIndex = 1;
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(229, 40);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(139, 26);
            this.txtSearchFirstName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "First Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(135, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(487, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tpShowBirthday
            // 
            this.tpShowBirthday.Controls.Add(this.lbTodaysBday);
            this.tpShowBirthday.Controls.Add(this.btnShowTodaysBirthday);
            this.tpShowBirthday.Location = new System.Drawing.Point(4, 29);
            this.tpShowBirthday.Name = "tpShowBirthday";
            this.tpShowBirthday.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowBirthday.Size = new System.Drawing.Size(742, 367);
            this.tpShowBirthday.TabIndex = 2;
            this.tpShowBirthday.Text = "Show Today\'s Bday";
            this.tpShowBirthday.UseVisualStyleBackColor = true;
            // 
            // lbTodaysBday
            // 
            this.lbTodaysBday.FormattingEnabled = true;
            this.lbTodaysBday.ItemHeight = 20;
            this.lbTodaysBday.Location = new System.Drawing.Point(108, 95);
            this.lbTodaysBday.Name = "lbTodaysBday";
            this.lbTodaysBday.Size = new System.Drawing.Size(519, 244);
            this.lbTodaysBday.TabIndex = 1;
            this.lbTodaysBday.TabStop = false;
            // 
            // btnShowTodaysBirthday
            // 
            this.btnShowTodaysBirthday.Location = new System.Drawing.Point(108, 25);
            this.btnShowTodaysBirthday.Name = "btnShowTodaysBirthday";
            this.btnShowTodaysBirthday.Size = new System.Drawing.Size(519, 56);
            this.btnShowTodaysBirthday.TabIndex = 0;
            this.btnShowTodaysBirthday.Text = "Show Today\'s Birthday";
            this.btnShowTodaysBirthday.UseVisualStyleBackColor = true;
            this.btnShowTodaysBirthday.Click += new System.EventHandler(this.btnShowTodaysBirthday_Click);
            // 
            // tpEditInfo
            // 
            this.tpEditInfo.Controls.Add(this.btnSave);
            this.tpEditInfo.Controls.Add(this.label17);
            this.tpEditInfo.Controls.Add(this.label16);
            this.tpEditInfo.Controls.Add(this.btnCancel);
            this.tpEditInfo.Controls.Add(this.btnEdit);
            this.tpEditInfo.Controls.Add(this.dtpEditBday);
            this.tpEditInfo.Controls.Add(this.txtEditEmail);
            this.tpEditInfo.Controls.Add(this.txtEditCell);
            this.tpEditInfo.Controls.Add(this.label11);
            this.tpEditInfo.Controls.Add(this.label12);
            this.tpEditInfo.Controls.Add(this.label13);
            this.tpEditInfo.Controls.Add(this.txtEditLastName);
            this.tpEditInfo.Controls.Add(this.txtEditFirstName);
            this.tpEditInfo.Controls.Add(this.label14);
            this.tpEditInfo.Controls.Add(this.label15);
            this.tpEditInfo.Location = new System.Drawing.Point(4, 29);
            this.tpEditInfo.Name = "tpEditInfo";
            this.tpEditInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditInfo.Size = new System.Drawing.Size(742, 367);
            this.tpEditInfo.TabIndex = 3;
            this.tpEditInfo.Text = "Edit Information";
            this.tpEditInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(109, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(69, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(541, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Edit________________________________________________________";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(69, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(540, 20);
            this.label16.TabIndex = 23;
            this.label16.Text = "Input First and Last Name to Edit_________________________________";
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(381, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(529, 53);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(151, 38);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Info";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpEditBday
            // 
            this.dtpEditBday.Enabled = false;
            this.dtpEditBday.Location = new System.Drawing.Point(270, 246);
            this.dtpEditBday.MaxDate = new System.DateTime(2109, 11, 21, 0, 0, 0, 0);
            this.dtpEditBday.Name = "dtpEditBday";
            this.dtpEditBday.Size = new System.Drawing.Size(340, 26);
            this.dtpEditBday.TabIndex = 5;
            this.dtpEditBday.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(270, 191);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.ReadOnly = true;
            this.txtEditEmail.Size = new System.Drawing.Size(340, 26);
            this.txtEditEmail.TabIndex = 4;
            // 
            // txtEditCell
            // 
            this.txtEditCell.Location = new System.Drawing.Point(270, 137);
            this.txtEditCell.Name = "txtEditCell";
            this.txtEditCell.ReadOnly = true;
            this.txtEditCell.Size = new System.Drawing.Size(340, 26);
            this.txtEditCell.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(119, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Birthday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(119, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Email Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(119, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Cell Phone Number";
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Location = new System.Drawing.Point(373, 59);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(129, 26);
            this.txtEditLastName.TabIndex = 1;
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Location = new System.Drawing.Point(123, 62);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(139, 26);
            this.txtEditFirstName.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Last Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "First Name";
            // 
            // tpDelete
            // 
            this.tpDelete.Controls.Add(this.txtDelLastName);
            this.tpDelete.Controls.Add(this.txtDelFirstName);
            this.tpDelete.Controls.Add(this.label18);
            this.tpDelete.Controls.Add(this.label19);
            this.tpDelete.Controls.Add(this.btnDelete);
            this.tpDelete.Location = new System.Drawing.Point(4, 29);
            this.tpDelete.Name = "tpDelete";
            this.tpDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tpDelete.Size = new System.Drawing.Size(742, 367);
            this.tpDelete.TabIndex = 4;
            this.tpDelete.Text = "Delete";
            this.tpDelete.UseVisualStyleBackColor = true;
            // 
            // txtDelLastName
            // 
            this.txtDelLastName.Location = new System.Drawing.Point(463, 78);
            this.txtDelLastName.Name = "txtDelLastName";
            this.txtDelLastName.Size = new System.Drawing.Size(188, 26);
            this.txtDelLastName.TabIndex = 1;
            // 
            // txtDelFirstName
            // 
            this.txtDelFirstName.Location = new System.Drawing.Point(152, 78);
            this.txtDelFirstName.Name = "txtDelFirstName";
            this.txtDelFirstName.Size = new System.Drawing.Size(176, 26);
            this.txtDelFirstName.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(356, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "Last Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(60, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 20);
            this.label19.TabIndex = 9;
            this.label19.Text = "First Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(64, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(587, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tpShowAll
            // 
            this.tpShowAll.Controls.Add(this.btnShowAll);
            this.tpShowAll.Controls.Add(this.lbShowAll);
            this.tpShowAll.Location = new System.Drawing.Point(4, 29);
            this.tpShowAll.Name = "tpShowAll";
            this.tpShowAll.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowAll.Size = new System.Drawing.Size(742, 367);
            this.tpShowAll.TabIndex = 5;
            this.tpShowAll.Text = "Show All Contact";
            this.tpShowAll.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(25, 26);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(675, 37);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lbShowAll
            // 
            this.lbShowAll.FormattingEnabled = true;
            this.lbShowAll.ItemHeight = 20;
            this.lbShowAll.Location = new System.Drawing.Point(25, 87);
            this.lbShowAll.Name = "lbShowAll";
            this.lbShowAll.Size = new System.Drawing.Size(675, 244);
            this.lbShowAll.TabIndex = 1;
            this.lbShowAll.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.saveBinaryToolStripMenuItem,
            this.openBinaryToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.openToolStripMenuItem.Text = "Save Text";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.closeToolStripMenuItem.Text = "Open Text";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveBinaryToolStripMenuItem
            // 
            this.saveBinaryToolStripMenuItem.Name = "saveBinaryToolStripMenuItem";
            this.saveBinaryToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.saveBinaryToolStripMenuItem.Text = "Save Binary";
            this.saveBinaryToolStripMenuItem.Click += new System.EventHandler(this.saveBinaryToolStripMenuItem_Click);
            // 
            // openBinaryToolStripMenuItem
            // 
            this.openBinaryToolStripMenuItem.Name = "openBinaryToolStripMenuItem";
            this.openBinaryToolStripMenuItem.Size = new System.Drawing.Size(211, 34);
            this.openBinaryToolStripMenuItem.Text = "Open Binary";
            this.openBinaryToolStripMenuItem.Click += new System.EventHandler(this.openBinaryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 512);
            this.Controls.Add(this.tcAdressBook);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Personal Address Book";
            this.tcAdressBook.ResumeLayout(false);
            this.tpAddContact.ResumeLayout(false);
            this.tpAddContact.PerformLayout();
            this.tpShowContact.ResumeLayout(false);
            this.tpShowContact.PerformLayout();
            this.tpShowBirthday.ResumeLayout(false);
            this.tpEditInfo.ResumeLayout(false);
            this.tpEditInfo.PerformLayout();
            this.tpDelete.ResumeLayout(false);
            this.tpDelete.PerformLayout();
            this.tpShowAll.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdressBook;
        private System.Windows.Forms.TabPage tpAddContact;
        private System.Windows.Forms.TabPage tpShowContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.TextBox txtSearchPhoneNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpShowBday;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tpShowBirthday;
        private System.Windows.Forms.ListBox lbTodaysBday;
        private System.Windows.Forms.Button btnShowTodaysBirthday;
        private System.Windows.Forms.TabPage tpEditInfo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dtpEditBday;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditCell;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tpDelete;
        private System.Windows.Forms.TextBox txtDelLastName;
        private System.Windows.Forms.TextBox txtDelFirstName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBinaryToolStripMenuItem;
        private System.Windows.Forms.TabPage tpShowAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ListBox lbShowAll;
    }
}

