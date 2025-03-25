using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMng.Entities.ComplexTypes
{
    [ComplexType]
    public class Room
    {
        [MaxLength(10)]
        public string RoomType { get; set; } = "Single";

        [MaxLength(10)]
        public string RoomFloor { get; set; }

        [MaxLength(10)]
        public string RoomNumber { get; set; }
    }
}
