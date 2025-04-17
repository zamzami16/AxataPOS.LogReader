using System;

namespace AxataPOS.LogReader;

public class Settings : IEquatable<Settings>
{
    public int BatchSize { get; set; } = 1000;

    public bool Equals(Settings other)
    {
        if (other == null)
            return false;

        var properties = GetType().GetProperties();

        foreach (var property in properties)
        {
            var thisValue = property.GetValue(this);
            var otherValue = property.GetValue(other);

            if (!thisValue.Equals(otherValue))
                return false;
        }

        return true;
    }

    #region <<static method>>
    private static Settings ReadSettings() => (new Settings()).Load();
    private static Settings _instance;
    public static Settings Instance => _instance ??= ReadSettings();
    #endregion <<static method>>
}

public static class SettingsExtension
{
    public static Settings Save(this Settings settings)
    {
        Properties.Settings.Default.BATCH_SIZE = settings.BatchSize;

        Properties.Settings.Default.Save();
        return settings;
    }

    public static Settings Load(this Settings settings)
    {
        settings.BatchSize = Properties.Settings.Default.BATCH_SIZE;

        return settings;
    }
}
