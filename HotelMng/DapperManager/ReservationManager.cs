using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HotelMng.Entities;
using HotelMng.Entities.ComplexTypes;
using Microsoft.Data.SqlClient;

namespace HotelMng.DapperManager
{
    public static class ReservationManager
    {
        private static readonly string _connectionString = "Data Source=.;Initial Catalog=HotelMng;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

        public static List<Reservation> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Reservations";
                var reservations = connection.Query<Reservation, Address, Room, Payment, Reservation>(
                    query,
                    (reservation, address, room, payment) =>
                    {
                        reservation.Address = address;
                        reservation.Room = room;
                        reservation.Payment = payment;
                        return reservation;
                    },
                    splitOn: "Address_StreetAddress, Room_RoomType, Payment_PaymentType"
                ).ToList();

                return reservations;
            }
        }


        public static bool Add(Reservation reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation));

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Reservations 
                        (FirstName, LastName, BirthDay, Gender, PhoneNumber, EmailAddress, NumberGuest, TotalBill, 
                         ArrivalTime, LeavingTime, CheckIn, BreakFast, Lunch, Dinner, SupplyStatus, FoodBill, 
                         Address_AptSuite, Address_City, Address_State, Address_StreetAddress, Address_ZipCode, 
                         Room_RoomFloor, Room_RoomNumber, Room_RoomType, 
                         Payment_CardCVC, Payment_CardExp, Payment_CardNumber, Payment_PaymentType)
                         VALUES 
                         (@FirstName, @LastName, @BirthDay, @Gender, @PhoneNumber, @EmailAddress, @NumberGuest, @TotalBill, 
                         @ArrivalTime, @LeavingTime, @CheckIn, @BreakFast, @Lunch, @Dinner, @SupplyStatus, @FoodBill, 
                         @AddressAptSuite, @AddressCity, @AddressState, @AddressStreetAddress, @AddressZipCode, 
                         @RoomFloor, @RoomNumber, @RoomType, 
                         @PaymentCardCVC, @PaymentCardExp, @PaymentCardNumber, @PaymentPaymentType)";

                int rowsAffected = connection.Execute(query, new
                {
                    reservation.FirstName,
                    reservation.LastName,
                    reservation.BirthDay,
                    reservation.Gender,
                    reservation.PhoneNumber,
                    reservation.EmailAddress,
                    reservation.NumberGuest,
                    reservation.TotalBill,
                    reservation.ArrivalTime,
                    reservation.LeavingTime,
                    reservation.CheckIn,
                    reservation.BreakFast,
                    reservation.Lunch,
                    reservation.Dinner,
                    reservation.SupplyStatus,
                    reservation.FoodBill,

                    AddressAptSuite = reservation.Address?.AptSuite ?? string.Empty,
                    AddressCity = reservation.Address?.City ?? string.Empty,
                    AddressState = reservation.Address?.State ?? string.Empty,
                    AddressStreetAddress = reservation.Address?.StreetAddress ?? string.Empty,
                    AddressZipCode = reservation.Address?.ZipCode ?? string.Empty,

                    RoomFloor = reservation.Room?.RoomFloor ?? string.Empty,
                    RoomNumber = reservation.Room?.RoomNumber ?? string.Empty,
                    RoomType = reservation.Room?.RoomType ?? string.Empty,

                    PaymentCardCVC = reservation.Payment?.CardCVC ?? string.Empty,
                    PaymentCardExp = reservation.Payment?.CardExp ?? string.Empty,
                    PaymentCardNumber = reservation.Payment?.CardNumber ?? string.Empty,
                    PaymentPaymentType = reservation.Payment?.PaymentType ?? string.Empty
                });

                return rowsAffected > 0;
            }
        }


        public static Reservation? GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Reservations WHERE Id = @Id";
                return connection.Query<Reservation, Address, Room, Payment, Reservation>(
                    query,
                    (reservation, address, room, payment) =>
                    {
                        reservation.Address = address;
                        reservation.Room = room;
                        reservation.Payment = payment;
                        return reservation;
                    },
                    new { Id = id },
                    splitOn: "Address_StreetAddress, Room_RoomType, Payment_PaymentType"
                ).FirstOrDefault();
            }
        }

        public static bool Update(Reservation reservation)
        {
            if (reservation == null)
                throw new ArgumentNullException(nameof(reservation));

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE Reservations SET 
                        FirstName = @FirstName,
                        LastName = @LastName,
                        BirthDay = @BirthDay,
                        Gender = @Gender,
                        PhoneNumber = @PhoneNumber,
                        EmailAddress = @EmailAddress,
                        NumberGuest = @NumberGuest,
                        TotalBill = @TotalBill,
                        ArrivalTime = @ArrivalTime,
                        LeavingTime = @LeavingTime,
                        CheckIn = @CheckIn,
                        BreakFast = @BreakFast,
                        Lunch = @Lunch,
                        Dinner = @Dinner,
                        SupplyStatus = @SupplyStatus,
                        FoodBill = @FoodBill,
                        Address_AptSuite = @AddressAptSuite,
                        Address_City = @AddressCity,
                        Address_State = @AddressState,
                        Address_StreetAddress = @AddressStreetAddress,
                        Address_ZipCode = @AddressZipCode,
                        Room_RoomFloor = @RoomFloor,
                        Room_RoomNumber = @RoomNumber,
                        Room_RoomType = @RoomType,
                        Payment_CardCVC = @PaymentCardCVC,
                        Payment_CardExp = @PaymentCardExp,
                        Payment_CardNumber = @PaymentCardNumber,
                        Payment_PaymentType = @PaymentPaymentType
                        WHERE Id = @Id";

                int rowsAffected = connection.Execute(query, new
                {
                    reservation.Id,
                    reservation.FirstName,
                    reservation.LastName,
                    reservation.BirthDay,
                    reservation.Gender,
                    reservation.PhoneNumber,
                    reservation.EmailAddress,
                    reservation.NumberGuest,
                    reservation.TotalBill,
                    reservation.ArrivalTime,
                    reservation.LeavingTime,
                    reservation.CheckIn,
                    reservation.BreakFast,
                    reservation.Lunch,
                    reservation.Dinner,
                    reservation.SupplyStatus,
                    reservation.FoodBill,

                    AddressAptSuite = reservation.Address?.AptSuite ?? string.Empty,
                    AddressCity = reservation.Address?.City ?? string.Empty,
                    AddressState = reservation.Address?.State ?? string.Empty,
                    AddressStreetAddress = reservation.Address?.StreetAddress ?? string.Empty,
                    AddressZipCode = reservation.Address?.ZipCode ?? string.Empty,

                    RoomFloor = reservation.Room?.RoomFloor ?? string.Empty,
                    RoomNumber = reservation.Room?.RoomNumber ?? string.Empty,
                    RoomType = reservation.Room?.RoomType ?? string.Empty,

                    PaymentCardCVC = reservation.Payment?.CardCVC ?? string.Empty,
                    PaymentCardExp = reservation.Payment?.CardExp ?? string.Empty,
                    PaymentCardNumber = reservation.Payment?.CardNumber ?? string.Empty,
                    PaymentPaymentType = reservation.Payment?.PaymentType ?? string.Empty
                });

                return rowsAffected > 0;
            }
        }

        public static bool Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Reservations WHERE Id = @Id";
                int rowsAffected = connection.Execute(query, new { Id = id });
                return rowsAffected > 0;
            }
        }
    }
}
