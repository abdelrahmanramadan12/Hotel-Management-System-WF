namespace HotelMng
{
    partial class frmReservation
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtBDYear = new TextBox();
            txtStreetAdd = new TextBox();
            txtApt = new TextBox();
            mkdTxtPhone = new MaskedTextBox();
            comboGender = new ComboBox();
            comboBDDay = new ComboBox();
            comboBDMonth = new ComboBox();
            txtZipCode = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnSubmit = new Button();
            btnFoodFrm = new Button();
            btnBillFrm = new Button();
            boxSupplySts = new CheckBox();
            boxCheckIn = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            dateArrival = new DateTimePicker();
            dateLeaving = new DateTimePicker();
            comboRoomNum = new ComboBox();
            comboFloor = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboRoomType = new ComboBox();
            comboNumOfGuests = new ComboBox();
            groupBox2 = new GroupBox();
            comboBoxAllReserv = new ComboBox();
            btnNewReserv = new Button();
            btnEditReserv = new Button();
            btnDeleteReserv = new Button();
            btnSaveReserv = new Button();
            tabControl1 = new TabControl();
            ReservationPage = new TabPage();
            tabPage2 = new TabPage();
            grdAllReservation = new DataGridView();
            tabPage1 = new TabPage();
            label13 = new Label();
            label12 = new Label();
            grdReservedRoom = new DataGridView();
            grdOccupiedRoom = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            ReservationPage.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdAllReservation).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdReservedRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdOccupiedRoom).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(24, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(137, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(177, 95);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 277);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email";
            txtEmail.Size = new Size(199, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtBDYear
            // 
            txtBDYear.Location = new Point(199, 160);
            txtBDYear.Name = "txtBDYear";
            txtBDYear.PlaceholderText = "Year";
            txtBDYear.Size = new Size(103, 27);
            txtBDYear.TabIndex = 5;
            // 
            // txtStreetAdd
            // 
            txtStreetAdd.Location = new Point(24, 331);
            txtStreetAdd.Name = "txtStreetAdd";
            txtStreetAdd.PlaceholderText = "Street Address";
            txtStreetAdd.Size = new Size(278, 27);
            txtStreetAdd.TabIndex = 6;
            // 
            // txtApt
            // 
            txtApt.Location = new Point(24, 379);
            txtApt.Name = "txtApt";
            txtApt.PlaceholderText = "Apt./Suite";
            txtApt.Size = new Size(125, 27);
            txtApt.TabIndex = 7;
            // 
            // mkdTxtPhone
            // 
            mkdTxtPhone.Location = new Point(155, 228);
            mkdTxtPhone.Mask = "(999) 000-0000";
            mkdTxtPhone.Name = "mkdTxtPhone";
            mkdTxtPhone.Size = new Size(155, 27);
            mkdTxtPhone.TabIndex = 8;
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female" });
            comboGender.Location = new Point(24, 228);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(107, 28);
            comboGender.TabIndex = 9;
            // 
            // comboBDDay
            // 
            comboBDDay.FormattingEnabled = true;
            comboBDDay.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBDDay.Location = new Point(121, 159);
            comboBDDay.Name = "comboBDDay";
            comboBDDay.Size = new Size(72, 28);
            comboBDDay.TabIndex = 10;
            comboBDDay.Text = "Day";
            // 
            // comboBDMonth
            // 
            comboBDMonth.FormattingEnabled = true;
            comboBDMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBDMonth.Location = new Point(24, 159);
            comboBDMonth.Name = "comboBDMonth";
            comboBDMonth.Size = new Size(81, 28);
            comboBDMonth.TabIndex = 11;
            comboBDMonth.Text = "Month";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(177, 422);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PlaceholderText = "Zip Code";
            txtZipCode.Size = new Size(125, 27);
            txtZipCode.TabIndex = 12;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(177, 378);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 13;
            // 
            // txtState
            // 
            txtState.Location = new Point(24, 421);
            txtState.Name = "txtState";
            txtState.PlaceholderText = "State";
            txtState.Size = new Size(125, 27);
            txtState.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 71);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 15;
            label1.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 136);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 17;
            label3.Text = "Birth Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 205);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 18;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 205);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 19;
            label5.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 280);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 20;
            label2.Text = "Email";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btnSubmit);
            groupBox1.Controls.Add(btnFoodFrm);
            groupBox1.Controls.Add(btnBillFrm);
            groupBox1.Controls.Add(boxSupplySts);
            groupBox1.Controls.Add(boxCheckIn);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateArrival);
            groupBox1.Controls.Add(dateLeaving);
            groupBox1.Controls.Add(comboRoomNum);
            groupBox1.Controls.Add(comboFloor);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboRoomType);
            groupBox1.Controls.Add(comboNumOfGuests);
            groupBox1.Location = new Point(342, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 503);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Green;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(46, 456);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(272, 28);
            btnSubmit.TabIndex = 34;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnFoodFrm
            // 
            btnFoodFrm.BackColor = SystemColors.ControlText;
            btnFoodFrm.BackgroundImageLayout = ImageLayout.None;
            btnFoodFrm.FlatStyle = FlatStyle.Popup;
            btnFoodFrm.ForeColor = SystemColors.ButtonHighlight;
            btnFoodFrm.Location = new Point(46, 332);
            btnFoodFrm.Name = "btnFoodFrm";
            btnFoodFrm.Size = new Size(272, 29);
            btnFoodFrm.TabIndex = 22;
            btnFoodFrm.Text = "Food";
            btnFoodFrm.UseVisualStyleBackColor = false;
            btnFoodFrm.Click += btnFoodFrm_Click;
            // 
            // btnBillFrm
            // 
            btnBillFrm.BackColor = SystemColors.ControlText;
            btnBillFrm.FlatStyle = FlatStyle.Popup;
            btnBillFrm.ForeColor = SystemColors.ButtonHighlight;
            btnBillFrm.Location = new Point(46, 406);
            btnBillFrm.Name = "btnBillFrm";
            btnBillFrm.Size = new Size(272, 29);
            btnBillFrm.TabIndex = 23;
            btnBillFrm.Text = "Finalize bill";
            btnBillFrm.UseVisualStyleBackColor = false;
            btnBillFrm.Click += btnBillFrm_Click;
            // 
            // boxSupplySts
            // 
            boxSupplySts.AutoSize = true;
            boxSupplySts.Location = new Point(198, 367);
            boxSupplySts.Name = "boxSupplySts";
            boxSupplySts.Size = new Size(120, 24);
            boxSupplySts.TabIndex = 24;
            boxSupplySts.Text = "Supply Status ";
            boxSupplySts.UseVisualStyleBackColor = true;
            // 
            // boxCheckIn
            // 
            boxCheckIn.AutoSize = true;
            boxCheckIn.Location = new Point(46, 367);
            boxCheckIn.Name = "boxCheckIn";
            boxCheckIn.Size = new Size(86, 24);
            boxCheckIn.TabIndex = 25;
            boxCheckIn.Text = "Check In";
            boxCheckIn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(46, 254);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 33;
            label11.Text = "Deperture [Date]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 185);
            label10.Name = "label10";
            label10.Size = new Size(76, 20);
            label10.TabIndex = 32;
            label10.Text = "Entry Date";
            // 
            // dateArrival
            // 
            dateArrival.Location = new Point(46, 224);
            dateArrival.Name = "dateArrival";
            dateArrival.Size = new Size(272, 27);
            dateArrival.TabIndex = 31;
            // 
            // dateLeaving
            // 
            dateLeaving.Location = new Point(46, 277);
            dateLeaving.Name = "dateLeaving";
            dateLeaving.Size = new Size(272, 27);
            dateLeaving.TabIndex = 30;
            // 
            // comboRoomNum
            // 
            comboRoomNum.FormattingEnabled = true;
            comboRoomNum.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" });
            comboRoomNum.Location = new Point(177, 154);
            comboRoomNum.Name = "comboRoomNum";
            comboRoomNum.Size = new Size(128, 28);
            comboRoomNum.TabIndex = 22;
            // 
            // comboFloor
            // 
            comboFloor.FormattingEnabled = true;
            comboFloor.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboFloor.Location = new Point(46, 154);
            comboFloor.Name = "comboFloor";
            comboFloor.Size = new Size(125, 28);
            comboFloor.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 131);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 29;
            label9.Text = "Floor";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(177, 131);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 28;
            label8.Text = "Room #";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(177, 57);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 27;
            label7.Text = "Room Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 57);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 26;
            label6.Text = "# Of Guests";
            // 
            // comboRoomType
            // 
            comboRoomType.FormattingEnabled = true;
            comboRoomType.Items.AddRange(new object[] { "Single", "Double", "Twin", "Duplex", "Suite" });
            comboRoomType.Location = new Point(177, 80);
            comboRoomType.Name = "comboRoomType";
            comboRoomType.Size = new Size(128, 28);
            comboRoomType.TabIndex = 24;
            // 
            // comboNumOfGuests
            // 
            comboNumOfGuests.FormattingEnabled = true;
            comboNumOfGuests.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboNumOfGuests.Location = new Point(46, 81);
            comboNumOfGuests.Name = "comboNumOfGuests";
            comboNumOfGuests.Size = new Size(125, 28);
            comboNumOfGuests.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.BackColor = SystemColors.MenuHighlight;
            groupBox2.Controls.Add(comboBoxAllReserv);
            groupBox2.Controls.Add(btnNewReserv);
            groupBox2.Controls.Add(btnEditReserv);
            groupBox2.Controls.Add(btnDeleteReserv);
            groupBox2.Controls.Add(btnSaveReserv);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(706, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(257, 503);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            // 
            // comboBoxAllReserv
            // 
            comboBoxAllReserv.FormattingEnabled = true;
            comboBoxAllReserv.Location = new Point(41, 26);
            comboBoxAllReserv.Name = "comboBoxAllReserv";
            comboBoxAllReserv.Size = new Size(183, 28);
            comboBoxAllReserv.TabIndex = 4;
            // 
            // btnNewReserv
            // 
            btnNewReserv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewReserv.ForeColor = Color.FromArgb(0, 0, 192);
            btnNewReserv.Location = new Point(41, 421);
            btnNewReserv.Name = "btnNewReserv";
            btnNewReserv.Size = new Size(183, 29);
            btnNewReserv.TabIndex = 3;
            btnNewReserv.Text = "New Reservation";
            btnNewReserv.UseVisualStyleBackColor = true;
            btnNewReserv.Click += btnNewReserv_Click;
            // 
            // btnEditReserv
            // 
            btnEditReserv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditReserv.ForeColor = Color.FromArgb(0, 0, 192);
            btnEditReserv.Location = new Point(41, 386);
            btnEditReserv.Name = "btnEditReserv";
            btnEditReserv.Size = new Size(183, 29);
            btnEditReserv.TabIndex = 2;
            btnEditReserv.Text = "Edit Existing Reservation";
            btnEditReserv.UseVisualStyleBackColor = true;
            btnEditReserv.Click += btnEditReserv_Click;
            // 
            // btnDeleteReserv
            // 
            btnDeleteReserv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteReserv.ForeColor = Color.Red;
            btnDeleteReserv.Location = new Point(41, 351);
            btnDeleteReserv.Name = "btnDeleteReserv";
            btnDeleteReserv.Size = new Size(183, 29);
            btnDeleteReserv.TabIndex = 1;
            btnDeleteReserv.Text = "Delete";
            btnDeleteReserv.UseVisualStyleBackColor = true;
            btnDeleteReserv.Click += btnDeleteReserv_Click;
            // 
            // btnSaveReserv
            // 
            btnSaveReserv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveReserv.ForeColor = Color.FromArgb(0, 192, 0);
            btnSaveReserv.Location = new Point(41, 316);
            btnSaveReserv.Name = "btnSaveReserv";
            btnSaveReserv.Size = new Size(183, 29);
            btnSaveReserv.TabIndex = 0;
            btnSaveReserv.Text = "Save";
            btnSaveReserv.UseVisualStyleBackColor = true;
            btnSaveReserv.Click += btnSaveReserv_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(ReservationPage);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(2, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(977, 556);
            tabControl1.TabIndex = 35;
            // 
            // ReservationPage
            // 
            ReservationPage.Controls.Add(txtLastName);
            ReservationPage.Controls.Add(groupBox1);
            ReservationPage.Controls.Add(groupBox2);
            ReservationPage.Controls.Add(txtFirstName);
            ReservationPage.Controls.Add(label2);
            ReservationPage.Controls.Add(txtEmail);
            ReservationPage.Controls.Add(label5);
            ReservationPage.Controls.Add(txtBDYear);
            ReservationPage.Controls.Add(label4);
            ReservationPage.Controls.Add(txtStreetAdd);
            ReservationPage.Controls.Add(label3);
            ReservationPage.Controls.Add(txtApt);
            ReservationPage.Controls.Add(label1);
            ReservationPage.Controls.Add(mkdTxtPhone);
            ReservationPage.Controls.Add(txtState);
            ReservationPage.Controls.Add(comboGender);
            ReservationPage.Controls.Add(txtCity);
            ReservationPage.Controls.Add(comboBDDay);
            ReservationPage.Controls.Add(txtZipCode);
            ReservationPage.Controls.Add(comboBDMonth);
            ReservationPage.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ReservationPage.ForeColor = SystemColors.ActiveCaptionText;
            ReservationPage.Location = new Point(4, 29);
            ReservationPage.Name = "ReservationPage";
            ReservationPage.Padding = new Padding(3);
            ReservationPage.Size = new Size(969, 523);
            ReservationPage.TabIndex = 0;
            ReservationPage.Text = "Reservation";
            ReservationPage.UseVisualStyleBackColor = true;
            ReservationPage.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grdAllReservation);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(969, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Reservation Adv.";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdAllReservation
            // 
            grdAllReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdAllReservation.BackgroundColor = Color.Maroon;
            grdAllReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdAllReservation.Dock = DockStyle.Fill;
            grdAllReservation.GridColor = Color.OrangeRed;
            grdAllReservation.Location = new Point(3, 3);
            grdAllReservation.Name = "grdAllReservation";
            grdAllReservation.RowHeadersWidth = 51;
            grdAllReservation.Size = new Size(963, 517);
            grdAllReservation.TabIndex = 0;
            grdAllReservation.CellContentClick += grdAllReservation_CellContentClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(grdReservedRoom);
            tabPage1.Controls.Add(grdOccupiedRoom);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(969, 523);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Room Availability";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(192, 0, 0);
            label13.Location = new Point(634, 18);
            label13.Name = "label13";
            label13.Size = new Size(196, 24);
            label13.TabIndex = 3;
            label13.Text = "Reserved Rooms";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(192, 0, 0);
            label12.Location = new Point(148, 18);
            label12.Name = "label12";
            label12.Size = new Size(193, 24);
            label12.TabIndex = 2;
            label12.Text = "Occupied Rooms";
            // 
            // grdReservedRoom
            // 
            grdReservedRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdReservedRoom.Location = new Point(489, 51);
            grdReservedRoom.Name = "grdReservedRoom";
            grdReservedRoom.RowHeadersWidth = 51;
            grdReservedRoom.Size = new Size(477, 469);
            grdReservedRoom.TabIndex = 1;
            // 
            // grdOccupiedRoom
            // 
            grdOccupiedRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOccupiedRoom.Location = new Point(3, 51);
            grdOccupiedRoom.Name = "grdOccupiedRoom";
            grdOccupiedRoom.RowHeadersWidth = 51;
            grdOccupiedRoom.Size = new Size(483, 469);
            grdOccupiedRoom.TabIndex = 0;
            // 
            // frmReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(974, 548);
            Controls.Add(tabControl1);
            Name = "frmReservation";
            Text = "frmReservation";
            Load += frmReservation_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ReservationPage.ResumeLayout(false);
            ReservationPage.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdAllReservation).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdReservedRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdOccupiedRoom).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtGender;
        private TextBox txtEmail;
        private TextBox txtBDYear;
        private TextBox txtStreetAdd;
        private TextBox txtApt;
        private MaskedTextBox mkdTxtPhone;
        private ComboBox comboGender;
        private ComboBox comboBDDay;
        private ComboBox comboBDMonth;
        private TextBox txtZipCode;
        private TextBox txtCity;
        private TextBox txtState;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox comboRoomType;
        private ComboBox comboNumOfGuests;
        private ComboBox comboRoomNum;
        private ComboBox comboFloor;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dateArrival;
        private DateTimePicker dateLeaving;
        private Label label11;
        private Label label10;
        private CheckBox boxCheckIn;
        private Button btnFoodFrm;
        private Button btnBillFrm;
        private CheckBox boxSupplySts;
        private GroupBox groupBox2;
        private ComboBox comboBoxAllReserv;
        private Button btnNewReserv;
        private Button btnEditReserv;
        private Button btnDeleteReserv;
        private Button btnSaveReserv;
        private Button btnSubmit;
        private TabControl tabControl1;
        private TabPage ReservationPage;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private DataGridView grdAllReservation;
        private DataGridView grdReservedRoom;
        private DataGridView grdOccupiedRoom;
        private Label label13;
        private Label label12;
    }
}