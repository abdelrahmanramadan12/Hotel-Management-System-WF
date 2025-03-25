using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelMng.DapperManager;
using HotelMng.Entities;
using HotelMng.Entities.ComplexTypes;
using HotelMng.Manager;
using HotelMng.ViewModels;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using static System.Net.Mime.MediaTypeNames;
using static HotelMng.Manager.EntityManager<HotelMng.Entities.Reservation>;


namespace HotelMng
{
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            reservation = new Reservation();
            InitializeComponent();
        }
        Reservation reservation;
        private void frmReservation_Load(object sender, EventArgs e)
        {
            btnSaveReserv.Visible = false;
            btnDeleteReserv.Visible = false;
            comboBoxAllReserv.Visible = false;


            // var reservations = EntityManager<Reservation>.GetAll();   ///get all reservation with EF
            var reservations = ReservationManager.GetAll(); ///get all reservation with Dapper 

            grdAllReservation.DataSource = reservations;
            grdAllReservation.Columns["Id"].Visible = false;

            var occupiedRooms = reservations.Where(r => r.CheckIn==true)
                .Select(r=>new OccupiedRoom
                        {
                            RoomNumber = r.Room.RoomNumber,
                            RoomType = r.Room.RoomType.ToString(),
                            FirstName = r.FirstName,
                            LastName = r.LastName,
                            PhoneNumber = r.PhoneNumber,
                        }).ToList();
            var reservedRooms = reservations.Where(r => r.CheckIn==false)
                .Select(r=> new ReservedRoom
                {
                    RoomNumber = r.Room.RoomNumber,
                    RoomType = r.Room.RoomType.ToString(),
                    FirstName = r.FirstName,
                    LastName = r.LastName,
                    PhoneNumber = r.PhoneNumber,
                    ArrivalTime = r.ArrivalTime,
                    LeavingTime = r.LeavingTime
                }).ToList();

            grdOccupiedRoom.DataSource = occupiedRooms;
            grdReservedRoom.DataSource = reservedRooms;

            comboFloor.DataSource = floorRooms.Keys.ToList();
            comboFloor.SelectedIndexChanged += comboFloor_SelectedIndexChanged;
            comboRoomNum.SelectedIndexChanged += comboRoomNum_SelectedIndexChanged;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int year, month, day;
            reservation.Room = new Room()
            {
                RoomType = comboRoomType.Text,
                RoomFloor = comboFloor.Text,
                RoomNumber = comboRoomNum.Text
            };

            reservation.FirstName = txtFirstName.Text;
            reservation.LastName = txtLastName.Text;
            reservation.PhoneNumber = mkdTxtPhone.Text;
            reservation.EmailAddress = txtEmail.Text;
            try
            {
                year = Convert.ToInt32(txtBDYear.Text);
                day = Convert.ToInt32(comboBDDay.Text);

                month = Convert.ToInt32(comboBDMonth.Text);

                reservation.BirthDay = new DateTime(year, month, day);

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please check year, month, and day values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid birth date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reservation.Gender = comboGender.Text;
            reservation.Address = new Address()
            {
                StreetAddress = txtStreetAdd.Text,
                AptSuite = txtApt.Text,
                City = txtCity.Text,
                State = txtState.Text,
                ZipCode = txtZipCode.Text
            };
            reservation.ArrivalTime = dateArrival.Value;
            reservation.LeavingTime = dateLeaving.Value;
            reservation.NumberGuest = Convert.ToInt32(comboNumOfGuests.Text);
            reservation.CheckIn = boxCheckIn.Checked;
            reservation.SupplyStatus = boxSupplySts.Checked;
            reservation.SupplyStatus = boxSupplySts.Checked;

            //EntityManager<Reservation>.Add(reservation);  /// Adding new reservation with EF
            ReservationManager.Add(reservation);  ///Adding new Reservation with Dapper 

            MessageBox.Show("Reservation Added Successfully");
        }



        private void btnEditReserv_Click(object sender, EventArgs e)
        {
            //var reservation = EntityManager<Reservation>.GetAll();  /// EF
            var reservation = ReservationManager.GetAll();            /// Dapper


            btnSaveReserv.Visible = true;
            btnDeleteReserv.Visible = true;
            btnSubmit.Enabled = false;
            comboBoxAllReserv.Visible = true;


            comboBoxAllReserv.DataSource = reservation;
            comboBoxAllReserv.DisplayMember = "FirstName";
            comboBoxAllReserv.ValueMember = "Id";


            comboBoxAllReserv.SelectedIndexChanged += comboBoxAllReserv_SelectedIndexChanged;

        }



        private void btnSaveReserv_Click(object sender, EventArgs e)
        {
            int year, month, day;
            if (comboBoxAllReserv.SelectedItem == null)
            {
                MessageBox.Show("Please select a reservation to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(comboBoxAllReserv.SelectedValue?.ToString(), out int selectedReservationId))
            {
                MessageBox.Show("Invalid Reservation ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //var reservation = EntityManager<Reservation>.GetById(selectedReservationId); /// EF
            var reservation = ReservationManager.GetById(selectedReservationId); /// EF


            if (reservation == null)
            {
                MessageBox.Show("Reservation not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            reservation.FirstName = txtFirstName.Text;
            reservation.LastName = txtLastName.Text;
            reservation.PhoneNumber = mkdTxtPhone.Text;
            reservation.EmailAddress = txtEmail.Text;
            reservation.Gender = comboGender.Text;
            reservation.ArrivalTime = dateArrival.Value;
            reservation.LeavingTime = dateLeaving.Value;
            reservation.NumberGuest = Convert.ToInt32(comboNumOfGuests.Text);
           
            try
            {
                year = Convert.ToInt32(txtBDYear.Text);
                day = Convert.ToInt32(comboBDDay.Text);

                month = Convert.ToInt32(comboBDMonth.Text);

                reservation.BirthDay = new DateTime(year, month, day);

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format. Please check year, month, and day values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Invalid birth date. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reservation.Address.StreetAddress = txtStreetAdd.Text;
            reservation.Address.AptSuite = txtApt.Text;
            reservation.Address.City = txtCity.Text;
            reservation.Address.State = txtState.Text;
            reservation.Address.ZipCode = txtZipCode.Text;

            reservation.Room.RoomType = comboRoomType.Text;
            reservation.Room.RoomFloor = comboFloor.Text;
            reservation.Room.RoomNumber = comboRoomNum.Text;
            reservation.CheckIn = boxCheckIn.Checked;
            reservation.SupplyStatus = boxSupplySts.Checked;


            //EntityManager<Reservation>.Update(reservation); /// EF
            ReservationManager.Update(reservation); /// Dapper


            MessageBox.Show("Reservation Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnDeleteReserv_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(comboBoxAllReserv.SelectedValue?.ToString(), out id))
            {
                MessageBox.Show("Invalid reservation ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this reservation?",
                                       "Confirm Deletion",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //EntityManager<Reservation>.Delete(id); ///EF
                ReservationManager.Delete(id); ///EF

                MessageBox.Show("Reservation Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnEditReserv_Click(null, null);
            }
        }

        private void btnNewReserv_Click(object sender, EventArgs e)
        {
            btnSaveReserv.Visible = false;
            btnDeleteReserv.Visible = false;
            btnSubmit.Enabled = true;
            comboBoxAllReserv.Visible = false;

            ClearFields();


        }

        private void btnBillFrm_Click(object sender, EventArgs e)
        {
            reservation.TotalBill += reservationPrice();
            using (frmPayment paymentForm = new frmPayment(reservation))
            {
                if (paymentForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Payment Successful!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
        private void btnFoodFrm_Click(object sender, EventArgs e)
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

                    MessageBox.Show($"Food Added! Total: ${foodBill}", "Food Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void comboBoxAllReserv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAllReserv.SelectedItem == null) return;

            int selectedReservationId;
            if (!int.TryParse(comboBoxAllReserv.SelectedValue?.ToString(), out selectedReservationId))
            {
                MessageBox.Show("Invalid reservation ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var reservation = EntityManager<Reservation>.GetById(selectedReservationId);

            if (reservation != null)
            {
                txtFirstName.Text = reservation.FirstName;
                txtLastName.Text = reservation.LastName;
                mkdTxtPhone.Text = reservation.PhoneNumber;
                txtEmail.Text = reservation.EmailAddress;
                comboGender.Text = reservation.Gender;
                dateArrival.Value = reservation.ArrivalTime;
                dateLeaving.Value = reservation.LeavingTime;
                comboNumOfGuests.Text = reservation.NumberGuest.ToString();

                // Address fields
                txtStreetAdd.Text = reservation.Address.StreetAddress;
                txtApt.Text = reservation.Address.AptSuite;
                txtCity.Text = reservation.Address.City;
                txtState.Text = reservation.Address.State;
                txtZipCode.Text = reservation.Address.ZipCode;

                // Room fields
                comboRoomType.Text = reservation.Room.RoomType.ToString();
                comboFloor.Text = reservation.Room.RoomFloor;
                comboRoomNum.Text = reservation.Room.RoomNumber;

                // Check-in status
                boxCheckIn.Checked = reservation.CheckIn;

                // Food fields
                boxSupplySts.Checked = reservation.SupplyStatus;


                // Birth Date
                comboBDMonth.Text = reservation.BirthDay.Month.ToString();
                comboBDDay.Text = reservation.BirthDay.Day.ToString();
                txtBDYear.Text = reservation.BirthDay.Year.ToString();




            }
        }


        private void ClearFields()
        {
            // Clear TextBoxes
            txtFirstName.Clear();
            txtLastName.Clear();
            mkdTxtPhone.Clear();
            txtEmail.Clear();
            txtStreetAdd.Clear();
            txtApt.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZipCode.Clear();

            // Reset ComboBoxes
            comboRoomType.SelectedIndex = -1;
            comboFloor.SelectedIndex = -1;
            comboRoomNum.SelectedIndex = -1;
            comboGender.SelectedIndex = -1;
            comboNumOfGuests.SelectedIndex = -1;
            comboBoxAllReserv.SelectedIndex = -1;

            // Reset DateTimePickers to default values (today's date)
            dateArrival.Value = DateTime.Today;
            dateLeaving.Value = DateTime.Today;

            // Reset CheckBox
            boxCheckIn.Checked = false;

            // Reset Birth Date ComboBoxes
            comboBDMonth.SelectedIndex = -1;
            comboBDDay.SelectedIndex = -1;
            txtBDYear.Clear();
        }


        private Dictionary<int, List<string>> floorRooms = new Dictionary<int, List<string>>()
        {
            {1,new List<string>{ "101", "102", "103", "104", "105", "106", "107", "108", "109", "110" } },
            {2,new List<string> { "201", "202", "203", "204", "205", "206", "207", "208", "209", "210" } },
            {3,new List<string> { "301", "302", "303", "304", "305", "306", "307", "308", "309", "310" } },
            {4,new List<string> { "401", "402", "403", "404", "405", "406", "407", "408", "409", "410" } },
            {5,new List<string> { "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" } }
        };


        private void comboFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFloor.SelectedItem == null) return;

            int selectedFloor;

            if (!int.TryParse(comboFloor.SelectedItem.ToString(), out selectedFloor))
            {
                return;
            }

            if (floorRooms.ContainsKey(selectedFloor))
            {
                var allReservations = EntityManager<Reservation>.GetAll();
                var bookedRooms = allReservations.Select(r => r.Room.RoomNumber).ToList();
                comboRoomNum.DataSource = floorRooms[selectedFloor].Except(bookedRooms).ToList();
            }
        }

        private void comboRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRoomNum.SelectedItem != null)
            {
                string selectedRoom = comboRoomNum.SelectedItem.ToString();

                foreach (var floor in floorRooms)
                {
                    if (floor.Value.Contains(selectedRoom))
                    {
                        comboFloor.SelectedItem = floor.Key; // Set corresponding floor
                        break;
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void grdAllReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private int reservationPrice()
        {

            int price = 0;
            if (comboRoomType.Text == ("Single"))
            {
                price = 100 *   Convert.ToInt32(comboNumOfGuests.Text);
            }
            else if (comboRoomType.Text == ("Double"))
            {
                price = 200 * Convert.ToInt32(comboNumOfGuests.Text);
            }
            else if (comboRoomType.Text == ("Twin"))
            {
                price = 300 * Convert.ToInt32(comboNumOfGuests.Text);
            }
            else if (comboRoomType.Text == ("Duplex"))
            {
                price = 400 * Convert.ToInt32(comboNumOfGuests.Text);
            }
            else if (comboRoomType.Text == ("Suite"))
            {
                price = 500 * Convert.ToInt32(comboNumOfGuests.Text);
            }
            return price;

        }
    }
}
