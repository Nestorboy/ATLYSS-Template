using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace ExampleUser.TemplateMod;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInProcess("ATLYSS.exe")]
public class TemplateModPlugin : BaseUnityPlugin
{
    internal new static ManualLogSource Logger;

    private void Awake()
    {
        Logger = base.Logger;

        new Harmony(MyPluginInfo.PLUGIN_GUID).PatchAll();
        
        Logger.LogInfo("Hello World");
    }
}