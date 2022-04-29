using UnityEngine;
using UnityEditor;
using maetschke.simpleui.runtime;

namespace maetschke.simpleui.editor
{
    [CustomEditor(typeof(MainMenuController))]
    public class MainMenuControllerEditor : Editor
    {

        public override void OnInspectorGUI()
        {
            AddCanvases.OpenWindow();

            EditorGUILayout.BeginVertical(EditorStyles.helpBox);

            EditorGUILayout.BeginHorizontal(EditorStyles.helpBox);

            EditorGUILayout.LabelField("Main Menu Controller", EditorStyles.helpBox);

            GUIStyle bSKin = new GUIStyle("box");
            bSKin.normal.textColor = Color.green;


            EditorGUILayout.EndHorizontal();


            EditorGUILayout.HelpBox("The Controller script which will be controlling the whole menu system behaviour.\n\n" + "",
                                      MessageType.Info);

            if (GUILayout.Button(""))
            {
                Application.OpenURL("");
            }


            EditorGUILayout.HelpBox("", MessageType.Info);

            base.OnInspectorGUI();

            EditorGUILayout.EndVertical();
        }

    }
}


