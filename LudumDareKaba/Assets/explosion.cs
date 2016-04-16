using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
    private float timer = 0.8f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0f)
        {
            this.GetComponent<SpriteRenderer>().color = new Color(1f,1f, 1f, this.GetComponent<SpriteRenderer>().color.a - 0.1f);
            if (this.GetComponent<SpriteRenderer>().material.color.a == 0f)
                Destroy(this.gameObject);
        }
        timer -= Time.deltaTime;
	}
}
