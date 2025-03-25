using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelMng.Entities;
using HotelMng.Entities.ComplexTypes;

namespace HotelMng
{
    public partial class frmPayment : Form
    {
        private Payment payment;
        private Reservation reservation;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TotalBill { get; set; }

        public frmPayment(Reservation reservation)
        {
            InitializeComponent();
            this.reservation = reservation;
            payment = reservation.Payment;
            TotalBill= (int)(reservation.TotalBill-(reservation.TotalBill*0.1));

        }




        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedCardNumber.Text) || string.IsNullOrEmpty(txtCVC.Text)
                || string.IsNullOrEmpty(comboMM.Text) || string.IsNullOrEmpty(comboYY.Text)
                || string.IsNullOrEmpty(comboMM.Text) || string.IsNullOrEmpty(comboYY.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            payment.PaymentType = comboPayType.Text;
            payment.CardNumber = maskedCardNumber.Text;
            payment.CardExp = comboMM.Text + "/" + comboYY.Text;
            payment.CardCVC = txtCVC.Text;
            reservation.Payment = payment;
            MessageBox.Show("Payment successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();



        }


      
        private void frmPayment_Load_1(object sender, EventArgs e)
        {
            lblCurrentBill.Text = ( TotalBill - reservation.FoodBill).ToString();
            lblFoodbill.Text=(reservation.FoodBill).ToString();
            lblTax.Text = (TotalBill * 0.1).ToString();
            TotalBill += (int)(TotalBill * 0.1);
            lblTotal.Text = (TotalBill).ToString();


            reservation.TotalBill = TotalBill;

            // Initialize month and year dropdowns
            for (int i = 1; i <= 12; i++)
            {
                comboMM.Items.Add(i.ToString("00"));
            }

            int currentYear = DateTime.Now.Year;
            for (int i = 0; i < 10; i++)
            {
                comboYY.Items.Add((currentYear + i).ToString());
            }

        }

   

    }
}
