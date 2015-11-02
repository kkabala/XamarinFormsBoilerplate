namespace XamarinDDDTemplate.Infrastructure.Utilities
{
    public interface IPathManager
    {
        string GetOfflineDocumentsPath();

        string GetApplicationPath();

        string GetOfflineImagesPath();
    }
}