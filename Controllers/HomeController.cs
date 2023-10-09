using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index() => View();
        [HttpPost]
        public IActionResult Index(PaymentCreditModel paymentCredit)
        {
            if (paymentCredit.LoanSumm < 1 && paymentCredit.LoanDeadline < 1 && paymentCredit.PercentRate < 1)
                ModelState.AddModelError("", "Все значения должны быть положительными");
            if (ModelState.IsValid)
            {
                var paymentModules = Finance.Annuitet(paymentCredit.LoanSumm, paymentCredit.LoanDeadline, paymentCredit.PercentRate);
                foreach (var paymentModule in paymentModules)
                {
                    db.Payments.Add(paymentModule);
                }
                db.SaveChanges();
                return Redirect("~/Payment");
            }                
            return View(paymentCredit);
        }
    }
}