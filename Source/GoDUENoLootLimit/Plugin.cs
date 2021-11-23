using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace GoDUENoLootLimit
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME,PluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Ultimate Dungeoneering.exe")]    //Make sure someone doesn't try to patch the non Ultimate verison.
    public class Plugin : BaseUnityPlugin
    {

        public static ModConfig ModConfig { get; set; }
        public static ManualLogSource Log = null;
        

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_NAME} is loaded!");
            ModConfig = new ModConfig(this.Config);
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
                    if(ModConfig.LootGoldCap.Value > 0)
                    {
                        quest.lootGoldCap = ModConfig.LootGoldCap.Value;
                    }

                    if (ModConfig.MapGoldCap.Value > 0)
                    {
                        quest.mapGoldCap = ModConfig.MapGoldCap.Value;
                    }

                    if (ModConfig.MonsterGoldCap.Value > 0)
                    {
                        quest.monsterGoldCap = ModConfig.MonsterGoldCap.Value;
                    }
                }
            }
        }
    }
}
