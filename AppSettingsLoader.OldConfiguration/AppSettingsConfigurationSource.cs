using Microsoft.Extensions.Configuration;

namespace AppSettingsLoader.OldConfiguration
{
    public class AppSettingsConfigurationSource : FileConfigurationSource
    {
        private const string DefaultFilename = "web.config";

        public AppSettingsConfigurationSource(string filePath)
        {
            Path = filePath ?? DefaultFilename;
            FileProvider = null;
            Optional = true;
            ReloadOnChange = true;
        }

        public override IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            EnsureDefaults(builder);
            return new AppSettingsConfigurationProvider(this);
        }
    }
}