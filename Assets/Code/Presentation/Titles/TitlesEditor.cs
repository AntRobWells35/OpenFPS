using UnityEngine;
using UnityEditor;
using System.Collections;


public class TitlesEditor : EditorWindow {

    public AudioClip TitleTrack;

    [MenuItem("OpenFPS/Titles Editor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(TitlesEditor));
    }

    void OnGUI()
    {

        GUILayout.BeginHorizontal();
        GUILayout.Label("Title Track", EditorStyles.boldLabel);
        TitleTrack = EditorGUILayout.ObjectField(TitleTrack,typeof(AudioClip),true) as AudioClip;
        GUILayout.EndHorizontal();

        
    }

}
