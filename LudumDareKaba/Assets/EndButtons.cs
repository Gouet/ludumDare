using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndButtons : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//		
//	}

	public void onClickToPlay()
	{
		deathChecker.isAlive = true;
		SceneManager.LoadScene("Kaba");
	}

	public void onClickToMenu()
	{
		SceneManager.LoadScene ("Menu");
	}
		
	// Update is called once per frame
//	void Update () {
//	
//	}
}
