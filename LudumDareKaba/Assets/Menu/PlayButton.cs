using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
//	void Start () {
//		
//	}

	public void onClickToPlay()
	{
		SceneManager.LoadScene("Kaba");
	}

	public void onClickToDispalyCredit()
	{
		Debug.Log ("CREDIT");
	}

	public void onClickToExit()
	{

	}

	// Update is called once per frame
//	void Update () {
//	
//	}
}
