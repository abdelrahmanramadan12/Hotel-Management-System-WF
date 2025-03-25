using HotelMng.Data;
using HotelMng.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HotelMng
{
    public partial class LogIn : Form
    {
        HotelMngContext context;
        public LogIn()
        {
            InitializeComponent();
            context = new HotelMngContext();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            context.Kitchens.Load();
            context.Admins.Load();
            try
            {
                if(context.Kitchens.Any(k => k.UserName == txtUserName.Text && k.Password == txtPassword.Text))
                {
                    frmKitchen frmKitchen = new frmKitchen();
                    frmKitchen.Show();
                    this.Hide();

                }
                else if (context.Admins.Any(a => a.UserName == txtUserName.Text && a.Password == txtPassword.Text))
                {
                    
                    frmReservation reservationForm = new frmReservation();
                    reservationForm.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
