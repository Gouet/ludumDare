using UnityEngine;
using System.Collections;

public class MetaMorph : MonoBehaviour {

	//public
	public Rigidbody2D rb;
	void Start() {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = Vector2.right;
	}

	void FixedUpdate() {
		if (Input.GetButtonDown ("Jump")) {
			rb.velocity = new Vector3 (0, 10, 0);
			Debug.Log ("loffff");
		}
	}

	// Use this for initialization
//	void Start () {
//		
//	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
