using System.Collections.Generic;

namespace ThinkAM.StackOverflow.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
