using XFE各类拓展.NetCore.ProfileExtension;

namespace SpaceEngineersBlueprintEditor.Model;

public static class AppSystemProfile
{
    private static AppTheme theme;

    [ProfileProperty]
    public static AppTheme Theme
    {
        get { return theme; }
        set { theme = value; XFEProfile.SaveProfile(typeof(AppSystemProfile)); }
    }

}
