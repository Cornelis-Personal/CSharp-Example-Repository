using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cornelis.Examples.Services.Interfaces
{
    /// <summary>
    /// A service that handles exceptions.
    /// </summary>
    public interface ILoggerService
    {
        /// <summary>
        /// Log an exception.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        void LogException(Exception e);
    }
}