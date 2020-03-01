using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosDBTest
{

        using Microsoft.Extensions.Configuration;
        public class AppSettings
        {
            public string StorageConnectionString { get; set; }
            public static AppSettings LoadAppSettings()
            {
                IConfigurationRoot configRoot = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
                AppSettings appSettings = configRoot.Get<AppSettings>();
                return appSettings;
            }
        }
    
}
