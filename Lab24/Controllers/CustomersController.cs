using Lab24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab24.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Customer> customerList = db.Customers.ToList();

            return View(customerList);
        }

        // GET: Customers/Details/5
        public ActionResult Details(string id)
        {
            NorthwindEntities details = new NorthwindEntities();
            Customer customer = details.Customers.Find(id); 
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                NorthwindEntities db = new NorthwindEntities();
                Customer newCustomer = new Customer();
                newCustomer.CustomerID = collection["CustomerID"];
                newCustomer.CompanyName = collection["CompanyName"];
                newCustomer.ContactName = collection["ContactName"];
                newCustomer.ContactTitle = collection["ContactTitle"];
                newCustomer.Address = collection["Address"];
                newCustomer.Address = collection["City"];
                newCustomer.Region = collection["Region"];
                newCustomer.PostalCode = collection["PostalCode"];
                newCustomer.Country = collection["Country"];
                newCustomer.Phone = collection["Phone"];
                newCustomer.Fax = collection["Fax"];
                db.Customers.Add(newCustomer);
                db.SaveChanges();

                //return View();

                return RedirectToAction("Index");
            }
            catch(Exception ex )
            {
                TempData["Error"] = ex.InnerException;
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(string id)
        {
            NorthwindEntities db = new NorthwindEntities();

            return View(db.Customers.Find(id));

        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                var foundCustomer = db.Customers.Find(id);

                foundCustomer.CustomerID = collection["CustomerID"];
                foundCustomer.CompanyName = collection["CompanyName"];
                foundCustomer.ContactName = collection["ContactName"];
                foundCustomer.ContactTitle = collection["ContactTitle"];
                foundCustomer.Address = collection["Address"];
                foundCustomer.Address = collection["City"];
                foundCustomer.Region = collection["Region"];
                foundCustomer.PostalCode = collection["PostalCode"];
                foundCustomer.Country = collection["Country"];
                foundCustomer.Phone = collection["Phone"];
                foundCustomer.Fax = collection["Fax"];
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(string id)
        {
            NorthwindEntities db = new NorthwindEntities();
            return View(db.Customers.Find(id));
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                NorthwindEntities db = new NorthwindEntities();
                var foundCustomer = db.Customers.Find(id);
                
                var matchingOrders = db.Orders.Where(x => x.CustomerID == foundCustomer.CustomerID);

                if (matchingOrders.ToList().Count > 0)
                {
                    TempData["Error"] = "Invalid Request - Outstanding Orders";
                    return View();
                }
                else
                {

                    db.Customers.Remove(foundCustomer);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.InnerException;
                return View();


                
            }
        }
    }
}
