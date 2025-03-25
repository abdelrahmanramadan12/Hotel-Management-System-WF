namespace HotelMng
{
    partial class frmFood
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
            boxBreakfast = new CheckBox();
            boxLunch = new CheckBox();
            boxDinner = new CheckBox();
            numUpDownBreakfast = new NumericUpDown();
            numUpDownLunch = new NumericUpDown();
            numUpDownDinner = new NumericUpDown();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)numUpDownBreakfast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownLunch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownDinner).BeginInit();
            SuspendLayout();
            // 
            // boxBreakfast
            // 
            boxBreakfast.AutoSize = true;
            boxBreakfast.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxBreakfast.Location = new Point(45, 103);
            boxBreakfast.Name = "boxBreakfast";
            boxBreakfast.Size = new Size(133, 24);
            boxBreakfast.TabIndex = 0;
            boxBreakfast.Text = "Breakfast (10$)";
            boxBreakfast.UseVisualStyleBackColor = true;
            boxBreakfast.CheckedChanged += boxBreakfast_CheckedChanged;
            // 
            // boxLunch
            // 
            boxLunch.AutoSize = true;
            boxLunch.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxLunch.Location = new Point(238, 103);
            boxLunch.Name = "boxLunch";
            boxLunch.Size = new Size(110, 24);
            boxLunch.TabIndex = 1;
            boxLunch.Text = "Lunch (15$)";
            boxLunch.UseVisualStyleBackColor = true;
            // 
            // boxDinner
            // 
            boxDinner.AutoSize = true;
            boxDinner.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            boxDinner.Location = new Point(392, 103);
            boxDinner.Name = "boxDinner";
            boxDinner.Size = new Size(115, 24);
            boxDinner.TabIndex = 2;
            boxDinner.Text = "Dinner (15$)";
            boxDinner.UseVisualStyleBackColor = true;
            // 
            // numUpDownBreakfast
            // 
            numUpDownBreakfast.Location = new Point(45, 133);
            numUpDownBreakfast.Name = "numUpDownBreakfast";
            numUpDownBreakfast.Size = new Size(130, 27);
            numUpDownBreakfast.TabIndex = 3;
            // 
            // numUpDownLunch
            // 
            numUpDownLunch.Location = new Point(221, 133);
            numUpDownLunch.Name = "numUpDownLunch";
            numUpDownLunch.Size = new Size(124, 27);
            numUpDownLunch.TabIndex = 4;
            // 
            // numUpDownDinner
            // 
            numUpDownDinner.Location = new Point(377, 133);
            numUpDownDinner.Name = "numUpDownDinner";
            numUpDownDinner.Size = new Size(128, 27);
            numUpDownDinner.TabIndex = 5;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Purple;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(145, 215);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(237, 41);
            btnNext.TabIndex = 6;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // frmFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 291);
            Controls.Add(btnNext);
            Controls.Add(numUpDownDinner);
            Controls.Add(numUpDownLunch);
            Controls.Add(numUpDownBreakfast);
            Controls.Add(boxDinner);
            Controls.Add(boxLunch);
            Controls.Add(boxBreakfast);
            Name = "frmFood";
            Text = "frmFood";
            Load += frmFood_Load;
            ((System.ComponentModel.ISupportInitialize)numUpDownBreakfast).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownLunch).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownDinner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox boxBreakfast;
        private CheckBox boxLunch;
        private CheckBox boxDinner;
        private NumericUpDown numUpDownBreakfast;
        private NumericUpDown numUpDownLunch;
        private NumericUpDown numUpDownDinner;
        private Button btnNext;
    }
}