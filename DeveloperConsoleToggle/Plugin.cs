using BepInEx;
using BepInEx.Unity.IL2CPP;
using UnityEngine;
using Il2CppInterop.Runtime.Injection;

namespace DeveloperConsoleToggle
{
    [BepInPlugin("futureflash.electriciansim.devconsoletoggle", "Developer Console Toggle", "1.0.0")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            Log.LogInfo("Developer/Graphics Console Toggle loaded - initializing...");

            // Register custom class
            ClassInjector.RegisterTypeInIl2Cpp<ToggleBehaviour>();

            // Create a new and empty GameObject that has the code/script
            var pluginObject = new GameObject("DeveloperConsoleToggle_Object");

            // Prevent Unity from destroying the object when a save file/scene loads
            Object.DontDestroyOnLoad(pluginObject);

            // Attach the script to the GameObject and hide it from the scene. Took me a while to figure this out, but eventually I just copied some of the game's logic for other objects
            pluginObject.AddComponent<ToggleBehaviour>();
            pluginObject.hideFlags = HideFlags.HideAndDontSave;

            Log.LogInfo("ToggleBehaviour successfully attached to the game! - Press F9 to open GraphicsConsole and F10 for DeveloperConsole (not working, just proof of concept! You have to own an actual Developer build of the game for this to work properly.)");
        }
    }

    public class ToggleBehaviour : MonoBehaviour
    {
        private void Update()
        {
            // Make sure to look for the GameObject only after pressing F9
            if (Input.GetKeyDown(KeyCode.F9))
            {
                // Locate the parent canvas
                var gameCanvas = GameObject.Find("GameCanvas");

                if (gameCanvas != null)
                {
                    // Find the actual GraphicsConsole class. Full path: 'GameCanvas/DEBUG_UI/GraphicsConsole'
                    var gc = gameCanvas.transform.Find("DEBUG_UI/GraphicsConsole");

                    if (gc != null)
                    {
                        // Toggle the active state. This is the code equivelant to checking the 'ActiveSelf' box in UnityExplorer
                        bool newState = !gc.gameObject.activeSelf;
                        gc.gameObject.SetActive(newState);
                    }
                }
            }
			
			// Make sure to look for the GameObject only after pressing F9
			if (Input.GetKeyDown(KeyCode.F10))
            {
                // Same exact logic as before
                var gameCanvas1 = GameObject.Find("GameCanvas");

                if (gameCanvas1 != null)
                {
                    var gc1 = gameCanvas1.transform.Find("DEBUG_UI/DeveloperConsole");

                    if (gc1 != null)
                    {
                        bool newState1 = !gc1.gameObject.activeSelf;
                        gc1.gameObject.SetActive(newState1);
                    }
                }
            }
        }
    }
}