using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Movies_portal_MVC5.Models;

namespace Movies_portal_MVC5.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();
            var ViewModel = new NewCustomerViewModel()
            {   Customer= new Customer(),
                MembershipType = membershipType
            };
            return View(ViewModel);
        }
        [HttpPost]
        public ActionResult Save(Customer Customer)
        {
            if(!ModelState.IsValid)
            {

                var ViewModel = new NewCustomerViewModel()
                {
                    Customer = Customer,
                    MembershipType = _context.MembershipTypes.ToList()
                };
                return View("New", ViewModel);
            }
            if (Customer.Id == 0)
            {
                _context.Customers.Add(Customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == Customer.Id);
                customerInDb.Name = Customer.Name;
                customerInDb.Bithday = Customer.Bithday;
                customerInDb.MembershipTypeId = Customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = Customer.IsSubscribedToNewsletter;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Customers");
        }
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var ViewModel = new NewCustomerViewModel()
            {
                Customer = customer,
                MembershipType=_context.MembershipTypes.ToList()
            };

            return View("New",ViewModel);
        }
       
    }

    }