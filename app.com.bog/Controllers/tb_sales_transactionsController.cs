using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using app_com_bog.Data;
using app_com_bog.Models;

namespace app_com_bog.Controllers
{
    public class tb_sales_transactionsController : Controller
    {
        private _DbContext db = new _DbContext();

        // GET: tb_sales_transactions
        public ActionResult Index()
        {
            return View();
        }

        // GET: tb_sales_transactions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_sales_transactions tb_sales_transactions = await db.tb_sales_transactions.FindAsync(id);
            if (tb_sales_transactions == null)
            {
                return HttpNotFound();
            }
            return View(tb_sales_transactions);
        }

        // GET: tb_sales_transactions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_sales_transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,DatePosted,RecNo,US_Dollars,BritishPounds,Yen,CFA,Euro,CanDollar,Rate,TotalAmount,UserPosted,UserModified")] tb_sales_transactions tb_sales_transactions)
        {
            if (ModelState.IsValid)
            {
                db.tb_sales_transactions.Add(tb_sales_transactions);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tb_sales_transactions);
        }

        // GET: tb_sales_transactions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_sales_transactions tb_sales_transactions = await db.tb_sales_transactions.FindAsync(id);
            if (tb_sales_transactions == null)
            {
                return HttpNotFound();
            }
            return View(tb_sales_transactions);
        }

        // POST: tb_sales_transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,DatePosted,RecNo,US_Dollars,BritishPounds,Yen,CFA,Euro,CanDollar,Rate,TotalAmount,UserPosted,UserModified")] tb_sales_transactions tb_sales_transactions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_sales_transactions).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tb_sales_transactions);
        }

        // GET: tb_sales_transactions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_sales_transactions tb_sales_transactions = await db.tb_sales_transactions.FindAsync(id);
            if (tb_sales_transactions == null)
            {
                return HttpNotFound();
            }
            return View(tb_sales_transactions);
        }

        // POST: tb_sales_transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tb_sales_transactions tb_sales_transactions = await db.tb_sales_transactions.FindAsync(id);
            db.tb_sales_transactions.Remove(tb_sales_transactions);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
