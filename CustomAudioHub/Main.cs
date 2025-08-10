using LabApi.Loader.Features.Plugins;
using LabApi.Loader.Features.Plugins.Enums;
using System;
namespace CustomAudioHub
{
    public class Main : Plugin<Config>
    {
        public static Main Instance { get; private set; }
        #region Plugin Info
        public override string Author => "Kadava";
        public override string Name => "CustomAudioHub";
        public override Version Version => new Version(0, 1);
        public override string Description => "main directory for custom audio storage.";
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
        public string MakeFilePath(string audioName = "ExampleAudio")
        {
            if(audioName.Contains(".ogg"))
                return $"{Main.Instance.Config.audioFilePath}/{audioName}";

            return $"{Main.Instance.Config.audioFilePath}/{audioName}.ogg";
        }
    }
}