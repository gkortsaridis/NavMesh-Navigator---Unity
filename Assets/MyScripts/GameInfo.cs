using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {

	public Font myFont;
	private bool infoVisible; 
	private GUIStyle myStyle;

	// Use this for initialization
	void Start () {

		myStyle = new GUIStyle ();
		myStyle.font = myFont;
		myStyle.fontSize = Screen.width / 25;
		myStyle.normal.textColor = Color.white;
		myStyle.alignment = TextAnchor.MiddleCenter;

		infoVisible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.Escape))Application.Quit();

		if(Input.GetKeyUp(KeyCode.I))infoVisible = !infoVisible;
	}


	void OnGUI(){

		if(infoVisible)
		{
			GUI.Label(new Rect(Screen.width/4,Screen.height/4,Screen.width/2,Screen.height/2),"Custom A* Pathfinding Algorith.\nUsing Navigation Meshes\n\nDeveloped by:\nDalgitsis Anestis\nKalampokis Georgios\nKortsaridis Georgios\n....\nand i little help from Unity3D\n\n\nPress Escape to Quit",myStyle);
				
		}
		
	}
	
}
