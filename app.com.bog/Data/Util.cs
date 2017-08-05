using app_com_bog.Data;
using app_com_bog.Models;
//using app_com_bog.Models.DataGrid;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace app_com_bog.Data
{
    public class Util
    {
        private _DbContext db = new _DbContext();

        public List<tb_sales_transactions> Sales()
        {
            var res_ = (from x in db.tb_sales_transactions select x).ToList();
            //db.tb_sales_transactions.ToList();
            
            return res_;
            
       }
    }
}