using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoDUENoLootLimit
{
    public class ModConfig
    {
        public ConfigEntry<int> MapGoldCap { get; set; }
        public ConfigEntry<int> LootGoldCap { get; set; }
        public ConfigEntry<int> MonsterGoldCap { get; set; }

        public ModConfig(ConfigFile config)
        {
            MapGoldCap = config.Bind("Gold Caps", "MapGoldCap", 1000,
                "The maximum amount of gold that can be obtained from exploring the map.  Set to 0 for the game's default.");

            LootGoldCap = config.Bind("Gold Caps", "LootGoldCap", 1000,
                "The maximum amount of gold that can be obtained from loot (such as candlesticks).  Set to 0 for the game's default.");

            MonsterGoldCap = config.Bind("Gold Caps", "MonsterGoldCap", 1000,
                "The maximum amount of gold that can be obtained from killing monsters.  Set to 0 for the game's default.");
        }

    }
}
