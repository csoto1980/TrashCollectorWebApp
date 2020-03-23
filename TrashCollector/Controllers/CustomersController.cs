using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.ActionFilters;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    [Authorize]
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
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Customer.Include(c => c.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer

                .FirstOrDefaultAsync(m => m.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,StreetAddress,City,State,ZipCode, IndentityUserId")] Customer customer, Account account) //,Pickup pickup)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Account newAccount = new Account()
                    {
                        Id = account.Id,
                        Balance = account.Balance
                    };
                    //Pickup newPickSchedule = new Pickup()
                    //{
                    //    PickupId = pickup.PickupId,
                    //    PickupDay = pickup.PickupDay,
                    //    OneDayPickup = pickup.OneDayPickup,
                    //    TempSuspend = pickup.TempSuspend,
                    //    StartSuspend = pickup.StartSuspend,
                    //    EndSuspend = pickup.EndSuspend
                    //};
                    _context.Account.Add(newAccount);
                    //_context.Pickup.Add(newPickSchedule);
                    _context.SaveChanges();
                    Customer newCustomer = new Customer()
                    {
                        IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier),
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        AccountId = newAccount.Id,
                        //PickupId = newPickSchedule.PickupId,
                    };
                    _context.Customer.Add(newCustomer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
                //    _context.Add(customer);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
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
            if (id != customer.Id)
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
                    if (!CustomerExists(customer.Id))
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
            else
            {
                
            }

            var customer = await _context.Customer

                .FirstOrDefaultAsync(m => m.Id == id);

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
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}
