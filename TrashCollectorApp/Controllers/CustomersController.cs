using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollectorApp.ActionFilters;
using TrashCollectorApp.Data;
using TrashCollectorApp.Models;

namespace TrashCollectorApp.Controllers
{
    //[Authorize]
    [Authorize(Roles = "Customer")]
    //[ServiceFilter(typeof(GlobalRouting))]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public IActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var currentUser = _context.Customers.Include(c => c.Account).Include(c => c.Address).Where(c => c.IdentityUserId == userId).ToListAsync();
            return View(currentUser);
        }

        // GET: Customers/Details/5
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = await _context.Customers
                .Include(c => c.Account)
                .Include(c => c.Address)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        //[Authorize(Roles = "Customer")]
        
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Set<Account>(), "Id", "Id");
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customers)
        {
            if (ModelState.IsValid)
            {
                _context.Addresses.Add(customers.Address);
                _context.SaveChanges();
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customers.IdentityUserId = userId;
                _context.Add(customers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Set<Account>(), "Id", "Id", customers.AccountId);
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", customers.AddressId);
            return View(customers);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Set<Account>(), "Id", "Id", customers.AccountId);
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", customers.AddressId);
            return View(customers);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Customer customers)
        {
            if (id != customers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customers.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            ViewData["AccountId"] = new SelectList(_context.Set<Account>(), "Id", "Id", customers.AccountId);
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", customers.AddressId);
            return View(customers);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.Customers
                .Include(c => c.Account)
                .Include(c => c.Address)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
