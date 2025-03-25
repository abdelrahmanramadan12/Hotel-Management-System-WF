using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMng.Entities
{
    public class User
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }

    }
}
