using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app_com_bog.Models
{
    public class tb_currency
    {
        public int ID { get; set; }
        public DateTime DatePosted { get; set; }
        public string UserPosted { get; set; }
        public string UserModified { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Label { get; set; }
        public decimal Rate { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }

    }
}