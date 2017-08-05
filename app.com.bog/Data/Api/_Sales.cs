using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using app_com_bog.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using app_com_bog.Data;
using app_bom_bog.Data.DataGrid;

namespace app_com_bog.Controllers.ApiControllers
{
    public class _SalesController : ApiController
    {
        _DbContext db = new _DbContext();
        Util obj = new Util();

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            return Request.CreateResponse(DataSourceLoader.Load((ICollection<tb_sales_transactions>)obj.Sales(), loadOptions));
        }

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            var values = form.Get("values");

            var sales = new tb_sales_transactions();
            JsonConvert.PopulateObject(values, sales);
            sales.UserPosted = "kris";
            Validate(sales);
            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);


            db.tb_sales_transactions.Add(sales);
            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var employee = db.tb_sales_transactions.First(e => e.ID == key);

            JsonConvert.PopulateObject(values, employee);

            Validate(employee);
            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ModelState);

            db.SaveChanges();

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void Delete(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var sales = db.tb_sales_transactions.First(e => e.ID == key);

            db.tb_sales_transactions.Remove(sales);
            db.SaveChanges();
        }
    }
}