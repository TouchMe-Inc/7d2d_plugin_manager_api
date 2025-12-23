using System;
using System.Globalization;

namespace PluginManager.Api.Capabilities.Implementations.Translations;

public sealed class WithTemporaryCulture : IDisposable
{
    private readonly CultureInfo _originalCulture;

    public WithTemporaryCulture(CultureInfo culture)
    {
        _originalCulture = CultureInfo.CurrentCulture;
        SetCulture(culture);
    }

    private void SetCulture(CultureInfo cultureInfo)
    {
        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;
    }

    public void Dispose()
    {
        SetCulture(_originalCulture);
    }
}