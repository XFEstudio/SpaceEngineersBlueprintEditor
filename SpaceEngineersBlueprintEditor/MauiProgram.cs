using Microsoft.Extensions.Logging;
using SpaceEngineersBlueprintEditor.Model;
using XFE各类拓展.NetCore.ProfileExtension;

namespace SpaceEngineersBlueprintEditor;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        XFEProfile.ProfilesRootPath = AppPath.ProfileSavePath;
        XFEProfile.LoadProfiles(typeof(AppSystemProfile));
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
