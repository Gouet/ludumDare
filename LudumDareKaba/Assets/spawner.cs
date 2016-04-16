using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 3f;
    private float tmp = 0f;


    void Start()
    {
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