using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
	public float spawnTimeMin = 0f;
    public float spawnTimeMax = 3f;
    public float delay = 0f;
    private float tmp;
	public int order = 0;


    void Start()
    {
		tmp = Random.Range (spawnTimeMin, spawnTimeMax);
		enemy.GetComponent<Renderer> ().sortingOrder = order;
    }

    void FixedUpdate()
    {
        if (tmp <= 0)
        {
			tmp = Random.Range(spawnTimeMin, spawnTimeMax);
            Instantiate(enemy, this.transform.position, this.transform.rotation);
        }
        else
            tmp -= Time.deltaTime;
    }
}