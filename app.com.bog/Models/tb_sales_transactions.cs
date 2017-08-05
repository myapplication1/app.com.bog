using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app_com_bog.Models
{
    public class tb_sales_transactions
    {
        [Key]
        public int ID { get; set; }
        public DateTime DatePosted { get; set; }
        [Required(ErrorMessage = "Receipt No. Required")]
        public string RecNo { get; set; }
        [Required(ErrorMessage = "Currency Required")]
        public int CurrencyType { get; set; }
        [Required(ErrorMessage = "Rate Required")]
        public decimal Rate { get; set; }

        //public decimal? US_Dollars { get; set; }
        //public decimal? BritishPounds { get; set; }
        //public decimal? Yen { get; set; }
        //public decimal? CFA { get; set; }
        //public decimal? Euro { get; set; }
        //public decimal ?CanDollar { get; set; }
        [Required(ErrorMessage = "Amount Required")]
        public decimal Amount { get; set; }
        public decimal TotalAmount
        {
            get
            {
                return (Rate* Amount);
            }
        }
        public string UserPosted { get; set; }
        public string UserModified { get; set; }
    }
}