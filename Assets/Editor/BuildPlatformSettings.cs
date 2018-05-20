﻿#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class BuildPlatformSettings : MonoBehaviour
{
    [MenuItem("LightBuzz/Apply Build Settings for.../Android")]
    private static void BuildSettings_Android()
    {
        SetBuildSettings(BuildTargetGroup.Android, BuildTarget.Android, ScriptingImplementation.Mono2x);
    }

    [MenuItem("LightBuzz/Apply Build Settings for.../iOS")]
    private static void BuildSettings_iOS()
    {
        SetBuildSettings(BuildTargetGroup.iOS, BuildTarget.iOS, ScriptingImplementation.IL2CPP);
    }

    [MenuItem("LightBuzz/Apply Build Settings for.../Windows Desktop")]
    private static void BuildSettings_Windows()
    {
        SetBuildSettings(BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows64, ScriptingImplementation.Mono2x);
    }

    [MenuItem("LightBuzz/Apply Build Settings for.../Mac OS X")]
    private static void BuildSettings_MacOSX()
    {
        SetBuildSettings(BuildTargetGroup.Standalone, BuildTarget.StandaloneOSX, ScriptingImplementation.Mono2x);
    }

    [MenuItem("LightBuzz/Apply Build Settings for.../UWP")]
    private static void BuildSettings_UWP()
    {
        EditorUserBuildSettings.wsaSubtarget = WSASubtarget.AnyDevice;

        SetBuildSettings(BuildTargetGroup.WSA, BuildTarget.WSAPlayer, ScriptingImplementation.WinRTDotNET);
    }

    [MenuItem("LightBuzz/Apply Build Settings for.../HoloLens")]
    private static void BuildSettings_HoloLens()
    {
        EditorUserBuildSettings.wsaSubtarget = WSASubtarget.HoloLens;

        SetBuildSettings(BuildTargetGroup.WSA, BuildTarget.WSAPlayer, ScriptingImplementation.WinRTDotNET);
    }

    private static void SetBuildSettings(BuildTargetGroup group, BuildTarget target, ScriptingImplementation scripting)
    {
        PlayerSettings.SetScriptingBackend(group, scripting);
        PlayerSettings.scriptingRuntimeVersion = ScriptingRuntimeVersion.Latest;

        EditorUserBuildSettings.SwitchActiveBuildTarget(group, target);
    }

    [MenuItem("LightBuzz/Contact us")]
    private static void Contact()
    {
        Application.OpenURL("https://lightbuzz.com/contact");
    }

    [MenuItem("LightBuzz/GitHub")]
    private static void GitHub_Project()
    {
        Application.OpenURL("https://github.com/lightbuzz/azure-unity/");
    }

    [MenuItem("LightBuzz/Report a problem")]
    private static void GitHub_Issues()
    {
        Application.OpenURL("https://github.com/lightbuzz/azure-unity/issue/new");
    }
}
#endif