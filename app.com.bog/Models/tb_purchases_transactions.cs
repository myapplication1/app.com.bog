using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app_com_bog.Models
{
    public class tb_purchases_transactions
    {
        public int ID { get; set; }
        public DateTime DatePosted { get; set; }
        public string RecNo { get; set; }
        public decimal US_Dollars { get; set; }
        public decimal BritishPounds { get; set; }
        public decimal Yen { get; set; }
        public decimal CFA { get; set; }
        public decimal Euro { get; set; }
        public decimal CanDollar { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalAmount { get; set; }
        public string UserPosted { get; set; }
        public string UserModified { get; set; }
    }
}