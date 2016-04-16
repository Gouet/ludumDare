using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 3f;
    public float delay = 0f;
    private float tmp;


    void Start()
    {
        tmp = delay;
    }


    void FixedUpdate()
    {
        if (tmp <= 0)
        {
            tmp = spawnTime;
            Instantiate(enemy, this.transform.position, this.transform.rotation);
        }
        else
            tmp -= Time.deltaTime;
    }
}