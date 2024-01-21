namespace SpaceEngineersBlueprintEditor.Model;

public class Blueprint(string name, ImageSource image, string path)
{
    public string Name { get; set; } = name;
    public ImageSource Image { get; set; } = image;
    public string FullPath { get; set; } = path;
    public static void LoadBlueprintsFrom(List<Blueprint> blueprints, string path)
    {
        foreach (var folderFullPath in Directory.GetDirectories(path))
        {
            var blueprint = new Blueprint(Path.GetFileName(folderFullPath)!, ImageSource.FromFile($"{folderFullPath}/thumb.png"), folderFullPath);
            blueprints.Add(blueprint);
        }
    }
}
