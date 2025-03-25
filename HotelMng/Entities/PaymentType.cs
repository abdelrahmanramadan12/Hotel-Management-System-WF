using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMng.Entities
{
    public enum PaymentType
    {
        CreditCard,
        DebitCard,
        Cash,
        BankTransfer
    }

    public enum RoomType
    {
        Single,
        Double,
        Twin,
        Duplex,
        Suite,
    }
}
