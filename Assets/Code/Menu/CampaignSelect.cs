using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampaignSelect : MonoBehaviour {

    List<CampaignInfo> Cams;

	// Use this for initialization
	void Start () {
		
	}
	
    void OnGUI(){

        GUI.Window(0, new Rect(50, 100, 450, 600), CamWin, "Choose Campaign");

    }

    void CamWin(int win){
        
    }

	// Update is called once per frame
	void Update () {
		
	}
}
