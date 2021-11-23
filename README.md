# GoDUENoLootLimit
Mod for Guild of Dungeoneering Ultimate Edition which removes the loot gold cap.

Note - this is only for the Ultimate Edition.  The standard edition has no caps.

Getting a bit behind in the start of the game?  Tired of the paltry 15 gold per quest when saving up for the next 750 gold upgrade?

Well toil no longer!  This mod changes the gold limit for the quests to 1000!  
Want to collect enough candlesticks to walk from New York to the UK?  Knock yourself out!

Want to have custom caps for the map exploration, loot, and monster gold?  Simply change the values in the config file.

# Game Update
The developer has added an option to change the gold caps to 5x the normal cap.  If that option is enabled, the gold cap will be 5x of what this mod is set to (15,000 by default).


# Installation

1. Download the BepInEx utility from https://github.com/BepInEx/BepInEx/releases/download/v5.4.17/BepInEx_x64_5.4.17.0.zip
2. Extract the contents of the zip file into the game's directory (which is GuildofDungeoneeringUlt)
	- There should now be a BepinEx folder in the GuildofDungeoneeringUlt game directory.
3. Run the game and exit once the main screen is shown.
4. If BepInEx ran correctly, there should now be BepInEx\plugins directory in the game directory.
5. Download the latest GoDUENoLootLimit.dll from here:  https://github.com/NBKRedSpy/GoDUENoLootLimit/releases
6. Copy the GoDUENoLootLimit.dll into the BepInEx\plugins directory.
7. Run the game.

During a quest, the maximum gold possible will now show a value over 1,000.

# Optional Configuration
After running the game with the plugin, there will be a config file called GoDUENoLootLimit.cfg located in the 
BepInEx\config\ folder which allows the user to customize the gold caps.  The Map, Loot, and Monster gold caps can be individually configured.

When the game is not running, edit the file in notepad and set the gold caps to whatever value is desired.  
Use zero to use the game's default cap instead.

# Uninstalling

## Uninstall This Mod Only
If you wish to uninstall just this mod, but want to be able to use other mods, delete the file GoDUENoLootLimit.dll from the BepInEx\plugins\ folder.  

## Full Uninstall
If you wish to fully uninstall the mod and the mod injector (BepInEx, which is what allows the mod to work), delete the following:
* BepInEx folder
* changelog.txt
* winhttp.dll

If you accidently delete other files, go to your game library in Steam or Epic and use the Verify command.  
This will scan all the game's files and re-download any files that are missing or don't match the expected version.







