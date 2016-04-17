using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class deathChecker : MonoBehaviour {

	private Text t;
	private float f;
	public static bool isAlive = true;

	// Use this for initialization
	void Start () {
		t = GameObject.Find ("LifeCount").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (isAlive == false && float.Parse(t.text) > 0)
            isAlive = true;
		if (isAlive && float.Parse (t.text) <= 0) {
			this.GetComponent<Canvas> ().enabled = true;
			f = float.Parse(GameObject.Find("Score").GetComponent<Text>().text);
			isAlive = false;
			float oldHighscore = PlayerPrefs.GetFloat ("Highscore");
			if (oldHighscore < f)
				GameObject.Find("FinalScore").GetComponent<Text>().text = "NEW HIGHSCORE : " + f.ToString() + "!!!\nWELL DONE!!!";
			else
				GameObject.Find("FinalScore").GetComponent<Text>().text = "HIGHSCORE : " + oldHighscore.ToString() + "\nYOUR SCORE : " + f.ToString();
			PlayerPrefs.SetFloat ("Highscore", Mathf.Max(oldHighscore, f));
		}
	}
}
