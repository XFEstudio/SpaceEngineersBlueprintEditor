using SpaceEngineersBlueprintEditor.ViewPage;

namespace SpaceEngineersBlueprintEditor;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(BlueprintEditorMainPage), typeof(BlueprintEditorMainPage));
        Routing.RegisterRoute(nameof(BlueprintSelectPage), typeof(BlueprintSelectPage));
    }
}
