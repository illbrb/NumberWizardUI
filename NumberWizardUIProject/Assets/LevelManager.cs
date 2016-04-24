using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string levelName){
		Application.LoadLevel(levelName);
		Debug.Log("Level Load Requested for: " + levelName);
		
	}

	public void QuitGame(){
		Debug.Log("Quit Game Requested");
		Application.Quit();		
	}
}
