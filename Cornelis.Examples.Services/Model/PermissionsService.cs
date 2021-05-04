using Blazored.SessionStorage;
using Cornelis.Examples.DataAccess.Repositories.Interfaces;
using Cornelis.Examples.Models.Common;
using Cornelis.Examples.Models.Data;
using Cornelis.Examples.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Cornelis.Examples.Services.Model
{
    /// <summary>
    ///  This service handles user permissions and sessions.
    /// </summary>
    public class PermissionsService : IPermissionsService
    {
        #region Private Variables

        private IUserRepository UserRepository { get; }
        private IRoleRepository RoleRepository { get; }
        private ISessionStorageService SessionStorageService { get; }
        private ILoggerService Logger { get; }

        #endregion Private Variables

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="userRepository"></param>
        /// <param name="roleRepository"></param>
        public PermissionsService(
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            ISessionStorageService sessionStorageService,
            ILoggerService logger)
        {
            UserRepository = userRepository;
            RoleRepository = roleRepository;
            SessionStorageService = sessionStorageService;
            Logger = logger;
        }

        #endregion Constructors

        #region Public Functions

        /// <summary>
        /// Returns of the user is logged in.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> IsLoggedIn()
        {
            try
            {
                var user = await SessionStorageService.GetItemAsync<string>(Constants.User);
                return !string.IsNullOrWhiteSpace(user);
            }
            // We catch exceptions individually
            // this gives better control if we later
            // need to handle each situation differnt
            // and is concidered best practice.
            catch (NullReferenceException e)
            {
                Logger.LogException(e);
            }
            catch (Exception e)
            {
                Logger.LogException(e);
            }

            return false;
        }

        /// <summary>
        /// Add a new user to the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<bool> RegisterUser(string username, string password)
        {
            var user = new User()
            {
                Username = username,
                Password = password,
                Role = string.Empty,
            };

            // We return if the number of rows affected is equal 1.
            // 0 Means the user already exists.
            return await UserRepository.InsertEntityAsync(user) == 1;
        }

        /// <summary>
        /// Acccess the session storage to log the user in.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await UserRepository.GetByKeyAsync(username);

            if (user == null || !string.Equals(password, user.Password))
            {
                return false;
            }

            await SessionStorageService.SetItemAsync(Constants.User, user.Username);

            return true;
        }

        #endregion Public Functions
    }
}