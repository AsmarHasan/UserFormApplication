using Microsoft.Extensions.Logging;
using TestApplication.Core.Helpers;
using TestApplication.Core.Models;
using TestApplication.Data.Models;
using TestApplication.Data.Repositories;

namespace TestApplication.Core.Interactors
{
    public class UserInteractor : IUserInteractor
    {
        public readonly IUserRepository _userRepository;
        public readonly ISectorRepository _sectorRespository;
        private readonly ILogger<UserInteractor> _logger;

        public UserInteractor(IUserRepository userRepository, ISectorRepository sectorRespository, ILogger<UserInteractor> logger)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _sectorRespository = sectorRespository ?? throw new ArgumentNullException(nameof(sectorRespository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task SaveUserData(UserModel userData)
        {
            if (userData == null)
            {
                _logger.LogError("UserData is null");

                throw new ArgumentNullException(nameof(userData));
            }

            var allSectors = await _sectorRespository.GetSectorsAsync();

            var user = new User
            {
                Name = userData.Name,
                AgreedToTerms = userData.AgreedToTerms,
                SessionID = userData.SessionId,
                UserSector = UserInteractorHelper.MapToUserSector(allSectors, userData.SelectedSectorCodes)
            };


            var savedUser = await _userRepository.SaveUserAsync(user);

            _logger.LogInformation($"User data saved: {savedUser}");
        }

        public async Task<UserModel?> GetUserData(string sessionId)
        {
            var user = await _userRepository.GetUserAsync(sessionId);

            if (user == null)
            {
                return null;
            }
            var allSectors = await _sectorRespository.GetSectorsAsync();

            return new UserModel
            {
                Name = user.Name,
                AgreedToTerms = user.AgreedToTerms,
                SessionId = sessionId,
                SelectedSectorCodes = UserInteractorHelper.GetSelectedSectorCodes(allSectors, user.UserSector)
            };
        }
    }
}
