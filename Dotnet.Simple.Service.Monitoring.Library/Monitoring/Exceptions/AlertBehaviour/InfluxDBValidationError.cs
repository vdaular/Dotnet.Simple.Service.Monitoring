﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dotnet.Simple.Service.Monitoring.Library.Monitoring.Exceptions.AlertBehaviour
{
    public class InfluxDbValidationError : Exception
    {
        public InfluxDbValidationError(string message) : base(message)
        {
        }
    }
}
