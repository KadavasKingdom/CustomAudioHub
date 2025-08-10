# CustomAudioHub
Simply a Hub for all custom audio file paths (Using AudioPlayerAPI). Allows plugins to reference this so you only need to change the file path here instead of everywhere! Yay!

How to use:
1) Install into your server like a regular plugin and reference this in plugins like you would normally for anything else.

2) In your plugin use "CustomAudioHub.Main.Instance.MakeFilePath([MAKE THIS YOUR AUDIO NAME])" or something like "CustomAudioHub.Main.Instance.MakeFilePath(Instance.Config.AlarmSFX)"

3) Update your config's:
	a) Update CustomAudioHub config to contain the entire file path to your CustomAudio folder, i.e. "C:\Users\JimmyJoe\AppData\Roaming\SCP Secret Laboratory\LabAPI\configs\global\CustomAudio".
	b) Update your personal plugin config (if you're loading your audio file name via config, which you should) file name i.e. "alarmaudio" or "alarmaudio.ogg", it doesn't matter.
	
4) It works! (as long as you know how to use AudioPlayerAPI and actually set up your audio)

5) Now every time you want to move files from your local server to another server you don't need to edit anything as long as the CustomAudioHub file path is correct!