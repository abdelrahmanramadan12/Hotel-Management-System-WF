using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelMng.Entities.ComplexTypes;
using System.ComponentModel;

namespace HotelMng.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay { get; set; } 

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        public int NumberGuest { get; set; }

        public virtual Address Address { get; set; }=new Address();

        public virtual Room Room { get; set; } = new Room();

        public virtual Payment Payment { get; set; } = new Payment();

        [Required]
        public double TotalBill { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public DateTime LeavingTime { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool CheckIn { get; set; }

        int breakFast;
        public int BreakFast {
            get => breakFast;
            set 
            {
                breakFast = value;
                TotalBill += value * 10;
            }
        }

        int lunch;
        public int Lunch 
        { 
            get=>lunch;
            set 
            {
                lunch = value;
                TotalBill += value * 15;
            } 
        }

        int dinner;
        public int Dinner 
        { 
            get=>dinner;
            set
            {
                dinner = value;
                TotalBill += value * 15;
            }
        }

        public bool SupplyStatus { get; set; }

        public int FoodBill { get; set; }
    }
}
