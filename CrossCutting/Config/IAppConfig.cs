using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Config
{
    public interface IAppConfig
    {
        string ServiceUrl { get; }
    }
}
