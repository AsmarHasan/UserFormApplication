using TestApplication.Core.Interactors;
using TestApplication.Core.Models;
using TestApplication.Models;

namespace TestApplication.Web.Helpers
{
    public class HomeControllerHelper
    {
        private readonly ILogger<HomeControllerHelper> _logger;
        private IHttpContextAccessor _httpContext;
        private IUserInteractor _userInteractor;
        private ISectorInteractor _sectorInteractor;
        public HomeControllerHelper(ILogger<HomeControllerHelper> logger, IHttpContextAccessor httpContext, IUserInteractor userInteractor, ISectorInteractor sectorInteractor)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _httpContext = httpContext ?? throw new ArgumentNullException(nameof(httpContext));
            _userInteractor = userInteractor ?? throw new ArgumentNullException(nameof(userInteractor));
            _sectorInteractor = sectorInteractor ?? throw new ArgumentNullException(nameof(sectorInteractor));
        }
        public UserModel MapToUserModel(FormViewModel viewModel, string sessionId)
        {
            if (viewModel == null)
            {
                _logger.LogError("FormViewmodel is null");
                throw new ArgumentNullException(nameof(viewModel));
            }
            return new UserModel
            {
                Name = viewModel.Name,
                SessionId = sessionId,
                AgreedToTerms = viewModel != null && viewModel.AgreedToTerms,
                SelectedSectorCodes = viewModel.SelectedSectors
            };
        }

        public async Task<FormViewModel> MapToFormViewModel(string? sessionId)
        {
            if (sessionId != null)
            {
                var userModel = await _userInteractor.GetUserData(sessionId);
                if (userModel != null)
                {
                    return new FormViewModel()
                    {
                        AgreedToTerms = userModel.AgreedToTerms,
                        Name = userModel.Name,
                        Sectors = await _sectorInteractor.GetSectors(userModel?.SelectedSectorCodes)
                    };
                }
            }
            return new FormViewModel()
            {
                Sectors = await _sectorInteractor.GetSectors(new List<int>())
            };
        }

        public async Task<FormViewModel> MapToFormViewModel(FormViewModel? viewModel)
        {
            return new FormViewModel()
            {
                AgreedToTerms = viewModel.AgreedToTerms,
                Name = viewModel.Name,
                Sectors = await _sectorInteractor.GetSectors(viewModel.SelectedSectors)
            };
        }

        public string? GetSessionId()
        {
            return _httpContext.HttpContext?.Session?.GetString("sessionId");
        }

        public void SetSessionId()
        {
            _httpContext.HttpContext?.Session?.SetString("sessionId", Guid.NewGuid().ToString());
        }
    }
}
