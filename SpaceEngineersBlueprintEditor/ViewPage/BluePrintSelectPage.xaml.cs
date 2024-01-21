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
        set { storageType = value; Title = $"ѡ��{StorageType}"; }
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
                    await DisplayAlert("�������", $"�ܹ����أ�{Blueprints.Count}����ͼ", "ȷ��");
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