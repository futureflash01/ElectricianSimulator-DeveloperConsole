# Developer & Graphics Console Toggle - Electrician Simulator

A lightweight BepInEx plugin for *Electrician Simulator* that restores the ability to toggle the hidden Developer and Graphics Consoles using simple hotkeys. 

## 🎮 Features
* **Graphics Console (`F9`):** Press `F9` in-game after loading a save file to open the Graphics Console, which grants access to the item menu and allows you to add objects directly to your player inventory
* **Developer Console (`F10`):** Press `F10` in-game after loading a save file to expose the Developer Console UI. *(Note: Command execution requires a developer build of the game; this feature is included as a proof-of-concept for modders and researchers).*
* **Seamless Integration:** Runs non-destructively in the background and safely waits until you load into a save file before attaching to the user interface.

## 🛠️ Requirements
* [BepInEx 6.0.0+ (IL2CPP)](https://github.com/BepInEx/BepInEx)
* Electrician Simulator ([Steam Store Link](https://store.steampowered.com/app/1080020/Electrician_Simulator/), [Epic Games Store Link](https://store.epicgames.com/p/electrician-simulator-164e9f), [Microsoft Store Link](https://www.xbox.com/en-US/games/store/electrician-simulator/9NL56ZNV72WT/0010))

## 📥 Installation

**For Players:**
1. Ensure you have BepInEx installed for Electrician Simulator.
2. Download the latest `GraphicsConsoleToggle.dll` from the [Releases](../../releases) tab.
3. Drop the `.dll` file into your `BepInEx/plugins` folder located in your game directory:
   `...\Steam\steamapps\common\Electrician Simulator\BepInEx\plugins\`
4. Launch the game, load your save, and press `F9` or `F10`!

## 📄 License
This project is open-source and available under the MIT License.
