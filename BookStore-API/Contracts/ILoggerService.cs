using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Contracts
{
    public interface ILoggerService
    {
        void logInfo(string message);

        void logWarn(string message);
        void logDebug(string message);
        void logError(string message);

    }
}
