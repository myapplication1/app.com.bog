using app_com_bog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using app_com_bog.Data;

namespace app_bom_bog.Data.DataGrid
{
    public class InMemorySalesDataContext
    {
        const string SessionKey = "3fd387f5-610a-4060-9204-619ef6e6f3ef";
        Util obj = new Util();
            
        public ICollection<tb_sales_transactions> sales
        {
            get
            {
                var session = HttpContext.Current.Session;
                //if (session[SessionKey] == null)
                 // var results  session[SessionKey] = null;//obj.Sales();

                return (ICollection<tb_sales_transactions>)obj.Sales();
            }
        }

        public void SaveChanges()
        {
            foreach (var tb_sales_transactions in sales.Where(a => a.ID == 0))
            {
                tb_sales_transactions.ID = sales.Max(a => a.ID) + 1;
            }
        }
    }
}