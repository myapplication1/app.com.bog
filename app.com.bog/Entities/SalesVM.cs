using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app_com_bog.Entities
{
    public class SalesVM
    {

        public DateTime DatePosted { get; set; }
        public string RecNo { get; set; }
        public int CurrencyType { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public string UserPosted { get; set; }
        public string UserModified { get; set; }
    }
}