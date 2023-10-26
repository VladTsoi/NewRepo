using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Calculator.Models;
using Microsoft.Data.SqlClient;

namespace Calculator.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ApplicationContext db;

        public PaymentController(ApplicationContext context)
        {
            db = context;
        }
        /// <summary>
        /// Сортировка и вывод данных таблицы
        /// </summary>
        /// <param name="sortOrder">Сортировка OwedBalance по-умолчанию</param>
        /// <returns></returns>

        public async Task<IActionResult> Index(SortState sortOrder = SortState.OwedBalanceAsc)
        {
            IQueryable<PaymentModel>? payments = db.Payments;

            ViewData["OwedBalanceSort"] = sortOrder == SortState.OwedBalanceAsc ? SortState.OwedBalanceDesc : SortState.OwedBalanceAsc;
            ViewData["PaymentBodySizeSort"] = sortOrder == SortState.PaymentBodySizeAsc ? SortState.PaymentBodySizeDesc : SortState.PaymentBodySizeAsc;
            ViewData["PaymentPercentSizeSort"] = sortOrder == SortState.PaymentPercentSizeAsc ? SortState.PaymentPercentSizeDesc : SortState.PaymentPercentSizeAsc;
            ViewData["PaymentDateSort"] = sortOrder == SortState.PaymentDateAsc ? SortState.PaymentDateDesc : SortState.PaymentDateAsc;
            ViewData["PrincipalBalanceSort"] = sortOrder == SortState.PrincipalBalanceAsc ? SortState.PrincipalBalanceDesc : SortState.PrincipalBalanceAsc;

            payments = sortOrder switch
            {
                SortState.PaymentBodySizeAsc => payments.OrderBy(s => s.PaymentBodySize),
                SortState.PaymentBodySizeDesc => payments.OrderByDescending(s => s.PaymentBodySize),
                SortState.PaymentPercentSizeAsc => payments.OrderBy(s => s.PaymentPercentSize),
                SortState.PaymentPercentSizeDesc => payments.OrderByDescending(s => s.PaymentPercentSize),
                SortState.PaymentDateAsc => payments.OrderBy(s => s.PaymentDate),
                SortState.PaymentDateDesc => payments.OrderByDescending(s => s.PaymentDate),
                SortState.PrincipalBalanceAsc => payments.OrderBy(s => s.PrincipalBalance),
                SortState.PrincipalBalanceDesc => payments.OrderByDescending(s => s.PrincipalBalance),
                SortState.OwedBalanceDesc => payments.OrderByDescending(s => s.OwedBalance),
                _ => payments.OrderBy(s => s.OwedBalance),
            };
            return View(await payments.AsNoTracking().ToListAsync());
        }

    }
}
