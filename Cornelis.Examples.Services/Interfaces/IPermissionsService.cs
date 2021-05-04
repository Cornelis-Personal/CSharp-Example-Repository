using System.Threading.Tasks;

namespace Cornelis.Examples.Services.Interfaces
{
    /// <summary>
    /// This service handles user permissions and sessions.
    /// </summary>
    public interface IPermissionsService
    {
        /// <summary>
        /// Checks if the user has already logged in.
        /// </summary>
        /// <returns></returns>
        Task<bool> IsLoggedIn();

        /// <summary>
        /// Add a new user to the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> RegisterUser(string username, string password);

        /// <summary>
        /// Login the user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> LoginAsync(string username, string password);
    }
}