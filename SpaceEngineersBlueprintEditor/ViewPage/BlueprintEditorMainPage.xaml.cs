using SpaceEngineersBlueprintEditor.Model;

namespace SpaceEngineersBlueprintEditor.ViewPage;

public partial class BlueprintEditorMainPage : ContentPage
{
	public BlueprintEditorMainPage()
	{
		InitializeComponent();
	}

    private async void LocalBlueprintsButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(BlueprintSelectPage)}?{nameof(BlueprintSelectPage.StorageType)}=������ͼ&{nameof(BlueprintSelectPage.BlueprintPath)}={AppPath.BlueprintsPath.Local}");
    }

    private async void CloudBlueprintsButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(BlueprintSelectPage)}?{nameof(BlueprintSelectPage.StorageType)}=�ƶ���ͼ&{nameof(BlueprintSelectPage.BlueprintPath)}={AppPath.BlueprintsPath.Cloud}");
    }

    private async void WorkShopBlueprintsButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(BlueprintSelectPage)}?{nameof(BlueprintSelectPage.StorageType)}=���⹤����ͼ&{nameof(BlueprintSelectPage.BlueprintPath)}={AppPath.BlueprintsPath.WorkShop}");
    }
}