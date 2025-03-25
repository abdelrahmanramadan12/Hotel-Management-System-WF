namespace HotelMng
{
    partial class frmPayment
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboPayType = new ComboBox();
            maskedCardNumber = new MaskedTextBox();
            comboYY = new ComboBox();
            comboMM = new ComboBox();
            txtCVC = new TextBox();
            btnNext = new Button();
            lblTax = new Label();
            lblFoodbill = new Label();
            lblCurrentBill = new Label();
            lblTotal = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 26);
            label1.TabIndex = 0;
            label1.Text = "Reservation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Current bill";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Food bill";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 138);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 3;
            label4.Text = "Tax";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 172);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 191);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "Payment";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(552, 29);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 6;
            label7.Text = "Price";
            // 
            // comboPayType
            // 
            comboPayType.FormattingEnabled = true;
            comboPayType.Items.AddRange(new object[] { "Credit", "Debit" });
            comboPayType.Location = new Point(12, 214);
            comboPayType.Name = "comboPayType";
            comboPayType.Size = new Size(151, 28);
            comboPayType.TabIndex = 8;
            comboPayType.Text = "Payment type ";
            // 
            // maskedCardNumber
            // 
            maskedCardNumber.Location = new Point(223, 215);
            maskedCardNumber.Mask = "9999-9999-9999-9999";
            maskedCardNumber.Name = "maskedCardNumber";
            maskedCardNumber.Size = new Size(340, 27);
            maskedCardNumber.TabIndex = 9;
            // 
            // comboYY
            // 
            comboYY.FormattingEnabled = true;
            comboYY.Location = new Point(95, 266);
            comboYY.Name = "comboYY";
            comboYY.Size = new Size(68, 28);
            comboYY.TabIndex = 11;
            comboYY.Text = "YY";
            // 
            // comboMM
            // 
            comboMM.FormattingEnabled = true;
            comboMM.Location = new Point(12, 266);
            comboMM.Name = "comboMM";
            comboMM.Size = new Size(65, 28);
            comboMM.TabIndex = 12;
            comboMM.Text = "MM";
            // 
            // txtCVC
            // 
            txtCVC.Location = new Point(223, 267);
            txtCVC.Name = "txtCVC";
            txtCVC.PlaceholderText = "CVC";
            txtCVC.Size = new Size(60, 27);
            txtCVC.TabIndex = 13;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Navy;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Magneto", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(552, 294);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 38);
            btnNext.TabIndex = 15;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(541, 138);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(0, 20);
            lblTax.TabIndex = 16;
            // 
            // lblFoodbill
            // 
            lblFoodbill.AutoSize = true;
            lblFoodbill.Location = new Point(541, 95);
            lblFoodbill.Name = "lblFoodbill";
            lblFoodbill.Size = new Size(0, 20);
            lblFoodbill.TabIndex = 17;
            // 
            // lblCurrentBill
            // 
            lblCurrentBill.AutoSize = true;
            lblCurrentBill.Location = new Point(541, 66);
            lblCurrentBill.Name = "lblCurrentBill";
            lblCurrentBill.Size = new Size(0, 20);
            lblCurrentBill.TabIndex = 19;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(541, 172);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 20;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Magneto", 12F, FontStyle.Bold | FontStyle.Italic);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(447, 294);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 38);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // frmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 344);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(lblTotal);
            Controls.Add(lblCurrentBill);
            Controls.Add(lblFoodbill);
            Controls.Add(lblTax);
            Controls.Add(btnNext);
            Controls.Add(txtCVC);
            Controls.Add(comboMM);
            Controls.Add(comboYY);
            Controls.Add(maskedCardNumber);
            Controls.Add(comboPayType);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPayment";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Payment";
            Load += frmPayment_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboPayType;
        private MaskedTextBox maskedCardNumber;
        private ComboBox comboYY;
        private ComboBox comboMM;
        private TextBox txtCVC;
        private Button btnNext;
        private Label lblTax;
        private Label lblFoodbill;
        private Label lblCurrentBill;
        private Label lblTotal;
        private Button btnClose;
    }
}