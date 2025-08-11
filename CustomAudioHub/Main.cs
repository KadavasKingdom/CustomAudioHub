using LabApi.Loader.Features.Plugins;
using LabApi.Loader.Features.Plugins.Enums;
using System;
using System.IO;

namespace CustomAudioHub;

public class Main : Plugin<Config>
{
    public static Main Instance { get; private set; }
    #region Plugin Info
    public override string Author => "Kadava";
    public override string Name => "CustomAudioHub";
    public override Version Version => new Version(0, 1);
    public override string Description => "Main directory for custom audio storage.";
    public override Version RequiredApiVersion => LabApi.Features.LabApiProperties.CurrentVersion;
    public override LoadPriority Priority => LoadPriority.High;
    #endregion
    public override void Enable()
    {
        Instance = this;
    }
    public override void Disable()
    {
        Instance = null;
    }
    /// <summary>
    /// Combines the file name with the file path, your file name doesn't need to contain .ogg, if it doesn't it'll be added for you.
    /// </summary>
    public static string MakeFilePath(string audioName = "ExampleAudio") 
    {
        // Should not we rename this to GetFilePath since it doesnt make it.

        // We should always have this enabled, otherwise it will not work!
        if (Main.Instance == null)
            return string.Empty; // Maybe get the assembly and backtrack from there?

        // Combine with Path.Combine! otherwise when using linux and win, the slashes (/) can be fucked up.
        return Path.Combine(Main.Instance.Config.AudioFilePath, audioName.Contains(".ogg") ? audioName : $"{audioName}.ogg");
    }
}