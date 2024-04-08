using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stripe.BillingPortal;
using Stripe.Checkout;

namespace Instagram_Clone.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly AppDbContext appDbContext;
        private readonly IExerciseService exerciseService;
        public SubscriptionController(UserManager<User> userManager, AppDbContext appDbContext, IExerciseService exerciseService)
        {
            this.userManager = userManager;
            this.appDbContext = appDbContext;
            this.exerciseService = exerciseService;
        }

        public IActionResult SubscriptionPage()
        {
            return View();
        }

        [HttpPost("removesubscription")]

        public async Task<IActionResult> RemoveSubscription() {
            await exerciseService.RemoveSubscription();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> CheckOutConfirmation()
        {
            var service = new Stripe.Checkout.SessionService();
            Stripe.Checkout.Session session = service.Get(TempData["Session"].ToString());

            string planType = "Basic";
            double planPrice = (double)(session.AmountTotal / 100m);

            var user = await userManager.GetUserAsync(User);
            
            

            var subscription = new Subscription();
            user.DailyLimit = 10;
            subscription.PlanType = planType;
            subscription.PlanPrice = planPrice;
            user.HasSubscription = true;
            user.BoughtSubscriptionName = subscription.PlanType;

        await    appDbContext.SaveChangesAsync();   
            
            

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> StripeCheckOut()
        {

            var subscriptions = await exerciseService.GetSubscriptionsAsync();
            var domain = "https://localhost:7283/";
            var options = new Stripe.Checkout.SessionCreateOptions
            {
                SuccessUrl = domain + $"Subscription/CheckOutConfirmation",
                CancelUrl = domain + "Home/Index",
                LineItems = new List<SessionLineItemOptions>(),
                Mode = "payment",

                CustomerEmail = "irakliberdzena314@gmail.com",
            };

            foreach (var subscription in subscriptions)
            {
                var sessionListItem = new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmount = (long)(subscription.PlanPrice * 100),
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = subscription.PlanType.ToString()
                        }

                    },
                    Quantity = 1,


                };
                options.LineItems.Add(sessionListItem);


            }
            var service = new Stripe.Checkout.SessionService();
            Stripe.Checkout.Session session = service.Create(options);
            TempData["Session"] = session.Id;
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);

        }
    }
}
