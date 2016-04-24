using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{

	public void LoadLevel(string levelName)
	{
		Application.LoadLevel(levelName);		
	}

	public void QuitGame(){
		Application.Quit();		
	}	
}

