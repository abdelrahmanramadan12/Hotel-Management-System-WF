using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMng
{
    public partial class frmFood : Form
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BreakfastQuantity { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int LunchQuantity { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int DinnerQuantity { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TotalFoodBill { get; private set; }
   
        private const int BreakfastPrice = 10;
        private const int LunchPrice = 15;
        private const int DinnerPrice = 15;
    

        public frmFood()
        {
            InitializeComponent();
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
        }



        private void frmFood_Load(object sender, EventArgs e)
        {
            numUpDownBreakfast.Enabled = false;
            numUpDownDinner.Enabled = false;
            numUpDownLunch.Enabled = false;

            numUpDownBreakfast.Value = 0;
            numUpDownDinner.Value = 0;
            numUpDownLunch.Value = 0;

            boxBreakfast.CheckedChanged += chkBreakfast_CheckedChanged;
            boxLunch.CheckedChanged += chkLunch_CheckedChanged;
            boxDinner.CheckedChanged += chkDinner_CheckedChanged;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            BreakfastQuantity = (int)numUpDownBreakfast.Value;
            LunchQuantity = (int)numUpDownLunch.Value;
            DinnerQuantity = (int)numUpDownDinner.Value;

            TotalFoodBill = (BreakfastQuantity * BreakfastPrice) +
                            (LunchQuantity * LunchPrice) +
                            (DinnerQuantity * DinnerPrice);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void chkBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            numUpDownBreakfast.Enabled = boxBreakfast.Checked;
            if (!boxBreakfast.Checked) numUpDownBreakfast.Value = 0; // Reset value if unchecked
        }

        private void chkLunch_CheckedChanged(object sender, EventArgs e)
        {
            numUpDownLunch.Enabled = boxLunch.Checked;
            if (!boxLunch.Checked) numUpDownLunch.Value = 0;
        }

        private void chkDinner_CheckedChanged(object sender, EventArgs e)
        {
            numUpDownDinner.Enabled = boxDinner.Checked;
            if (!boxDinner.Checked) numUpDownDinner.Value = 0;
        }
        private void boxBreakfast_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
