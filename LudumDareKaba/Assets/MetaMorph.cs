using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MetaMorph : MonoBehaviour {

	//public
    public GameObject explosion;
    public float speed;
	public AudioClip meow;

	public GameObject textEditorObject;

	private int transf;
    private float timer = 1f;
	private Rigidbody2D rb;
	private AudioSource audiosrc;
    private bool canTrans = false;

	public enum State {
		Cat,
		Goblin
	};

	public State state = State.Goblin;

	void Start() {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = Vector2.right * (speed + (speed < 0 ? -1 : 1) * (float.Parse(GameObject.Find("Score").GetComponent<Text>().text)) / 1000);
		audiosrc = GetComponent<AudioSource>();
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
		if (state == State.Cat && coll.gameObject.name == "destructor") {
			GameObject g = GameObject.Find ("LifeCount");
			g.GetComponent<Text> ().text = Mathf.Max((float.Parse (g.GetComponent<Text> ().text) - 1), 0).ToString ();
		}
        if (coll.gameObject.name == "activator")
        {
            canTrans = !canTrans;
        }
    }

    void FixedUpdate() {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            transf = Random.Range(0, 5);
            timer = 1f;
        }
		if (transf == 3 && canTrans == true && state == State.Goblin)
        {
			audiosrc.PlayOneShot (meow);
            state = State.Cat;
			gameObject.GetComponent<BoxCollider2D> ().offset = new Vector2 (0f, -0.05470467f);
			gameObject.GetComponent<BoxCollider2D> ().size = new Vector2 (3.371798f, 3.945899f);
            gameObject.GetComponent<Animator>().SetTrigger("cat");
        }
	}

    void OnMouseDown()
    {
		if (deathChecker.isAlive)
		{
			Instantiate(explosion, this.transform.position, this.transform.rotation);
			if (state == State.Cat) {
				GameObject g = GameObject.Find ("Score");
				g.GetComponent<Text> ().text = (float.Parse (g.GetComponent<Text> ().text) + 10).ToString ();
			} else if (state == State.Goblin) {
				GameObject g = GameObject.Find ("LifeCount");
				g.GetComponent<Text> ().text = (float.Parse (g.GetComponent<Text> ().text) - 1).ToString ();
			}
	        Destroy(this.gameObject);
		}
    }
    // Update is called once per frame
    void Update () {
        
	}
}
