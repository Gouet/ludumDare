using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTimeMax = 3f;
    public float delay = 0f;
    private float tmp;


    void Start()
    {
		if (delay > 0)
			tmp = Random.Range (0, delay);
		else
			tmp = Random.Range (delay, 3f);
    }


    void FixedUpdate()
    {
        if (tmp <= 0)
        {
			tmp = Random.Range(3f, spawnTimeMax);
            Instantiate(enemy, this.transform.position, this.transform.rotation);
        }
        else
            tmp -= Time.deltaTime;
    }
}