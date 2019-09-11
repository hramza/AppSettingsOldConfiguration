using Microsoft.Extensions.Configuration;

namespace AppSettingsLoader.OldConfiguration
{
    public static class ConfigurationExtensions
    {
        public static IConfigurationBuilder AddAppSettingsFromWebConfig(this IConfigurationBuilder configurationBuilder, string configFilePath = null)
        {
            return configurationBuilder.Add(new AppSettingsConfigurationSource(configFilePath));
        }
    }
}