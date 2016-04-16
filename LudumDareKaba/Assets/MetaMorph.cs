using UnityEngine;
using System.Collections;

public class MetaMorph : MonoBehaviour {

	//public
	public Rigidbody2D rb;
    public GameObject explosion;
    public float speed;
    private int transf;
    private float timer = 1f;

	public enum State {
		Cat,
		Goblin
	};

	public State state = State.Goblin;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = Vector2.right * speed;
	}

	void FixedUpdate() {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            transf = Random.Range(0, 5);
            timer = 1f;
        }
        if (transf == 3)
        {
            state = State.Cat;
            gameObject.GetComponent<Animator>().SetTrigger("cat");
        }
	}
    void OnMouseDown()
    {
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update () {
        
	}
}
