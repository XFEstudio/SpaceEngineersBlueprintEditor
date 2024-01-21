using SpaceEngineersBlueprintEditor.Model;

namespace SpaceEngineersBlueprintEditor.ViewPage;

[QueryProperty(nameof(StorageType), nameof(StorageType))]
[QueryProperty(nameof(BlueprintPath), nameof(BlueprintPath))]
public partial class BlueprintSelectPage : ContentPage
{
    private string storageType = string.Empty;

    public required string StorageType
    {
        get { return storageType; }
        set { storageType = value; Title = $"选择{StorageType}"; }
    }

    private string blueprintPath = string.Empty;

    public required string BlueprintPath
    {
        get { return blueprintPath; }
        set
        {
            blueprintPath = value;
            Task.Run(async () =>
            {
                Blueprint.LoadBlueprintsFrom(Blueprints, BlueprintPath);
                await Dispatcher.DispatchAsync(async () =>
                {
                    await DisplayAlert("加载完成", $"总共加载：{Blueprints.Count}个蓝图", "确认");
                    blueprintsListView.ItemsSource = Blueprints;
                });
            });
        }
    }
    public List<Blueprint> Blueprints { get; set; } = [];
    public BlueprintSelectPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void BlueprintsListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        
    }

    private void BlueprintsSearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        blueprintsListView.
    }
}