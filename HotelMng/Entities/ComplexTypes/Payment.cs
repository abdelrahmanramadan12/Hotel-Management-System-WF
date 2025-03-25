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
    public class Payment
    {
        //[Required]
        [MaxLength(10)]
        public string PaymentType { get; set; }

        //[Required]
        [MaxLength(50)]
        public string CardNumber { get; set; }

        //[Required]
        [MaxLength(50)]
        public string CardExp { get; set; }
        
        //[Required]
        [MaxLength(10)]
        public string CardCVC { get; set; }
    }
}
