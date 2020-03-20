using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.ActionFilters;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    [Authorize(Roles = "Customer")]
    [ServiceFilter(typeof(GlobalRouting))]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

     

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //customer.IdentityUserId = userId;
            //_context.Add(customer);
            //_context.SaveChanges();
            var customer = _context.Customer.Where(c => c.IdentityUserId == userId).SingleOrDefault(); //refer to page 12
            return View(await _context.Customer.ToListAsync());


        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
<<<<<<< HEAD:TrashCollector/Controllers/CustomersController.cs
                .FirstOrDefaultAsync(m => m.CustomerId == id);
=======
                .FirstOrDefaultAsync(m => m.Id == id);
>>>>>>> eb5413e08e1886fbe0b7f3b72a86df44676c3447:TrashCollectorProject1/Controllers/CustomersController.cs
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,StreetAddress,City,State,ZipCode,Balance,PickupDay")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,StreetAddress,City,State,ZipCode,Balance,PickupDay")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
<<<<<<< HEAD:TrashCollector/Controllers/CustomersController.cs
                .FirstOrDefaultAsync(m => m.CustomerId == id);
=======
                .FirstOrDefaultAsync(m => m.Id == id);
>>>>>>> eb5413e08e1886fbe0b7f3b72a86df44676c3447:TrashCollectorProject1/Controllers/CustomersController.cs
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
<<<<<<< HEAD:TrashCollector/Controllers/CustomersController.cs
            return _context.Customer.Any(e => e.CustomerId == id);
=======
            return _context.Customer.Any(e => e.Id == id);
>>>>>>> eb5413e08e1886fbe0b7f3b72a86df44676c3447:TrashCollectorProject1/Controllers/CustomersController.cs
        }
    }
}
