using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace GoDUENoLootLimit
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        public static ManualLogSource Log = null;

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} is loaded!");
            Harmony.CreateAndPatchAll(typeof(Plugin));
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} is patched!");
        }

        [HarmonyPatch(typeof(QuestManager), "parseRegion")]
        [HarmonyPostfix]
        static public void ParseRegionUnlimitedGoldCap(RegionData rd)
        {
            foreach (var adventure in rd.adventures)
            {
                foreach (var quest in adventure.quests)
                {
                    quest.lootGoldCap = 1000;        //max out loot limit
                }
            }
        }
    }
}
