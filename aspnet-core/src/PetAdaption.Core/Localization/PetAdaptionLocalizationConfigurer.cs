using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PetAdaption.Localization;

public static class PetAdaptionLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(PetAdaptionConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(PetAdaptionLocalizationConfigurer).GetAssembly(),
                    "PetAdaption.Localization.SourceFiles"
                )
            )
        );
    }
}
