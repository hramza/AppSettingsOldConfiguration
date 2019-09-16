using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace AppSettingsLoader.OldConfiguration
{
    public class AppSettingsConfigurationProvider : FileConfigurationProvider
    {
        const string DefaultXmlPath = "/configuration/appSettings/add";

        public AppSettingsConfigurationProvider(AppSettingsConfigurationSource configurationSource) : base(configurationSource)
        {
        }

        public override void Load(Stream stream)
        {
            try
            {
                if (stream?.Length > 0)
                {
                    XmlDocument document = new XmlDocument();
                    document.Load(stream);

                    var result = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                    foreach (XmlNode node in document.SelectNodes(DefaultXmlPath))
                    {
                        result[node.Attributes["key"].Value] = node.Attributes["value"].Value;
                    }

                    Data = result;
                }
            }
            catch
            {
                throw new FormatException("Cannot read the config file");
            }
        }
    }
}