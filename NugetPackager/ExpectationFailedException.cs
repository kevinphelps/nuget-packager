﻿using System;

namespace NugetPackager
{
    [Serializable]
    public class ExpectationFailedException : Exception
    {
        public ExpectationFailedException(string message)
            : base(message)
        {
        }
    }
}
