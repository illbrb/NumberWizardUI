using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using LevelManager;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;
	
	public int maxGuessesAllowed = 10;
	
	public Text guessText;
	
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;
	}
	
	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}
	
	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		guessText.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0)
		{
			Application.LoadLevel("Win");
		}
	}
}
