using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ThinkAM.StackOverflow.Localization
{
    public static class StackOverflowLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(StackOverflowConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(StackOverflowLocalizationConfigurer).GetAssembly(),
                        "ThinkAM.StackOverflow.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
