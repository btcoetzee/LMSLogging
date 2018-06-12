using System;
using System.Collections.Generic;
using System.Text;

namespace Logging.Interface
{
    public interface ILoggerObject
    {
        // Name of Soluction
        string SolutionContext { get; set; }

        // Name of Process
        string ProcessContext { get; set; }

        // Operation being logged
        string OperationContext { get; set; }

    }
}
