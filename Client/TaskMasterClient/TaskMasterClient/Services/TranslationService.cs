using System.Globalization;

namespace TaskMasterClient.Services;

public class TranslationService
{
    private readonly CultureInfo _cultureInfo;
    private static TranslationService _instance;
    public static TranslationService Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new TranslationService();
            }
            return _instance;
        }
    }


    private TranslationService()
    {
    }

    public string Translate(string source, string defaultValue = "")
    {
        string translation = null;
        if (string.IsNullOrEmpty(source))
            return string.Empty;
        // perform translation
        translation ??= defaultValue;
        return translation;
    }
}
