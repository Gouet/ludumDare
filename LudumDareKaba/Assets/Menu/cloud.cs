using UnityEngine;
using System.Collections;

public class cloud : MonoBehaviour {

	public Rigidbody2D rb;
	//public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		transform.position = new Vector2(transform.position.x, transform.position.y + (float)(Random.value % 15 - 3));
		rb.velocity = Vector2.right * (float)(Random.value % 20 + 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
