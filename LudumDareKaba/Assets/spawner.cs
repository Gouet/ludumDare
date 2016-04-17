using UnityEngine;
using UnityEngine.UI;

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
		tmp = Random.Range(2f, 8f);
		enemy.GetComponent<Renderer> ().sortingOrder = order;
    }

    void FixedUpdate()
    {
		if (tmp <= 0)
        {
			tmp = Random.Range(Mathf.Max(spawnTimeMin - (float.Parse(GameObject.Find("Score").GetComponent<Text>().text) / 100), 1f), spawnTimeMax);
            Instantiate(enemy, this.transform.position, this.transform.rotation);
        }
        else
            tmp -= Time.deltaTime;
    }
}