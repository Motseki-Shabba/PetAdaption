using PetAdaption.Debugging;

namespace PetAdaption;

public class PetAdaptionConsts
{
    public const string LocalizationSourceName = "PetAdaption";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "2de237ddce1840b28d110bec7325a10d";
}
