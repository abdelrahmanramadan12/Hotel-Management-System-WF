namespace HotelMng
{
    partial class frmKitchen
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox2 = new GroupBox();
            btnChangeFood = new Button();
            BoxFoodStatus = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numUpDownDinner = new NumericUpDown();
            numUpDownLunch = new NumericUpDown();
            numUpDownBreakfast = new NumericUpDown();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblName = new Label();
            maskedPhoneNum = new MaskedTextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtRoomNum = new TextBox();
            txtRoomType = new TextBox();
            txtFloorNum = new TextBox();
            Reservations = new ListBox();
            tabPage2 = new TabPage();
            grdKitchenView = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownDinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownLunch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownBreakfast).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdKitchenView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1020, 620);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(Reservations);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1012, 587);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "TODO";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(btnChangeFood);
            groupBox2.Controls.Add(BoxFoodStatus);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numUpDownDinner);
            groupBox2.Controls.Add(numUpDownLunch);
            groupBox2.Controls.Add(numUpDownBreakfast);
            groupBox2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(415, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 440);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // btnChangeFood
            // 
            btnChangeFood.BackColor = Color.FromArgb(192, 64, 0);
            btnChangeFood.FlatStyle = FlatStyle.Popup;
            btnChangeFood.Font = new Font("Magneto", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChangeFood.ForeColor = SystemColors.ButtonHighlight;
            btnChangeFood.Location = new Point(6, 363);
            btnChangeFood.Name = "btnChangeFood";
            btnChangeFood.Size = new Size(319, 29);
            btnChangeFood.TabIndex = 11;
            btnChangeFood.Text = "Change Food Selection";
            btnChangeFood.UseVisualStyleBackColor = false;
            btnChangeFood.Click += btnChangeFood_Click;
            // 
            // BoxFoodStatus
            // 
            BoxFoodStatus.AutoSize = true;
            BoxFoodStatus.Location = new Point(106, 255);
            BoxFoodStatus.Name = "BoxFoodStatus";
            BoxFoodStatus.Size = new Size(120, 26);
            BoxFoodStatus.TabIndex = 18;
            BoxFoodStatus.Text = "Food Status ";
            BoxFoodStatus.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 173);
            label7.Name = "label7";
            label7.Size = new Size(98, 22);
            label7.TabIndex = 14;
            label7.Text = "Dinner [QTY]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 61);
            label6.Name = "label6";
            label6.Size = new Size(96, 22);
            label6.TabIndex = 13;
            label6.Text = "Lunch [QTY]";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 61);
            label5.Name = "label5";
            label5.Size = new Size(118, 22);
            label5.TabIndex = 12;
            label5.Text = "Breakfast [QTY]";
            // 
            // numUpDownDinner
            // 
            numUpDownDinner.Location = new Point(175, 171);
            numUpDownDinner.Name = "numUpDownDinner";
            numUpDownDinner.Size = new Size(150, 27);
            numUpDownDinner.TabIndex = 11;
            // 
            // numUpDownLunch
            // 
            numUpDownLunch.Location = new Point(175, 88);
            numUpDownLunch.Name = "numUpDownLunch";
            numUpDownLunch.Size = new Size(150, 27);
            numUpDownLunch.TabIndex = 10;
            // 
            // numUpDownBreakfast
            // 
            numUpDownBreakfast.Location = new Point(6, 88);
            numUpDownBreakfast.Name = "numUpDownBreakfast";
            numUpDownBreakfast.Size = new Size(150, 27);
            numUpDownBreakfast.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(maskedPhoneNum);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtRoomNum);
            groupBox1.Controls.Add(txtRoomType);
            groupBox1.Controls.Add(txtFloorNum);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(25, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 440);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 292);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 12;
            label1.Text = "Room Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 203);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 13;
            label2.Text = "Floor Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 203);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 14;
            label3.Text = "Room Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 122);
            label4.Name = "label4";
            label4.Size = new Size(121, 24);
            label4.TabIndex = 15;
            label4.Text = "Phone Number";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(7, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 22);
            lblName.TabIndex = 16;
            lblName.Text = "Name";
            // 
            // maskedPhoneNum
            // 
            maskedPhoneNum.Location = new Point(6, 156);
            maskedPhoneNum.Mask = "(999) 000-0000";
            maskedPhoneNum.Name = "maskedPhoneNum";
            maskedPhoneNum.ReadOnly = true;
            maskedPhoneNum.Size = new Size(349, 27);
            maskedPhoneNum.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(6, 73);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(161, 27);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(194, 73);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(161, 27);
            txtLastName.TabIndex = 8;
            // 
            // txtRoomNum
            // 
            txtRoomNum.Location = new Point(6, 326);
            txtRoomNum.Name = "txtRoomNum";
            txtRoomNum.ReadOnly = true;
            txtRoomNum.Size = new Size(349, 27);
            txtRoomNum.TabIndex = 6;
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(6, 237);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.ReadOnly = true;
            txtRoomType.Size = new Size(161, 27);
            txtRoomType.TabIndex = 3;
            // 
            // txtFloorNum
            // 
            txtFloorNum.Location = new Point(194, 237);
            txtFloorNum.Name = "txtFloorNum";
            txtFloorNum.ReadOnly = true;
            txtFloorNum.Size = new Size(161, 27);
            txtFloorNum.TabIndex = 2;
            // 
            // Reservations
            // 
            Reservations.FormattingEnabled = true;
            Reservations.Location = new Point(774, 109);
            Reservations.Name = "Reservations";
            Reservations.Size = new Size(211, 424);
            Reservations.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(grdKitchenView);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1012, 587);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "OverView";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdKitchenView
            // 
            grdKitchenView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdKitchenView.Dock = DockStyle.Fill;
            grdKitchenView.Location = new Point(3, 3);
            grdKitchenView.Name = "grdKitchenView";
            grdKitchenView.RowHeadersWidth = 51;
            grdKitchenView.Size = new Size(1006, 581);
            grdKitchenView.TabIndex = 0;
            // 
            // frmKitchen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 620);
            Controls.Add(tabControl1);
            Name = "frmKitchen";
            Text = "frmKitchen";
            Load += frmKitchen_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownDinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownLunch).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownBreakfast).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdKitchenView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtRoomNum;
        private TextBox txtRoomType;
        private TextBox txtFloorNum;
        private TextBox txtFirstName;
        private ListBox Reservations;
        private TabPage tabPage2;
        private TextBox txtLastName;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private MaskedTextBox maskedPhoneNum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numUpDownDinner;
        private NumericUpDown numUpDownLunch;
        private NumericUpDown numUpDownBreakfast;
        private Button btnChangeFood;
        private CheckBox BoxFoodStatus;
        private DataGridView grdKitchenView;
    }
}