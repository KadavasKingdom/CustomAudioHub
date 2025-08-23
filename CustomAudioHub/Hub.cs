using LabApi.Loader.Features.Paths;

namespace CustomAudioHub;

public static class Hub
{
    public static readonly DirectoryInfo AudioHubDir = PathManager.Configs.CreateSubdirectory("global").CreateSubdirectory("AudioHub");
    /// <summary>
    /// Combines the file name with the file path, your file name doesn't need to contain .ogg, if it doesn't it'll be added for you.
    /// </summary>
    public static string MakeFilePath(string audioName = "ExampleAudio", string audioType = ".ogg")
    {
        return Path.Combine(AudioHubDir.FullName, audioName.Contains(audioType) ? audioName : $"{audioName}{audioType}");
    }
}
