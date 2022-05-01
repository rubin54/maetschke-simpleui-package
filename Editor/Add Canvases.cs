using UnityEditor;
using UnityEngine;

namespace maetschke.simpleui.editor
{
    [InitializeOnLoad]
    public class AddCanvases : EditorWindow
    {
        public static bool showWindow = true;

        #region GUI
        void OnGUI()
        {
            Texture t = (Texture)Resources.Load("abcsoft");

            if (GUILayout.Button(t))
            {
                Application.OpenURL("");
            }

            GUILayout.Label("", GUI.skin.horizontalSlider);

            EditorGUILayout.HelpBox("", MessageType.Info);

            if (GUILayout.Button(""))
            {
                Application.OpenURL("");
            }
            if (GUILayout.Button("]"))
            {
                Application.OpenURL("");
            }
        }

        public static void OpenWindow()
        {
            if (showWindow)
            {
                GetWindow<AddCanvases>("Simple Main Menu");
                GetWindow<AddCanvases>("Simple Main Menu").maxSize = new Vector2(1920, 1080); // new Vector2(265, 350);
                GetWindow<AddCanvases>("Simple Main Menu").minSize = new Vector2(1920, 1080); // new Vector2(264, 350);

                showWindow = false;
            }
        }
        #endregion GUI

        #region MenuItem
        [MenuItem("UI/Support!", false, 1)]
        public static void Github()
        {
            GetWindow<AddCanvases>("Simple Main Menu");
            GetWindow<AddCanvases>("Simple Main Menu").maxSize = new Vector2(1920, 1080);
            GetWindow<AddCanvases>("Simple Main Menu").minSize = new Vector2(1920, 1080);

        }

        [MenuItem("UI/Add/Loading Canvas &#L", false)]
        public static void AddLoadingCanvas()
        {
            //instantiate Loading Canvas
            GameObject loadingScreen = Instantiate(Resources.Load("Prefabs/LoadingScreen Canvas")) as GameObject;
            //rename it
            loadingScreen.name = "Simple Loading Screen";

            Debug.Log("WIP");
        }

        [MenuItem("UI/Add/Main Menu Canvas  &#M", false)]
        public static void AddMainMenuCanvas()
        {
            //instantiate Main Menu Canvas
            GameObject mainMenu = Instantiate(Resources.Load("Prefabs/SimpleMainMenu")) as GameObject;
            //rename it
            mainMenu.name = "Simple Main Menu";

            GameObject bgImg = Instantiate(Resources.Load("Prefabs/BackgroundImageCamera")) as GameObject;
            //rename it
            bgImg.name = "Background Image";

            Debug.Log("Main Menu Created!");
        }

        [MenuItem("UI/Add/Gameplay UI &#G", false)]
        public static void AddGameplayUI()
        {
            Debug.Log("WIP");
        }

        [MenuItem("UI/Add/Save Game Trigger &#T", false)]
        public static void AddSaveGameTrigger()
        {
            Debug.Log("WIP");
        }

        [MenuItem("UI/Add/Tooltip System &#Y", false)]
        public static void AddTooltipSystem()
        {
            //instantiate Main Menu Canvas
            GameObject tooltipSystem = Instantiate(Resources.Load("Prefabs/Tooltip Canvas")) as GameObject;
            //rename it
            tooltipSystem.name = "Simple Tooltip System";

            //GameObject testTrigger = Instantiate(Resources.Load("Prefabs/Test Canvas")) as GameObject;
            ////rename it
            //tooltipSystem.name = "Trigger Test Canvas";
            //Debug.Log("Trigger Test Canvas Created!");
        }

        [MenuItem("UI/Clear Game Data &#X", false)]
        public static void ResetPlayerPref()
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("Game Data Cleared!");
        }
        #endregion MenuItem

    }
}

