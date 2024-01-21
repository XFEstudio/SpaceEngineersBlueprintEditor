namespace SpaceEngineersBlueprintEditor.Model;

public static class AppPath
{
    public static string ProfileSavePath { get; } = $"{FileSystem.Current.AppDataDirectory}/Profiles";
    public static string SpaceEngineersRootPath { get; } = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/SpaceEngineers";
    public static string SavesRootPath { get; } = $"{SpaceEngineersRootPath}/Saves";
    public static class BlueprintsPath
    {
        public static string Root { get; } = $"{SpaceEngineersRootPath}/Blueprints";
        public static string Local { get; } = $"{Root}/local";
        public static string Cloud { get; } = $"{Root}/cloud";
        public static string WorkShop { get; } = $"{Root}/workshop/temp/Steam";
    }
}