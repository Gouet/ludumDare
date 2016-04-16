using UnityEngine;
using System.Collections;

public class MetaMorph : MonoBehaviour {

	//public
	public Rigidbody2D rb;
    public float speed;

	public enum State {
		Cat,
		Zombie
	};

	public State state;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = Vector2.right * speed;
	}

	void FixedUpdate() {
		if (Input.GetButtonDown ("Jump")) {
		//	rb.velocity = new Vector2 (0, 10);

			Debug.Log ("loffff");
		}
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position = new Vector2 (this.transform.position.x, 0);
		//rb.velocity = Vector2.right;
	}
}
