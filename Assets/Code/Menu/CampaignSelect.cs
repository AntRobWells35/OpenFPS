using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CampaignSelect : MonoBehaviour {

    public List<CampaignInfo> Cams;
    public Image CamImage;
    public Text CamName;

	// Use this for initialization
	void Start () {
		
	}
	
    void OnGUI(){

        GUI.Window(0, new Rect(50, 100, 450, 500), CamWin, "Choose Campaign");

    }

    private Vector2 CSP;

    void CamWin(int win){

        CSP=GUILayout.BeginScrollView(CSP);

        foreach(var cinfo in Cams)
        {

            GUILayout.Label(cinfo.CamName + " Author:" + cinfo.Author);
            GUILayout.TextArea(cinfo.CamInfo);
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Select"))
            {

            }
            if(GUILayout.Button("More Info"))
            {
                CamName.text = cinfo.CamName;
                CamImage.sprite = cinfo.CamImage;
            }
            GUILayout.EndHorizontal();

        }

        GUILayout.EndScrollView();

    }

	// Update is called once per frame
	void Update () {
		
	}
}
