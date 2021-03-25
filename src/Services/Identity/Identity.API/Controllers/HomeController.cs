using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopOnContainers.Services.Identity.API.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
//using Microsoft.eShopOnContainers.Services.Identity.API.Models;

namespace Microsoft.eShopOnContainers.Services.Identity.API.Controllers
{
    // public class HomeController : Controller
    // {
    //     private readonly IIdentityServerInteractionService _interaction;
    //     private readonly IOptionsSnapshot<AppSettings> _settings;
    //     private readonly IRedirectService _redirectSvc;

    //     public HomeController(IIdentityServerInteractionService interaction, IOptionsSnapshot<AppSettings> settings, IRedirectService redirectSvc)
    //     {
    //         _interaction = interaction;
    //         _settings = settings;
    //         _redirectSvc = redirectSvc;
    //     }

    //     public IActionResult Index(string returnUrl)
    //     {
    //         return View();
    //     }

    //     public IActionResult ReturnToOriginalApplication(string returnUrl)
    //     {
    //         if (returnUrl != null)
    //             return Redirect(_redirectSvc.ExtractRedirectUriFromReturnUrl(returnUrl));
    //         else
    //             return RedirectToAction("Index", "Home");
    //     }

    //     /// <summary>
    //     /// Shows the error page
    //     /// </summary>
    //     public async Task<IActionResult> Error(string errorId)
    //     {
    //         var vm = new ErrorViewModel();

    //         // retrieve error details from identityserver
    //         var message = await _interaction.GetErrorContextAsync(errorId);
    //         if (message != null)
    //         {
    //             vm.Error = message;
    //         }

    //         return View("Error", vm);
    //     }
    // }

    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}