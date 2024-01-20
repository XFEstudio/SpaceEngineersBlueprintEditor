using SpaceEngineersBlueprintEditor.Model;
using SpaceEngineersBlueprintEditor.Resources.Theme;

namespace SpaceEngineersBlueprintEditor;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Current!.RequestedThemeChanged += (s, a) =>
        {
            if (Current!.UserAppTheme != AppTheme.Unspecified)
                AppSystemProfile.Theme = a.RequestedTheme;
            AutoSwitchByTheme(a.RequestedTheme);
        };
        MainPage = new AppShell();
        AppSystemProfile.Theme = Current!.RequestedTheme;
        AutoSwitchByTheme(AppSystemProfile.Theme);
    }
    public static void SwitchToTheme(ResourceDictionary resourceDictionary)
    {
        if (Current is not null)
        {
            Current.Resources.MergedDictionaries.Clear();
            Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
    public static void AutoSwitchByTheme(AppTheme appTheme)
    {
        switch (appTheme)
        {
            case AppTheme.Unspecified:
                switch (Current!.RequestedTheme)
                {
                    case AppTheme.Unspecified:
                        SwitchToTheme(new LightTheme());
                        break;
                    case AppTheme.Light:
                        SwitchToTheme(new LightTheme());
                        break;
                    case AppTheme.Dark:
                        SwitchToTheme(new DarkTheme());
                        break;
                    default:
                        break;
                }
                break;
            case AppTheme.Light:
                SwitchToTheme(new LightTheme());
                break;
            case AppTheme.Dark:
                SwitchToTheme(new DarkTheme());
                break;
            default:
                break;
        }
    }
}
