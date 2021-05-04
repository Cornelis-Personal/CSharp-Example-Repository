using Cornelis.Examples.Services.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Cornelis.Examples.Services.Model
{
    /// <summary>
    /// A service that handles exceptions.
    ///
    /// Usually instead of a custom service I would use an existing package such as NLog.
    ///
    /// This service only services to show the workflow and uses of a logger.
    /// </summary>
    public class LoggerService : ILoggerService
    {
        private readonly string _path;

        public LoggerService(string path)
        {
            _path = path;
        }

        public void LogException(Exception e)
        {
            using (var sw = new StreamWriter(_path, append: true))
            {
                sw.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {e.Message} {Environment.NewLine} { e.InnerException} ");
                sw.Close();
            }
        }
    }
}