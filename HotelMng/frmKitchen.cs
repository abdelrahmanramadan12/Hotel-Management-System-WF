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
using HotelMng.Manager;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HotelMng
{
    public partial class frmKitchen : Form
    {
        Reservation reservation;
        public frmKitchen()
        {
            reservation = new Reservation();
            InitializeComponent();
        }
        private void frmKitchen_Load(object sender, EventArgs e)
        {
            var allReservations = EntityManager<Reservation>.GetAll();

            Reservations.DataSource = allReservations;
            Reservations.DisplayMember = "FirstName";
            Reservations.ValueMember = "Id";

            grdKitchenView.DataSource = allReservations;
            grdKitchenView.Columns["EmailAddress"].Visible = false;
            grdKitchenView.Columns["Payment"].Visible = false;


            Reservations.SelectedValueChanged += lstReservations_SelectedIndexChanged;


        }

        private void btnChangeFood_Click(object sender, EventArgs e)
        {

            using (frmFood foodForm = new frmFood())
            {
                if (foodForm.ShowDialog() == DialogResult.OK)
                {
                    // Assign selected food values to reservation
                    int breakfastQty = foodForm.BreakfastQuantity;
                    int lunchQty = foodForm.LunchQuantity;
                    int dinnerQty = foodForm.DinnerQuantity;
                    int foodBill = (int)foodForm.TotalFoodBill;

                    // Store in reservation object
                    reservation.BreakFast = breakfastQty;
                    reservation.Lunch = lunchQty;
                    reservation.Dinner = dinnerQty;
                    reservation.FoodBill = foodBill;
                    reservation.TotalBill += foodBill;

                    MessageBox.Show($"Food Added! Total: ${foodBill}", "Food Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {




        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lstReservations_SelectedIndexChanged(object s, EventArgs e)
        {
            int selectedId = (int)Reservations.SelectedValue;
            reservation = EntityManager<Reservation>.GetById(selectedId);

            txtFirstName.Text = reservation.FirstName;
            txtLastName.Text = reservation.LastName;
            maskedPhoneNum.Text = reservation.PhoneNumber;
            txtRoomNum.Text = reservation.Room.RoomNumber;
            txtRoomType.Text = reservation.Room.RoomType;
            txtFloorNum.Text = reservation.Room.RoomFloor;
            numUpDownBreakfast.Text = reservation.BreakFast.ToString();
            numUpDownLunch.Text = reservation.Lunch.ToString();
            numUpDownDinner.Text = reservation.Dinner.ToString();

            BoxFoodStatus.Checked = reservation.SupplyStatus;

        }

    }
}
