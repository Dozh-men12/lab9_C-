using bussiness;
using entity;
using lab9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab9.Controllers
{
    public class CustomerController1 : Controller
    {
        // GET: CustomerController1
        public ActionResult Index()
        {
            List<CustomerModel> list = new List<CustomerModel>();

            Bcustomer bCustomer = new Bcustomer();

            List<Cliente> customers = bCustomer.BuscarPorNombre();

            List<CustomerModel> models = new List<CustomerModel>();

            Console.WriteLine(customers);
            models = customers.Select(x=> new CustomerModel
                {
                Id= x.CustomerID,
                Name = x.Name,
                Phone = x.Phone
            }).ToList();

            return View(list);
        }

        // GET: CustomerController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
