using Microsoft.AspNetCore.Mvc;
using TestApplication.Core.Interactors;
using TestApplication.Models;
using TestApplication.Web.Helpers;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserInteractor _userInteractor;
        private HomeControllerHelper _homeHelper;

        public HomeController(ILogger<HomeController> logger, IUserInteractor userInteractor, HomeControllerHelper homeHelper)
        {
            _logger = logger;
            _userInteractor = userInteractor ?? throw new ArgumentNullException(nameof(userInteractor));
            _homeHelper = homeHelper ?? throw new ArgumentNullException(nameof(homeHelper));
        }
        public async Task<IActionResult> Index()
        {
            var existingSessionId = _homeHelper.GetSessionId();

            var model = await _homeHelper.MapToFormViewModel(existingSessionId);

            if (existingSessionId == null)
            {
                _homeHelper.SetSessionId();

                _logger.LogInformation("New session started");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(FormViewModel viewModel)
        {
            var sessionId = _homeHelper.GetSessionId();

            if (sessionId != null && ModelState.IsValid)
            {
                await _userInteractor.SaveUserData(_homeHelper.MapToUserModel(viewModel, sessionId));
            }
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid model states");

                var model = await _homeHelper.MapToFormViewModel(viewModel);

                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}