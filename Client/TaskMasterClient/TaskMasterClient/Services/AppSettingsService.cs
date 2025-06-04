namespace TaskMasterClient.Services;

public class AppSettingsService
{
    public AppSettingsService()
    {
    }
    public void Clear()
    {
        Preferences.Clear();
    }

    public void Clear(string sharedName)
    {
        Preferences.Clear(sharedName);
    }

    public bool ContainsKey(string key)
    {
        return Preferences.ContainsKey(key);
    }

    public bool ContainsKey(string key, string sharedName)
    {
        return Preferences.ContainsKey(key, sharedName);
    }

    public string Get(string key, string defaultValue)
    {
        return Preferences.Get(key, defaultValue);
    }

    public string Get(string key, string defaultValue, string sharedName)
    {
        return Preferences.Get(key, defaultValue, sharedName);
    }

    public void Remove(string key)
    {
        Preferences.Remove(key);
    }

    public void Remove(string key, string sharedName)
    {
        Preferences.Remove(key, sharedName);
    }

    public void Set(string key, string value)
    {
        Preferences.Set(key, value);
    }

    public void Set(string key, string value, string sharedName)
    {
        Preferences.Set(key, value, sharedName);
    }
    public bool Get(string key, bool defaultValue)
    {
        return bool.Parse(Get(key, defaultValue.ToString()));
    }
    public int Get(string key, int defaultValue)
    {
        return int.Parse(Get(key, defaultValue.ToString()));
    }
    public double Get(string key, double defaultValue)
    {
        return double.Parse(Get(key, defaultValue.ToString()));
    }
    public float Get(string key, float defaultValue)
    {
        return float.Parse(Get(key, defaultValue.ToString()));
    }
    public long Get(string key, long defaultValue)
    {
        return long.Parse(Get(key, defaultValue.ToString()));
    }
    public DateTime Get(string key, DateTime defaultValue)
    {
        return DateTime.Parse(Get(key, defaultValue.ToString()));
    }
    public bool Get(string key, bool defaultValue, string sharedName)
    {
        return bool.Parse(Get(key, defaultValue.ToString(), sharedName));
    }
    public int Get(string key, int defaultValue, string sharedName)
    {
        return int.Parse(Get(key, defaultValue.ToString(), sharedName));
    }
    public double Get(string key, double defaultValue, string sharedName)
    {
        return double.Parse(Get(key, defaultValue.ToString(), sharedName));
    }
    public float Get(string key, float defaultValue, string sharedName)
    {
        return float.Parse(Get(key, defaultValue.ToString(), sharedName));
    }
    public long Get(string key, long defaultValue, string sharedName)
    {
        return long.Parse(Get(key, defaultValue.ToString(), sharedName));
    }
    public DateTime Get(string key, DateTime defaultValue, string sharedName)
    {
        return DateTime.Parse(Get(key, defaultValue.ToString(), sharedName));
    }
    public void Set(string key, object value)
    {
        Set(key, value.ToString());
    }
    public void Set(string key, bool value)
    {
        Set(key, value.ToString());
    }
    public void Set(string key, int value)
    {
        Set(key, value.ToString());
    }
    public void Set(string key, double value)
    {
        Set(key, value.ToString());
    }
    public void Set(string key, float value)
    {
        Set(key, value.ToString());
    }
    public void Set(string key, long value)
    {
        Set(key, value.ToString());
    }
    public void Set(string key, bool value, string sharedName)
    {
        Set(key, value.ToString(), sharedName);
    }
    public void Set(string key, int value, string sharedName)
    {
        Set(key, value.ToString(), sharedName);
    }
    public void Set(string key, double value, string sharedName)
    {
        Set(key, value.ToString(), sharedName);
    }
    public void Set(string key, float value, string sharedName)
    {
        Set(key, value.ToString(), sharedName);
    }
    public void Set(string key, long value, string sharedName)
    {
        Set(key, value.ToString(), sharedName);
    }
    public void Set(string key, DateTime value)
    {
        Set(key, value.ToString());
    }
    public void Set(string key, DateTime value, string sharedName)
    {
        Set(key, value.ToString(), sharedName);
    }

    public bool ShownWelcome
    {
        get { return Get(nameof(ShownWelcome), false); }
        set { Set(nameof(ShownWelcome), value); }
    }
}
