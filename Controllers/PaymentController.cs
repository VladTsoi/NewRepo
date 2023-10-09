using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ApplicationContext db;

        public PaymentController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Payments.ToListAsync());
        }

    }
}
