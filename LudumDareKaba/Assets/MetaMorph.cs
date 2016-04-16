using UnityEngine;
using System.Collections;

public class MetaMorph : MonoBehaviour {

	//public
    public GameObject explosion;
    public float speed;
	public AudioClip meow;

	private int transf;
    private float timer = 1f;
	private Rigidbody2D rb;
	private AudioSource audiosrc;

	public enum State {
		Cat,
		Goblin
	};

	public State state = State.Goblin;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = Vector2.right * speed;
		audiosrc = GetComponent<AudioSource>();
	}

	void FixedUpdate() {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            transf = Random.Range(0, 5);
            timer = 1f;
        }
		if (transf == 3 && state == State.Goblin)
        {
			audiosrc.PlayOneShot (meow);
            state = State.Cat;
			gameObject.GetComponent<BoxCollider2D> ().offset = new Vector2 (-1.094101f, -0.05470467f);
			gameObject.GetComponent<BoxCollider2D> ().size = new Vector2 (3.371798f, 3.945899f);
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
