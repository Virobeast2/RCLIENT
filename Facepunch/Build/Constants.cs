namespace Facepunch.Build
{
    using System;

    public static class Constants
    {
        public const string AssetBundleExtension = ".unity3d";
        public const string BunchedSceneBundleFileName = "scenes.unity3d";
        public const string EditorBundleFileName = "editorbundle.txt";
        public const int ExitCode_BuildFailureException = 500;
        public const int ExitCode_BuildProjectFormattingException = 0x1f6;
        public const int ExitCode_FileNotFound = 0x194;
        public const int ExitCode_MissingArguments = 300;
        public const int ExitCode_NoError = 0;
        public const int ExitCode_OtherException = 0x1f7;
        public const string Key_ConnectCommand = "FACEPUNCH_BUILD_CONNECT_COMMAND";
        public const string Key_PathToBuiltServer = "FACEPUNCH_BUILD_PATH_TO_BUILT_SERVER";
        public const string Key_PathToBuiltWebplayer = "FACEPUNCH_BUILD_PATH_TO_BUILT_WEBPLAYER";
        public const string ManifestFileName = "manifest.txt";
        public const string SharedSceneBundleFileName = "scene.shared.unity3d";
        public const string UniqueSceneBundleFileName = "scene.specific.unity3d";
    }
}

